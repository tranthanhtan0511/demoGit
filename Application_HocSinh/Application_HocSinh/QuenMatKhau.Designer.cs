namespace Application_HocSinh
{
    partial class QuenMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuenMatKhau));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_EmailDDK = new System.Windows.Forms.TextBox();
            this.label_KQ = new System.Windows.Forms.Label();
            this.button_LLMK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Application_HocSinh.Properties.Resources._896aa6_a6819e0d0aa34a8b9913ab70d905fda5_mv2;
            this.pictureBox1.Location = new System.Drawing.Point(281, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Email đã đăng ký:";
            // 
            // textBox_EmailDDK
            // 
            this.textBox_EmailDDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EmailDDK.Location = new System.Drawing.Point(371, 246);
            this.textBox_EmailDDK.Multiline = true;
            this.textBox_EmailDDK.Name = "textBox_EmailDDK";
            this.textBox_EmailDDK.Size = new System.Drawing.Size(190, 35);
            this.textBox_EmailDDK.TabIndex = 24;
            // 
            // label_KQ
            // 
            this.label_KQ.AutoSize = true;
            this.label_KQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_KQ.Location = new System.Drawing.Point(197, 325);
            this.label_KQ.Name = "label_KQ";
            this.label_KQ.Size = new System.Drawing.Size(94, 25);
            this.label_KQ.TabIndex = 25;
            this.label_KQ.Text = "Kết quả:";
            // 
            // button_LLMK
            // 
            this.button_LLMK.AutoSize = true;
            this.button_LLMK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_LLMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LLMK.Location = new System.Drawing.Point(300, 385);
            this.button_LLMK.Name = "button_LLMK";
            this.button_LLMK.Size = new System.Drawing.Size(197, 39);
            this.button_LLMK.TabIndex = 27;
            this.button_LLMK.Text = "Lấy lại mật khẩu";
            this.button_LLMK.UseVisualStyleBackColor = true;
            this.button_LLMK.Click += new System.EventHandler(this.button_LLMK_Click);
            // 
            // QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 606);
            this.Controls.Add(this.button_LLMK);
            this.Controls.Add(this.label_KQ);
            this.Controls.Add(this.textBox_EmailDDK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuenMatKhau";
            this.Text = "QuenMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_EmailDDK;
        private System.Windows.Forms.Label label_KQ;
        private System.Windows.Forms.Button button_LLMK;
    }
}