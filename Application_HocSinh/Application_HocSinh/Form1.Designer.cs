namespace Application_HocSinh
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
            this.lbMSSV = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextMSSV = new System.Windows.Forms.TextBox();
            this.TextHoTen = new System.Windows.Forms.TextBox();
            this.TextDiaChi = new System.Windows.Forms.TextBox();
            this.DateTimeNS = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button_Them = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.columnMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_DangXuat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMSSV
            // 
            this.lbMSSV.AutoSize = true;
            this.lbMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMSSV.Location = new System.Drawing.Point(14, 18);
            this.lbMSSV.Name = "lbMSSV";
            this.lbMSSV.Size = new System.Drawing.Size(66, 25);
            this.lbMSSV.TabIndex = 0;
            this.lbMSSV.Text = "Mã số";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.Location = new System.Drawing.Point(14, 56);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(77, 25);
            this.lbHoTen.TabIndex = 1;
            this.lbHoTen.Text = "Họ Tên";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaySinh.Location = new System.Drawing.Point(14, 95);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(103, 25);
            this.lbNgaySinh.TabIndex = 2;
            this.lbNgaySinh.Text = "Ngày Sinh";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.Location = new System.Drawing.Point(14, 130);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(71, 25);
            this.lbDiaChi.TabIndex = 3;
            this.lbDiaChi.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giới tính:";
            // 
            // TextMSSV
            // 
            this.TextMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMSSV.Location = new System.Drawing.Point(129, 18);
            this.TextMSSV.Name = "TextMSSV";
            this.TextMSSV.Size = new System.Drawing.Size(215, 30);
            this.TextMSSV.TabIndex = 5;
            // 
            // TextHoTen
            // 
            this.TextHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextHoTen.Location = new System.Drawing.Point(129, 56);
            this.TextHoTen.Name = "TextHoTen";
            this.TextHoTen.Size = new System.Drawing.Size(215, 30);
            this.TextHoTen.TabIndex = 6;
            // 
            // TextDiaChi
            // 
            this.TextDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDiaChi.Location = new System.Drawing.Point(129, 133);
            this.TextDiaChi.Name = "TextDiaChi";
            this.TextDiaChi.Size = new System.Drawing.Size(215, 30);
            this.TextDiaChi.TabIndex = 7;
            // 
            // DateTimeNS
            // 
            this.DateTimeNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeNS.Location = new System.Drawing.Point(129, 98);
            this.DateTimeNS.Name = "DateTimeNS";
            this.DateTimeNS.Size = new System.Drawing.Size(215, 30);
            this.DateTimeNS.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(379, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 146);
            this.panel1.TabIndex = 9;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(3, 75);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 29);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nữ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(3, 39);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(74, 29);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nam";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button_Them
            // 
            this.button_Them.AutoSize = true;
            this.button_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Them.Location = new System.Drawing.Point(40, 41);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(75, 30);
            this.button_Them.TabIndex = 10;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.AutoSize = true;
            this.button_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Xoa.Location = new System.Drawing.Point(40, 77);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(75, 30);
            this.button_Xoa.TabIndex = 11;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_Sua
            // 
            this.button_Sua.AutoSize = true;
            this.button_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sua.Location = new System.Drawing.Point(40, 115);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(75, 30);
            this.button_Sua.TabIndex = 12;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.UseVisualStyleBackColor = true;
            this.button_Sua.Click += new System.EventHandler(this.button_Sua_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.button_Sua);
            this.panel2.Controls.Add(this.button_Xoa);
            this.panel2.Controls.Add(this.button_Them);
            this.panel2.Location = new System.Drawing.Point(564, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 145);
            this.panel2.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Bảng lựa chọn";
            // 
            // dataView
            // 
            this.dataView.AllowUserToAddRows = false;
            this.dataView.AllowUserToDeleteRows = false;
            this.dataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnMSSV,
            this.ColumnHoTen,
            this.ColumnNgaySinh,
            this.ColumnPhai,
            this.ColumnDiaChi});
            this.dataView.Location = new System.Drawing.Point(1, 181);
            this.dataView.Name = "dataView";
            this.dataView.ReadOnly = true;
            this.dataView.RowHeadersWidth = 51;
            this.dataView.RowTemplate.Height = 24;
            this.dataView.Size = new System.Drawing.Size(1092, 505);
            this.dataView.TabIndex = 14;
            this.dataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellClick);
            // 
            // columnMSSV
            // 
            this.columnMSSV.DataPropertyName = "mshs";
            this.columnMSSV.HeaderText = "mssv";
            this.columnMSSV.MinimumWidth = 6;
            this.columnMSSV.Name = "columnMSSV";
            this.columnMSSV.ReadOnly = true;
            // 
            // ColumnHoTen
            // 
            this.ColumnHoTen.DataPropertyName = "hoten";
            this.ColumnHoTen.HeaderText = "HoTen";
            this.ColumnHoTen.MinimumWidth = 6;
            this.ColumnHoTen.Name = "ColumnHoTen";
            this.ColumnHoTen.ReadOnly = true;
            // 
            // ColumnNgaySinh
            // 
            this.ColumnNgaySinh.DataPropertyName = "ngaysinh";
            this.ColumnNgaySinh.HeaderText = "NgaySinh";
            this.ColumnNgaySinh.MinimumWidth = 6;
            this.ColumnNgaySinh.Name = "ColumnNgaySinh";
            this.ColumnNgaySinh.ReadOnly = true;
            // 
            // ColumnPhai
            // 
            this.ColumnPhai.DataPropertyName = "phai";
            this.ColumnPhai.HeaderText = "Phai";
            this.ColumnPhai.MinimumWidth = 6;
            this.ColumnPhai.Name = "ColumnPhai";
            this.ColumnPhai.ReadOnly = true;
            // 
            // ColumnDiaChi
            // 
            this.ColumnDiaChi.DataPropertyName = "diachi";
            this.ColumnDiaChi.HeaderText = "DiaChi";
            this.ColumnDiaChi.MinimumWidth = 6;
            this.ColumnDiaChi.Name = "ColumnDiaChi";
            this.ColumnDiaChi.ReadOnly = true;
            // 
            // button_DangXuat
            // 
            this.button_DangXuat.AutoSize = true;
            this.button_DangXuat.BackColor = System.Drawing.Color.Blue;
            this.button_DangXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_DangXuat.CausesValidation = false;
            this.button_DangXuat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_DangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DangXuat.ForeColor = System.Drawing.Color.White;
            this.button_DangXuat.Location = new System.Drawing.Point(960, 10);
            this.button_DangXuat.Name = "button_DangXuat";
            this.button_DangXuat.Size = new System.Drawing.Size(133, 38);
            this.button_DangXuat.TabIndex = 15;
            this.button_DangXuat.Text = "Đăng xuất";
            this.button_DangXuat.UseVisualStyleBackColor = false;
            this.button_DangXuat.Click += new System.EventHandler(this.button_DangXuat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 685);
            this.Controls.Add(this.button_DangXuat);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DateTimeNS);
            this.Controls.Add(this.TextDiaChi);
            this.Controls.Add(this.TextHoTen);
            this.Controls.Add(this.TextMSSV);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.lbNgaySinh);
            this.Controls.Add(this.lbHoTen);
            this.Controls.Add(this.lbMSSV);
            this.Name = "Form1";
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMSSV;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextMSSV;
        private System.Windows.Forms.TextBox TextHoTen;
        private System.Windows.Forms.TextBox TextDiaChi;
        private System.Windows.Forms.DateTimePicker DateTimeNS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Button button_DangXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiaChi;
    }
}

