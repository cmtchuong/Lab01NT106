
namespace Lab2_19520430_ToDoanCaoChuong
{
    partial class Bai3
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
            this.StreamReader = new System.Windows.Forms.Button();
            this.StreamWriter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // StreamReader
            // 
            this.StreamReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreamReader.Location = new System.Drawing.Point(12, 12);
            this.StreamReader.Name = "StreamReader";
            this.StreamReader.Size = new System.Drawing.Size(171, 42);
            this.StreamReader.TabIndex = 0;
            this.StreamReader.Text = "Đọc";
            this.StreamReader.UseVisualStyleBackColor = true;
            this.StreamReader.Click += new System.EventHandler(this.StreamReader_Click);
            // 
            // StreamWriter
            // 
            this.StreamWriter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreamWriter.Location = new System.Drawing.Point(621, 12);
            this.StreamWriter.Name = "StreamWriter";
            this.StreamWriter.Size = new System.Drawing.Size(171, 42);
            this.StreamWriter.TabIndex = 1;
            this.StreamWriter.Text = "Ghi";
            this.StreamWriter.UseVisualStyleBackColor = true;
            this.StreamWriter.Click += new System.EventHandler(this.StreamWriter_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(318, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tính";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Location = new System.Drawing.Point(12, 68);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(388, 362);
            this.richTextBoxInput.TabIndex = 3;
            this.richTextBoxInput.Text = "";
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Location = new System.Drawing.Point(407, 68);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.Size = new System.Drawing.Size(384, 361);
            this.richTextBoxOutput.TabIndex = 4;
            this.richTextBoxOutput.Text = "";
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.richTextBoxInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StreamWriter);
            this.Controls.Add(this.StreamReader);
            this.Name = "Bai3";
            this.Text = "Đọc và Ghi file (Mở rộng)";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StreamReader;
        private System.Windows.Forms.Button StreamWriter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
    }
}