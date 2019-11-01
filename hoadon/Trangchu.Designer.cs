namespace hoadon
{
    partial class Trangchu
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
            this.btnnhanvien = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.banhang = new System.Windows.Forms.Button();
            this.gianhang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnnhanvien
            // 
            this.btnnhanvien.Location = new System.Drawing.Point(135, 99);
            this.btnnhanvien.Name = "btnnhanvien";
            this.btnnhanvien.Size = new System.Drawing.Size(126, 35);
            this.btnnhanvien.TabIndex = 0;
            this.btnnhanvien.Text = "Quản lý nhân viên";
            this.btnnhanvien.UseVisualStyleBackColor = true;
            this.btnnhanvien.Click += new System.EventHandler(this.btnnhanvien_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(341, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Quản lý mặt hàng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // banhang
            // 
            this.banhang.Location = new System.Drawing.Point(341, 240);
            this.banhang.Name = "banhang";
            this.banhang.Size = new System.Drawing.Size(100, 30);
            this.banhang.TabIndex = 2;
            this.banhang.Text = "Bán hàng";
            this.banhang.UseVisualStyleBackColor = true;
            this.banhang.Click += new System.EventHandler(this.button3_Click);
            // 
            // gianhang
            // 
            this.gianhang.Location = new System.Drawing.Point(518, 99);
            this.gianhang.Name = "gianhang";
            this.gianhang.Size = new System.Drawing.Size(109, 35);
            this.gianhang.TabIndex = 3;
            this.gianhang.Text = "Quản lý gian hàng";
            this.gianhang.UseVisualStyleBackColor = true;
            this.gianhang.Click += new System.EventHandler(this.gianhang_Click);
            // 
            // Trangchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gianhang);
            this.Controls.Add(this.banhang);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnnhanvien);
            this.Name = "Trangchu";
            this.Text = "Trangchu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnnhanvien;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button banhang;
        private System.Windows.Forms.Button gianhang;
    }
}