using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyFileFromExcel
{
    public partial class frmMain : Form
    {
        Microsoft.Office.Interop.Excel.Application excel;
        Workbook workbook;
        Worksheet worksheet1;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLoadExcelFile_Click(object sender, EventArgs e)
        {
            if(ofdExcel.ShowDialog() == DialogResult.OK)
            {
                lblExcelPath.Text = ofdExcel.FileName;
            }
            excel = new Microsoft.Office.Interop.Excel.Application();

            workbook = excel.Workbooks.Open(ofdExcel.FileName); // 무조건 파일 실행됨
            excel.Visible = false; // 엑셀 파일 끄기
            
        }

        private void btnSpecifySavePath_Click(object sender, EventArgs e)
        {
            if(fbdSavePath.ShowDialog() == DialogResult.OK)
            {
                lblSavePath.Text = fbdSavePath.SelectedPath;
            }
        }

        private void btnSpecifyCurrentFilePath_Click(object sender, EventArgs e)
        {
            if(fbdCurrentFilePath.ShowDialog() == DialogResult.OK)
            {
                lblCurrentFilePath.Text = fbdCurrentFilePath.SelectedPath;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            List<string> filePaths = new List<string>();
            List<string> fileSavePaths = new List<string>();

            worksheet1 = workbook.Worksheets.get_Item(1);
            Range range = worksheet1.UsedRange;

            for (int i = 1; i < range.Rows.Count; i++)
            {
                string word = (range.Cells[i, int.Parse(txtWordColumn.Text)] as Range).Value2.ToString();
                
                if (txtWord.Text.Equals(word))
                {
                    string filename = (range.Cells[i, int.Parse(txtFilenameColumn.Text)] as Range).Value2.ToString();
                    filePaths.Add(lblCurrentFilePath.Text + "/" + filename);
                    fileSavePaths.Add(lblSavePath.Text + "/" + filename);

                }
            }

            for (int i = 0; i < filePaths.Count; i++)
            {
                
                System.IO.File.Copy(filePaths[i], fileSavePaths[i], true);
                Console.WriteLine(filePaths[i] + "->" + fileSavePaths[i] + "복사 완료");
            }
        }

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                worksheet1.Delete();
                workbook.Close();
                excel.Quit();
                DeleteObject(worksheet1);
                DeleteObject(workbook);
                DeleteObject(excel);
            }
            catch { }
            finally
            {
                // 엑셀 프로세스 강제 종료
                try
                {
                    uint exProcessHandle;
                    GetWindowThreadProcessId((IntPtr)excel.Hwnd, out exProcessHandle);
                    System.Diagnostics.Process excelProcess = System.Diagnostics.Process.GetProcessById((int)exProcessHandle);
                    if (excelProcess != null)
                    {
                        excelProcess.Kill();
                        excelProcess.Dispose();
                    }
                }
                catch { }
            }
        }
        private void DeleteObject(object obj)
        {
            try
            {
                Marshal.ReleaseComObject(obj);
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
