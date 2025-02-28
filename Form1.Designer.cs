namespace Chuvihinhchunhat
{
    partial class Form1
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
            this.lblChuvi = new System.Windows.Forms.Label();
            this.lblDientich = new System.Windows.Forms.Label();
            this.txtChieudai = new System.Windows.Forms.TextBox();
            this.txtChieurong = new System.Windows.Forms.TextBox();
            this.btnBang = new System.Windows.Forms.Button();
            this.txtDuongkinh = new System.Windows.Forms.TextBox();
            this.txtBankinh = new System.Windows.Forms.TextBox();
            this.lblCv = new System.Windows.Forms.Label();
            this.lblDt = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChuvi
            // 
            this.lblChuvi.AutoSize = true;
            this.lblChuvi.Location = new System.Drawing.Point(90, 221);
            this.lblChuvi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblChuvi.Name = "lblChuvi";
            this.lblChuvi.Size = new System.Drawing.Size(58, 20);
            this.lblChuvi.TabIndex = 0;
            this.lblChuvi.Text = "Chu vi";
            // 
            // lblDientich
            // 
            this.lblDientich.AutoSize = true;
            this.lblDientich.Location = new System.Drawing.Point(90, 270);
            this.lblDientich.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDientich.Name = "lblDientich";
            this.lblDientich.Size = new System.Drawing.Size(86, 20);
            this.lblDientich.TabIndex = 0;
            this.lblDientich.Text = "Dien TIch";
            // 
            // txtChieudai
            // 
            this.txtChieudai.Location = new System.Drawing.Point(94, 96);
            this.txtChieudai.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtChieudai.Name = "txtChieudai";
            this.txtChieudai.Size = new System.Drawing.Size(164, 26);
            this.txtChieudai.TabIndex = 1;
            // 
            // txtChieurong
            // 
            this.txtChieurong.Location = new System.Drawing.Point(94, 149);
            this.txtChieurong.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtChieurong.Name = "txtChieurong";
            this.txtChieurong.Size = new System.Drawing.Size(164, 26);
            this.txtChieurong.TabIndex = 1;
            // 
            // btnBang
            // 
            this.btnBang.Location = new System.Drawing.Point(91, 336);
            this.btnBang.Name = "btnBang";
            this.btnBang.Size = new System.Drawing.Size(75, 23);
            this.btnBang.TabIndex = 2;
            this.btnBang.Text = "=";
            this.btnBang.UseVisualStyleBackColor = true;
            this.btnBang.Click += new System.EventHandler(this.btnBang_Click_1);
            // 
            // txtDuongkinh
            // 
            this.txtDuongkinh.Location = new System.Drawing.Point(529, 96);
            this.txtDuongkinh.Name = "txtDuongkinh";
            this.txtDuongkinh.Size = new System.Drawing.Size(165, 26);
            this.txtDuongkinh.TabIndex = 3;
            // 
            // txtBankinh
            // 
            this.txtBankinh.Location = new System.Drawing.Point(529, 149);
            this.txtBankinh.Name = "txtBankinh";
            this.txtBankinh.Size = new System.Drawing.Size(165, 26);
            this.txtBankinh.TabIndex = 3;
            // 
            // lblCv
            // 
            this.lblCv.AutoSize = true;
            this.lblCv.Location = new System.Drawing.Point(525, 221);
            this.lblCv.Name = "lblCv";
            this.lblCv.Size = new System.Drawing.Size(109, 20);
            this.lblCv.TabIndex = 4;
            this.lblCv.Text = "CV hinh tron";
            this.lblCv.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDt
            // 
            this.lblDt.AutoSize = true;
            this.lblDt.Location = new System.Drawing.Point(525, 270);
            this.lblDt.Name = "lblDt";
            this.lblDt.Size = new System.Drawing.Size(108, 20);
            this.lblDt.TabIndex = 4;
            this.lblDt.Text = "DT hinh tron";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(529, 336);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(176, 54);
            this.btnTinh.TabIndex = 5;
            this.btnTinh.Text = "nhấp vào em đi";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 692);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.lblDt);
            this.Controls.Add(this.lblCv);
            this.Controls.Add(this.txtBankinh);
            this.Controls.Add(this.txtDuongkinh);
            this.Controls.Add(this.btnBang);
            this.Controls.Add(this.txtChieurong);
            this.Controls.Add(this.txtChieudai);
            this.Controls.Add(this.lblDientich);
            this.Controls.Add(this.lblChuvi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChuvi;
        private System.Windows.Forms.Label lblDientich;
        private System.Windows.Forms.TextBox txtChieudai;
        private System.Windows.Forms.TextBox txtChieurong;
        private System.Windows.Forms.Button btnBang;
        private System.Windows.Forms.TextBox txtDuongkinh;
        private System.Windows.Forms.TextBox txtBankinh;
        private System.Windows.Forms.Label lblCv;
        private System.Windows.Forms.Label lblDt;
        private System.Windows.Forms.Button btnTinh;
    }
}

