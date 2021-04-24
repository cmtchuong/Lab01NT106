
namespace Lab2_19520430_ToDoanCaoChuong
{
    partial class Bai2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReadFile = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.FileName = new System.Windows.Forms.Label();
            this.URL = new System.Windows.Forms.Label();
            this.CountLine = new System.Windows.Forms.Label();
            this.CountWord = new System.Windows.Forms.Label();
            this.CountChar = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.textBoxLine = new System.Windows.Forms.TextBox();
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.textBoxChar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ReadFile
            // 
            this.ReadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadFile.Location = new System.Drawing.Point(27, 13);
            this.ReadFile.Name = "ReadFile";
            this.ReadFile.Size = new System.Drawing.Size(217, 71);
            this.ReadFile.TabIndex = 0;
            this.ReadFile.Text = "ĐỌC FILE";
            this.ReadFile.UseVisualStyleBackColor = true;
            this.ReadFile.Click += new System.EventHandler(this.ReadFile_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(284, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(504, 426);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // FileName
            // 
            this.FileName.AutoSize = true;
            this.FileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileName.Location = new System.Drawing.Point(6, 110);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(59, 18);
            this.FileName.TabIndex = 2;
            this.FileName.Text = "Tên file:";
            // 
            // URL
            // 
            this.URL.AutoSize = true;
            this.URL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URL.Location = new System.Drawing.Point(6, 161);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(42, 18);
            this.URL.TabIndex = 3;
            this.URL.Text = "URL:";
            // 
            // CountLine
            // 
            this.CountLine.AutoSize = true;
            this.CountLine.Location = new System.Drawing.Point(6, 209);
            this.CountLine.Name = "CountLine";
            this.CountLine.Size = new System.Drawing.Size(65, 17);
            this.CountLine.TabIndex = 4;
            this.CountLine.Text = "Số dòng:";
            // 
            // CountWord
            // 
            this.CountWord.AutoSize = true;
            this.CountWord.Location = new System.Drawing.Point(6, 262);
            this.CountWord.Name = "CountWord";
            this.CountWord.Size = new System.Drawing.Size(45, 17);
            this.CountWord.TabIndex = 5;
            this.CountWord.Text = "Số từ:";
            this.CountWord.Click += new System.EventHandler(this.CountWord_Click);
            // 
            // CountChar
            // 
            this.CountChar.AutoSize = true;
            this.CountChar.Location = new System.Drawing.Point(6, 318);
            this.CountChar.Name = "CountChar";
            this.CountChar.Size = new System.Drawing.Size(63, 17);
            this.CountChar.TabIndex = 6;
            this.CountChar.Text = "Số ký tự:";
            this.CountChar.Click += new System.EventHandler(this.CountChar_Click);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(78, 110);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.ReadOnly = true;
            this.textBoxFileName.Size = new System.Drawing.Size(165, 22);
            this.textBoxFileName.TabIndex = 7;
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(78, 157);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.ReadOnly = true;
            this.textBoxURL.Size = new System.Drawing.Size(165, 22);
            this.textBoxURL.TabIndex = 8;
            // 
            // textBoxLine
            // 
            this.textBoxLine.Location = new System.Drawing.Point(78, 206);
            this.textBoxLine.Name = "textBoxLine";
            this.textBoxLine.ReadOnly = true;
            this.textBoxLine.Size = new System.Drawing.Size(165, 22);
            this.textBoxLine.TabIndex = 9;
            // 
            // textBoxWord
            // 
            this.textBoxWord.Location = new System.Drawing.Point(78, 257);
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.ReadOnly = true;
            this.textBoxWord.Size = new System.Drawing.Size(165, 22);
            this.textBoxWord.TabIndex = 10;
            // 
            // textBoxChar
            // 
            this.textBoxChar.Location = new System.Drawing.Point(78, 315);
            this.textBoxChar.Name = "textBoxChar";
            this.textBoxChar.ReadOnly = true;
            this.textBoxChar.Size = new System.Drawing.Size(165, 22);
            this.textBoxChar.TabIndex = 11;
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxChar);
            this.Controls.Add(this.textBoxWord);
            this.Controls.Add(this.textBoxLine);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.CountChar);
            this.Controls.Add(this.CountWord);
            this.Controls.Add(this.CountLine);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ReadFile);
            this.Name = "Bai2";
            this.Text = "Đọc thông tin một file .txt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReadFile;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label FileName;
        private System.Windows.Forms.Label URL;
        private System.Windows.Forms.Label CountLine;
        private System.Windows.Forms.Label CountWord;
        private System.Windows.Forms.Label CountChar;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.TextBox textBoxLine;
        private System.Windows.Forms.TextBox textBoxWord;
        private System.Windows.Forms.TextBox textBoxChar;
    }
}