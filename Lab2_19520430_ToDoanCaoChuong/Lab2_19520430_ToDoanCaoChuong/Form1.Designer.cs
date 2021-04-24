
namespace Lab2_19520430_ToDoanCaoChuong
{
    partial class Main
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
            this.Bai1 = new System.Windows.Forms.Button();
            this.Bai2 = new System.Windows.Forms.Button();
            this.Bai3 = new System.Windows.Forms.Button();
            this.Bai4 = new System.Windows.Forms.Button();
            this.Bai5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bai1
            // 
            this.Bai1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bai1.Location = new System.Drawing.Point(204, 47);
            this.Bai1.Name = "Bai1";
            this.Bai1.Size = new System.Drawing.Size(179, 111);
            this.Bai1.TabIndex = 0;
            this.Bai1.Text = "1. Ghi và Đọc file   (cơ bản)";
            this.Bai1.UseVisualStyleBackColor = true;
            this.Bai1.Click += new System.EventHandler(this.Bai1_Click);
            // 
            // Bai2
            // 
            this.Bai2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bai2.Location = new System.Drawing.Point(204, 165);
            this.Bai2.Name = "Bai2";
            this.Bai2.Size = new System.Drawing.Size(179, 111);
            this.Bai2.TabIndex = 1;
            this.Bai2.Text = "2. Đọc thông tin một file .txt";
            this.Bai2.UseVisualStyleBackColor = true;
            this.Bai2.Click += new System.EventHandler(this.Bai2_Click);
            // 
            // Bai3
            // 
            this.Bai3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bai3.Location = new System.Drawing.Point(204, 282);
            this.Bai3.Name = "Bai3";
            this.Bai3.Size = new System.Drawing.Size(177, 111);
            this.Bai3.TabIndex = 2;
            this.Bai3.Text = "3. Đọc và Ghi file (mở rộng)";
            this.Bai3.UseVisualStyleBackColor = true;
            this.Bai3.Click += new System.EventHandler(this.Bai3_Click);
            // 
            // Bai4
            // 
            this.Bai4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bai4.Location = new System.Drawing.Point(387, 47);
            this.Bai4.Name = "Bai4";
            this.Bai4.Size = new System.Drawing.Size(179, 170);
            this.Bai4.TabIndex = 3;
            this.Bai4.Text = "4. Làm việc với File CSDL";
            this.Bai4.UseVisualStyleBackColor = true;
            this.Bai4.Click += new System.EventHandler(this.Bai4_Click);
            // 
            // Bai5
            // 
            this.Bai5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bai5.Location = new System.Drawing.Point(387, 223);
            this.Bai5.Name = "Bai5";
            this.Bai5.Size = new System.Drawing.Size(179, 170);
            this.Bai5.TabIndex = 4;
            this.Bai5.Text = "5. Duyệt thư mục";
            this.Bai5.UseVisualStyleBackColor = true;
            this.Bai5.Click += new System.EventHandler(this.Bai5_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bai5);
            this.Controls.Add(this.Bai4);
            this.Controls.Add(this.Bai3);
            this.Controls.Add(this.Bai2);
            this.Controls.Add(this.Bai1);
            this.Name = "Main";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bai1;
        private System.Windows.Forms.Button Bai2;
        private System.Windows.Forms.Button Bai3;
        private System.Windows.Forms.Button Bai4;
        private System.Windows.Forms.Button Bai5;
    }
}

