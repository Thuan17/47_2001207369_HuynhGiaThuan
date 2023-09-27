namespace _2001207369_HuynhGiaThuan
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
            this.Kie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnKtra = new System.Windows.Forms.Button();
            this.btnSTT = new System.Windows.Forms.Button();
            this.btn_ex = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lKhoan = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lSoNhap = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Kie
            // 
            this.Kie.AutoSize = true;
            this.Kie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kie.Location = new System.Drawing.Point(190, 29);
            this.Kie.Name = "Kie";
            this.Kie.Size = new System.Drawing.Size(235, 24);
            this.Kie.TabIndex = 0;
            this.Kie.Text = "Kiểm Tra Số Nguyên Tố";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập số :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(251, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnKtra
            // 
            this.btnKtra.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnKtra.Location = new System.Drawing.Point(109, 150);
            this.btnKtra.Name = "btnKtra";
            this.btnKtra.Size = new System.Drawing.Size(75, 23);
            this.btnKtra.TabIndex = 3;
            this.btnKtra.Text = "Kiểm Tra";
            this.btnKtra.UseVisualStyleBackColor = true;
            this.btnKtra.Click += new System.EventHandler(this.btnKtra_Click);
            // 
            // btnSTT
            // 
            this.btnSTT.Location = new System.Drawing.Point(272, 150);
            this.btnSTT.Name = "btnSTT";
            this.btnSTT.Size = new System.Drawing.Size(75, 23);
            this.btnSTT.TabIndex = 3;
            this.btnSTT.Text = "In STT";
            this.btnSTT.UseVisualStyleBackColor = true;
            this.btnSTT.Click += new System.EventHandler(this.btnSTT_Click);
            // 
            // btn_ex
            // 
            this.btn_ex.Location = new System.Drawing.Point(415, 150);
            this.btn_ex.Name = "btn_ex";
            this.btn_ex.Size = new System.Drawing.Size(75, 23);
            this.btn_ex.TabIndex = 3;
            this.btn_ex.Text = "Thoát";
            this.btn_ex.UseVisualStyleBackColor = true;
            this.btn_ex.Click += new System.EventHandler(this.btn_ex_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Là số nguyên tố";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Các số nguyên tố trong khoảng";
            // 
            // lKhoan
            // 
            this.lKhoan.AutoSize = true;
            this.lKhoan.Location = new System.Drawing.Point(466, 226);
            this.lKhoan.Name = "lKhoan";
            this.lKhoan.Size = new System.Drawing.Size(17, 13);
            this.lKhoan.TabIndex = 1;
            this.lKhoan.Text = "xx";
            this.lKhoan.Visible = false;
            this.lKhoan.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nhập số :";
            // 
            // lSoNhap
            // 
            this.lSoNhap.AutoSize = true;
            this.lSoNhap.Location = new System.Drawing.Point(83, 226);
            this.lSoNhap.Name = "lSoNhap";
            this.lSoNhap.Size = new System.Drawing.Size(17, 13);
            this.lSoNhap.TabIndex = 1;
            this.lSoNhap.Text = "xx";
            this.lSoNhap.Visible = false;
            this.lSoNhap.Click += new System.EventHandler(this.label4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nhập số :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 368);
            this.Controls.Add(this.btn_ex);
            this.Controls.Add(this.btnSTT);
            this.Controls.Add(this.btnKtra);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lSoNhap);
            this.Controls.Add(this.lKhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Kie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnKtra;
        private System.Windows.Forms.Button btnSTT;
        private System.Windows.Forms.Button btn_ex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lKhoan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lSoNhap;
        private System.Windows.Forms.Label label4;
    }
}

