
namespace Lab1_19520430_ToDoanCaoChuong
{
    partial class Bai5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxDTB = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.textBoxDau = new System.Windows.Forms.TextBox();
            this.textBoxHocluc = new System.Windows.Forms.TextBox();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxRot = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(251, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phần mềm quản lý điểm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách điểm";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(221, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(512, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(627, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "XUẤT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Danh sách môn học và điểm";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(40, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 198);
            this.panel1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(20, 19);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(671, 177);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxDTB
            // 
            this.textBoxDTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDTB.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDTB.Location = new System.Drawing.Point(40, 410);
            this.textBoxDTB.Name = "textBoxDTB";
            this.textBoxDTB.ReadOnly = true;
            this.textBoxDTB.Size = new System.Drawing.Size(321, 20);
            this.textBoxDTB.TabIndex = 7;
            // 
            // textBoxMax
            // 
            this.textBoxMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMax.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMax.Location = new System.Drawing.Point(40, 443);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.ReadOnly = true;
            this.textBoxMax.Size = new System.Drawing.Size(321, 20);
            this.textBoxMax.TabIndex = 8;
            // 
            // textBoxDau
            // 
            this.textBoxDau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDau.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDau.Location = new System.Drawing.Point(40, 476);
            this.textBoxDau.Name = "textBoxDau";
            this.textBoxDau.ReadOnly = true;
            this.textBoxDau.Size = new System.Drawing.Size(321, 20);
            this.textBoxDau.TabIndex = 9;
            // 
            // textBoxHocluc
            // 
            this.textBoxHocluc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHocluc.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHocluc.Location = new System.Drawing.Point(411, 410);
            this.textBoxHocluc.Name = "textBoxHocluc";
            this.textBoxHocluc.ReadOnly = true;
            this.textBoxHocluc.Size = new System.Drawing.Size(321, 20);
            this.textBoxHocluc.TabIndex = 10;
            // 
            // textBoxMin
            // 
            this.textBoxMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMin.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMin.Location = new System.Drawing.Point(411, 444);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.ReadOnly = true;
            this.textBoxMin.Size = new System.Drawing.Size(321, 20);
            this.textBoxMin.TabIndex = 11;
            // 
            // textBoxRot
            // 
            this.textBoxRot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRot.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRot.Location = new System.Drawing.Point(411, 476);
            this.textBoxRot.Name = "textBoxRot";
            this.textBoxRot.ReadOnly = true;
            this.textBoxRot.Size = new System.Drawing.Size(322, 20);
            this.textBoxRot.TabIndex = 12;
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 528);
            this.Controls.Add(this.textBoxRot);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.textBoxHocluc);
            this.Controls.Add(this.textBoxDau);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.textBoxDTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Bai5";
            this.Text = "Quản lý điểm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxDTB;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.TextBox textBoxDau;
        private System.Windows.Forms.TextBox textBoxHocluc;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.TextBox textBoxRot;
    }
}