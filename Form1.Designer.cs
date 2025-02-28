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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDT = new System.Windows.Forms.CheckBox();
            this.cbCv = new System.Windows.Forms.CheckBox();
            this.lblketqua = new System.Windows.Forms.Label();
            this.btnketqua = new System.Windows.Forms.Button();
            this.btnketqua2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbDt = new System.Windows.Forms.RadioButton();
            this.rdbCv = new System.Windows.Forms.RadioButton();
            this.lblkq2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.txtChieudai.Margin = new System.Windows.Forms.Padding(5);
            this.txtChieudai.Name = "txtChieudai";
            this.txtChieudai.Size = new System.Drawing.Size(164, 26);
            this.txtChieudai.TabIndex = 1;
            // 
            // txtChieurong
            // 
            this.txtChieurong.Location = new System.Drawing.Point(94, 149);
            this.txtChieurong.Margin = new System.Windows.Forms.Padding(5);
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
            this.txtDuongkinh.Location = new System.Drawing.Point(335, 96);
            this.txtDuongkinh.Name = "txtDuongkinh";
            this.txtDuongkinh.Size = new System.Drawing.Size(165, 26);
            this.txtDuongkinh.TabIndex = 3;
            // 
            // txtBankinh
            // 
            this.txtBankinh.Location = new System.Drawing.Point(335, 149);
            this.txtBankinh.Name = "txtBankinh";
            this.txtBankinh.Size = new System.Drawing.Size(165, 26);
            this.txtBankinh.TabIndex = 3;
            this.txtBankinh.TextChanged += new System.EventHandler(this.txtBankinh_TextChanged);
            // 
            // lblCv
            // 
            this.lblCv.AutoSize = true;
            this.lblCv.Location = new System.Drawing.Point(331, 210);
            this.lblCv.Name = "lblCv";
            this.lblCv.Size = new System.Drawing.Size(109, 20);
            this.lblCv.TabIndex = 4;
            this.lblCv.Text = "CV hinh tron";
            this.lblCv.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDt
            // 
            this.lblDt.AutoSize = true;
            this.lblDt.Location = new System.Drawing.Point(332, 270);
            this.lblDt.Name = "lblDt";
            this.lblDt.Size = new System.Drawing.Size(108, 20);
            this.lblDt.TabIndex = 4;
            this.lblDt.Text = "DT hinh tron";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(324, 320);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(176, 54);
            this.btnTinh.TabIndex = 5;
            this.btnTinh.Text = "nhấp vào em đi";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCv);
            this.groupBox1.Controls.Add(this.cbDT);
            this.groupBox1.Location = new System.Drawing.Point(572, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 145);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cbDT
            // 
            this.cbDT.AutoSize = true;
            this.cbDT.Location = new System.Drawing.Point(7, 37);
            this.cbDT.Name = "cbDT";
            this.cbDT.Size = new System.Drawing.Size(99, 24);
            this.cbDT.TabIndex = 0;
            this.cbDT.Text = "Diện tích";
            this.cbDT.UseVisualStyleBackColor = true;
            // 
            // cbCv
            // 
            this.cbCv.AutoSize = true;
            this.cbCv.Location = new System.Drawing.Point(7, 88);
            this.cbCv.Name = "cbCv";
            this.cbCv.Size = new System.Drawing.Size(77, 24);
            this.cbCv.TabIndex = 1;
            this.cbCv.Text = "Chu vi";
            this.cbCv.UseVisualStyleBackColor = true;
            // 
            // lblketqua
            // 
            this.lblketqua.AutoSize = true;
            this.lblketqua.Location = new System.Drawing.Point(572, 250);
            this.lblketqua.Name = "lblketqua";
            this.lblketqua.Size = new System.Drawing.Size(71, 20);
            this.lblketqua.TabIndex = 7;
            this.lblketqua.Text = "Kết quả";
            this.lblketqua.UseMnemonic = false;
            this.lblketqua.Click += new System.EventHandler(this.lblketqua_Click_1);
            // 
            // btnketqua
            // 
            this.btnketqua.Location = new System.Drawing.Point(572, 320);
            this.btnketqua.Name = "btnketqua";
            this.btnketqua.Size = new System.Drawing.Size(168, 54);
            this.btnketqua.TabIndex = 8;
            this.btnketqua.Text = "mời bạn nhấp ";
            this.btnketqua.UseVisualStyleBackColor = true;
            this.btnketqua.Click += new System.EventHandler(this.btnketqua_Click);
            // 
            // btnketqua2
            // 
            this.btnketqua2.Location = new System.Drawing.Point(572, 380);
            this.btnketqua2.Name = "btnketqua2";
            this.btnketqua2.Size = new System.Drawing.Size(174, 58);
            this.btnketqua2.TabIndex = 9;
            this.btnketqua2.Text = "nhấp em đi đừng nhấp thằng trên";
            this.btnketqua2.UseVisualStyleBackColor = true;
            this.btnketqua2.Click += new System.EventHandler(this.btnketqua2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbCv);
            this.groupBox2.Controls.Add(this.rdbDt);
            this.groupBox2.Location = new System.Drawing.Point(843, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 145);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // rdbDt
            // 
            this.rdbDt.AutoSize = true;
            this.rdbDt.Location = new System.Drawing.Point(7, 26);
            this.rdbDt.Name = "rdbDt";
            this.rdbDt.Size = new System.Drawing.Size(97, 25);
            this.rdbDt.TabIndex = 0;
            this.rdbDt.TabStop = true;
            this.rdbDt.Text = "Diện TÍch";
            this.rdbDt.UseCompatibleTextRendering = true;
            this.rdbDt.UseVisualStyleBackColor = true;
            // 
            // rdbCv
            // 
            this.rdbCv.AutoSize = true;
            this.rdbCv.Location = new System.Drawing.Point(7, 77);
            this.rdbCv.Name = "rdbCv";
            this.rdbCv.Size = new System.Drawing.Size(80, 24);
            this.rdbCv.TabIndex = 1;
            this.rdbCv.TabStop = true;
            this.rdbCv.Text = "Chu Vi";
            this.rdbCv.UseVisualStyleBackColor = true;
            // 
            // lblkq2
            // 
            this.lblkq2.AutoSize = true;
            this.lblkq2.Location = new System.Drawing.Point(846, 259);
            this.lblkq2.Name = "lblkq2";
            this.lblkq2.Size = new System.Drawing.Size(107, 20);
            this.lblkq2.TabIndex = 11;
            this.lblkq2.Text = "Kết quả gr2 ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(850, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 54);
            this.button1.TabIndex = 12;
            this.button1.Text = "bấm vào để ra kết quả";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblkq2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnketqua2);
            this.Controls.Add(this.btnketqua);
            this.Controls.Add(this.lblketqua);
            this.Controls.Add(this.groupBox1);
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
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbCv;
        private System.Windows.Forms.CheckBox cbDT;
        private System.Windows.Forms.Label lblketqua;
        private System.Windows.Forms.Button btnketqua;
        private System.Windows.Forms.Button btnketqua2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbCv;
        private System.Windows.Forms.RadioButton rdbDt;
        private System.Windows.Forms.Label lblkq2;
        private System.Windows.Forms.Button button1;
    }
}

