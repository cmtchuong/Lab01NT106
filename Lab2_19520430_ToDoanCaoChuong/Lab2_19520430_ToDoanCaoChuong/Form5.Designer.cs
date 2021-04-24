
namespace Lab2_19520430_ToDoanCaoChuong
{
    partial class Bai4
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
            this.InputButton = new System.Windows.Forms.Button();
            this.SaveInExcel = new System.Windows.Forms.Button();
            this.ShowInExcel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // InputButton
            // 
            this.InputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputButton.Location = new System.Drawing.Point(10, 18);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(199, 46);
            this.InputButton.TabIndex = 0;
            this.InputButton.Text = "Nhập dữ liệu";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // SaveInExcel
            // 
            this.SaveInExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveInExcel.Location = new System.Drawing.Point(9, 83);
            this.SaveInExcel.Name = "SaveInExcel";
            this.SaveInExcel.Size = new System.Drawing.Size(199, 46);
            this.SaveInExcel.TabIndex = 1;
            this.SaveInExcel.Text = "Lưu";
            this.SaveInExcel.UseVisualStyleBackColor = true;
            this.SaveInExcel.Click += new System.EventHandler(this.SaveInExcel_Click);
            // 
            // ShowInExcel
            // 
            this.ShowInExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowInExcel.Location = new System.Drawing.Point(11, 148);
            this.ShowInExcel.Name = "ShowInExcel";
            this.ShowInExcel.Size = new System.Drawing.Size(197, 47);
            this.ShowInExcel.TabIndex = 2;
            this.ShowInExcel.Text = "Hiển thị thông tin";
            this.ShowInExcel.UseVisualStyleBackColor = true;
            this.ShowInExcel.Click += new System.EventHandler(this.ShowInExcel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(217, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(571, 427);
            this.dataGridView1.TabIndex = 3;
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ShowInExcel);
            this.Controls.Add(this.SaveInExcel);
            this.Controls.Add(this.InputButton);
            this.Name = "Bai4";
            this.Text = "Làm việc với file CSDL";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.Button SaveInExcel;
        private System.Windows.Forms.Button ShowInExcel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}