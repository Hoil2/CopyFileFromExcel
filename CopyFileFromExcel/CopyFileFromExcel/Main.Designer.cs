
namespace CopyFileFromExcel
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoadExcelFile = new System.Windows.Forms.Button();
            this.lblExcelPath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSavePath = new System.Windows.Forms.Label();
            this.btnSpecifySavePath = new System.Windows.Forms.Button();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWordColumn = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCurrentFilePath = new System.Windows.Forms.Label();
            this.btnSpecifyCurrentFilePath = new System.Windows.Forms.Button();
            this.ofdExcel = new System.Windows.Forms.OpenFileDialog();
            this.fbdSavePath = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdCurrentFilePath = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFilenameColumn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLoadExcelFile
            // 
            this.btnLoadExcelFile.Location = new System.Drawing.Point(348, 12);
            this.btnLoadExcelFile.Name = "btnLoadExcelFile";
            this.btnLoadExcelFile.Size = new System.Drawing.Size(75, 23);
            this.btnLoadExcelFile.TabIndex = 0;
            this.btnLoadExcelFile.Text = "Browser";
            this.btnLoadExcelFile.UseVisualStyleBackColor = true;
            this.btnLoadExcelFile.Click += new System.EventHandler(this.btnLoadExcelFile_Click);
            // 
            // lblExcelPath
            // 
            this.lblExcelPath.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblExcelPath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblExcelPath.Location = new System.Drawing.Point(84, 12);
            this.lblExcelPath.Name = "lblExcelPath";
            this.lblExcelPath.Size = new System.Drawing.Size(258, 23);
            this.lblExcelPath.TabIndex = 1;
            this.lblExcelPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Excel File";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Save Path";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSavePath
            // 
            this.lblSavePath.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSavePath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSavePath.Location = new System.Drawing.Point(84, 48);
            this.lblSavePath.Name = "lblSavePath";
            this.lblSavePath.Size = new System.Drawing.Size(258, 23);
            this.lblSavePath.TabIndex = 4;
            this.lblSavePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSpecifySavePath
            // 
            this.btnSpecifySavePath.Location = new System.Drawing.Point(348, 49);
            this.btnSpecifySavePath.Name = "btnSpecifySavePath";
            this.btnSpecifySavePath.Size = new System.Drawing.Size(75, 23);
            this.btnSpecifySavePath.TabIndex = 3;
            this.btnSpecifySavePath.Text = "Browser";
            this.btnSpecifySavePath.UseVisualStyleBackColor = true;
            this.btnSpecifySavePath.Click += new System.EventHandler(this.btnSpecifySavePath_Click);
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(102, 130);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(115, 21);
            this.txtWord.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Word for copy";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Column number";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtWordColumn
            // 
            this.txtWordColumn.Location = new System.Drawing.Point(48, 187);
            this.txtWordColumn.Name = "txtWordColumn";
            this.txtWordColumn.Size = new System.Drawing.Size(48, 21);
            this.txtWordColumn.TabIndex = 8;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStart.Location = new System.Drawing.Point(245, 130);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(178, 78);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 33);
            this.label6.TabIndex = 13;
            this.label6.Text = "Current File Path";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrentFilePath
            // 
            this.lblCurrentFilePath.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCurrentFilePath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurrentFilePath.Location = new System.Drawing.Point(84, 83);
            this.lblCurrentFilePath.Name = "lblCurrentFilePath";
            this.lblCurrentFilePath.Size = new System.Drawing.Size(258, 23);
            this.lblCurrentFilePath.TabIndex = 12;
            this.lblCurrentFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSpecifyCurrentFilePath
            // 
            this.btnSpecifyCurrentFilePath.Location = new System.Drawing.Point(348, 84);
            this.btnSpecifyCurrentFilePath.Name = "btnSpecifyCurrentFilePath";
            this.btnSpecifyCurrentFilePath.Size = new System.Drawing.Size(75, 23);
            this.btnSpecifyCurrentFilePath.TabIndex = 11;
            this.btnSpecifyCurrentFilePath.Text = "Browser";
            this.btnSpecifyCurrentFilePath.UseVisualStyleBackColor = true;
            this.btnSpecifyCurrentFilePath.Click += new System.EventHandler(this.btnSpecifyCurrentFilePath_Click);
            // 
            // ofdExcel
            // 
            this.ofdExcel.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Word";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(106, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "File name";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFilenameColumn
            // 
            this.txtFilenameColumn.Location = new System.Drawing.Point(169, 187);
            this.txtFilenameColumn.Name = "txtFilenameColumn";
            this.txtFilenameColumn.Size = new System.Drawing.Size(48, 21);
            this.txtFilenameColumn.TabIndex = 16;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 224);
            this.Controls.Add(this.txtFilenameColumn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCurrentFilePath);
            this.Controls.Add(this.btnSpecifyCurrentFilePath);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtWordColumn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSavePath);
            this.Controls.Add(this.btnSpecifySavePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblExcelPath);
            this.Controls.Add(this.btnLoadExcelFile);
            this.Name = "frmMain";
            this.Text = "Copy File";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadExcelFile;
        private System.Windows.Forms.Label lblExcelPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSavePath;
        private System.Windows.Forms.Button btnSpecifySavePath;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWordColumn;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCurrentFilePath;
        private System.Windows.Forms.Button btnSpecifyCurrentFilePath;
        private System.Windows.Forms.OpenFileDialog ofdExcel;
        private System.Windows.Forms.FolderBrowserDialog fbdSavePath;
        private System.Windows.Forms.FolderBrowserDialog fbdCurrentFilePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFilenameColumn;
    }
}

