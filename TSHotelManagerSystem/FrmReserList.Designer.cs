﻿namespace TSHotelManagerSystem
{
    partial class FrmReserList
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
<<<<<<< HEAD
=======
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
>>>>>>> 40311c0... 更新源码2020-04-19
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReserList));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clReserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCustoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCustoTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clReserWay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clReserRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clReserDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clReserEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clReserRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboPassport = new System.Windows.Forms.ComboBox();
            this.cboCustoType = new System.Windows.Forms.ComboBox();
            this.txtCustoAdress = new System.Windows.Forms.TextBox();
            this.txtCardID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtCustoName = new System.Windows.Forms.TextBox();
            this.txtCustoNo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.gbCustoInfo = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clReserId,
            this.clCustoName,
            this.clCustoTel,
            this.clReserWay,
            this.clReserRoom,
            this.clReserDate,
            this.clReserEndDate,
            this.clReserRemark});
            this.dataGridView1.Location = new System.Drawing.Point(2, 81);
            this.dataGridView1.Name = "dataGridView1";
<<<<<<< HEAD
=======
            dataGridViewCellStyle1.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
>>>>>>> 40311c0... 更新源码2020-04-19
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(707, 156);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // clReserId
            // 
            this.clReserId.DataPropertyName = "ReserId";
            this.clReserId.HeaderText = "预约编号";
            this.clReserId.Name = "clReserId";
            // 
            // clCustoName
            // 
            this.clCustoName.DataPropertyName = "CustoName";
            this.clCustoName.HeaderText = "客户姓名";
            this.clCustoName.Name = "clCustoName";
            // 
            // clCustoTel
            // 
            this.clCustoTel.DataPropertyName = "CustoTel";
            this.clCustoTel.HeaderText = "预留电话";
            this.clCustoTel.Name = "clCustoTel";
            // 
            // clReserWay
            // 
            this.clReserWay.DataPropertyName = "ReserWay";
            this.clReserWay.HeaderText = "预约方式";
            this.clReserWay.Name = "clReserWay";
            // 
            // clReserRoom
            // 
            this.clReserRoom.DataPropertyName = "ReserRoom";
            this.clReserRoom.HeaderText = "预约房号";
            this.clReserRoom.Name = "clReserRoom";
            // 
            // clReserDate
            // 
            this.clReserDate.DataPropertyName = "ReserDate";
            this.clReserDate.HeaderText = "开始时间";
            this.clReserDate.Name = "clReserDate";
            // 
            // clReserEndDate
            // 
            this.clReserEndDate.DataPropertyName = "ReserEndDay";
            this.clReserEndDate.HeaderText = "截止时间";
            this.clReserEndDate.Name = "clReserEndDate";
            // 
            // clReserRemark
            // 
            this.clReserRemark.DataPropertyName = "ReserRemark";
            this.clReserRemark.HeaderText = "预约备注";
            this.clReserRemark.Name = "clReserRemark";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
<<<<<<< HEAD
            this.label1.BackColor = System.Drawing.SystemColors.Control;
=======
            this.label1.BackColor = System.Drawing.Color.Transparent;
>>>>>>> 40311c0... 更新源码2020-04-19
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("苹方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "预  约  列  表";
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnSelect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelect.BackgroundImage")));
            this.btnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
<<<<<<< HEAD
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
=======
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
>>>>>>> 40311c0... 更新源码2020-04-19
            this.btnSelect.Font = new System.Drawing.Font("苹方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelect.Location = new System.Drawing.Point(13, 31);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(176, 44);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "将选中项注册为客户";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("苹方-简", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(666, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 39);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboPassport
            // 
            this.cboPassport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPassport.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboPassport.FormattingEnabled = true;
            this.cboPassport.Items.AddRange(new object[] {
            "中国居民身份证",
            "港澳通行证",
            "台胞证",
            "军官证",
            "外国护照"});
            this.cboPassport.Location = new System.Drawing.Point(288, 326);
            this.cboPassport.Name = "cboPassport";
            this.cboPassport.Size = new System.Drawing.Size(125, 24);
            this.cboPassport.TabIndex = 111;
            // 
            // cboCustoType
            // 
            this.cboCustoType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustoType.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboCustoType.FormattingEnabled = true;
            this.cboCustoType.Items.AddRange(new object[] {
            "普通用户",
            "钻石会员",
            "白金会员",
            "黄金会员"});
            this.cboCustoType.Location = new System.Drawing.Point(288, 295);
            this.cboCustoType.Name = "cboCustoType";
            this.cboCustoType.Size = new System.Drawing.Size(125, 24);
            this.cboCustoType.TabIndex = 108;
            // 
            // txtCustoAdress
            // 
            this.txtCustoAdress.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustoAdress.Location = new System.Drawing.Point(478, 293);
            this.txtCustoAdress.Name = "txtCustoAdress";
            this.txtCustoAdress.Size = new System.Drawing.Size(191, 26);
            this.txtCustoAdress.TabIndex = 109;
            // 
            // txtCardID
            // 
            this.txtCardID.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCardID.Location = new System.Drawing.Point(478, 262);
            this.txtCardID.MaxLength = 18;
            this.txtCardID.Name = "txtCardID";
            this.txtCardID.Size = new System.Drawing.Size(191, 26);
            this.txtCardID.TabIndex = 106;
            this.txtCardID.Validated += new System.EventHandler(this.txtCardID_Validated);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
<<<<<<< HEAD
            this.label12.Location = new System.Drawing.Point(419, 268);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
=======
            this.label12.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(418, 267);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 17);
>>>>>>> 40311c0... 更新源码2020-04-19
            this.label12.TabIndex = 98;
            this.label12.Text = "证件号码";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
<<<<<<< HEAD
            this.label6.Location = new System.Drawing.Point(229, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
=======
            this.label6.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(228, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
>>>>>>> 40311c0... 更新源码2020-04-19
            this.label6.TabIndex = 110;
            this.label6.Text = "证件类型";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
<<<<<<< HEAD
            this.label13.Location = new System.Drawing.Point(421, 300);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
=======
            this.label13.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(420, 299);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 17);
>>>>>>> 40311c0... 更新源码2020-04-19
            this.label13.TabIndex = 99;
            this.label13.Text = "客户地址";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.CalendarFont = new System.Drawing.Font("华文中宋", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpBirthday.CustomFormat = "yyyy-MM-dd";
            this.dtpBirthday.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthday.Location = new System.Drawing.Point(288, 262);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(125, 26);
            this.dtpBirthday.TabIndex = 107;
            // 
            // txtCustoName
            // 
            this.txtCustoName.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustoName.Location = new System.Drawing.Point(98, 292);
            this.txtCustoName.Name = "txtCustoName";
            this.txtCustoName.Size = new System.Drawing.Size(125, 26);
            this.txtCustoName.TabIndex = 103;
            // 
            // txtCustoNo
            // 
            this.txtCustoNo.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustoNo.Location = new System.Drawing.Point(98, 260);
            this.txtCustoNo.Name = "txtCustoNo";
            this.txtCustoNo.ReadOnly = true;
            this.txtCustoNo.Size = new System.Drawing.Size(125, 26);
            this.txtCustoNo.TabIndex = 102;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
<<<<<<< HEAD
            this.label15.Location = new System.Drawing.Point(229, 300);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
=======
            this.label15.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(228, 299);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 17);
>>>>>>> 40311c0... 更新源码2020-04-19
            this.label15.TabIndex = 101;
            this.label15.Text = "客户类型";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
<<<<<<< HEAD
            this.label9.Location = new System.Drawing.Point(41, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
=======
            this.label9.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(40, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
>>>>>>> 40311c0... 更新源码2020-04-19
            this.label9.TabIndex = 95;
            this.label9.Text = "客户姓名";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
<<<<<<< HEAD
            this.label10.Location = new System.Drawing.Point(41, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
=======
            this.label10.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(40, 330);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
>>>>>>> 40311c0... 更新源码2020-04-19
            this.label10.TabIndex = 96;
            this.label10.Text = "性    别";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
<<<<<<< HEAD
            this.label14.Location = new System.Drawing.Point(229, 268);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
=======
            this.label14.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(228, 267);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 17);
>>>>>>> 40311c0... 更新源码2020-04-19
            this.label14.TabIndex = 100;
            this.label14.Text = "出生日期";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
<<<<<<< HEAD
            this.label11.Location = new System.Drawing.Point(421, 332);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
=======
            this.label11.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(420, 331);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
>>>>>>> 40311c0... 更新源码2020-04-19
            this.label11.TabIndex = 97;
            this.label11.Text = "客户电话";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
<<<<<<< HEAD
            this.label3.Location = new System.Drawing.Point(41, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
=======
            this.label3.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(40, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
>>>>>>> 40311c0... 更新源码2020-04-19
            this.label3.TabIndex = 94;
            this.label3.Text = "客户编号";
            // 
            // cboSex
            // 
            this.cboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSex.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cboSex.Location = new System.Drawing.Point(98, 324);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(125, 24);
            this.cboSex.TabIndex = 104;
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTel.Location = new System.Drawing.Point(478, 324);
            this.txtTel.MaxLength = 11;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(191, 26);
            this.txtTel.TabIndex = 105;
            // 
            // gbCustoInfo
            // 
            this.gbCustoInfo.BackColor = System.Drawing.Color.Transparent;
<<<<<<< HEAD
=======
            this.gbCustoInfo.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
>>>>>>> 40311c0... 更新源码2020-04-19
            this.gbCustoInfo.Location = new System.Drawing.Point(16, 243);
            this.gbCustoInfo.Name = "gbCustoInfo";
            this.gbCustoInfo.Size = new System.Drawing.Size(678, 122);
            this.gbCustoInfo.TabIndex = 112;
            this.gbCustoInfo.TabStop = false;
            this.gbCustoInfo.Text = "客户信息";
            // 
            // FrmReserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
=======
            this.BackgroundImage = global::TSHotelManagerSystem.Properties.Resources.main_bg;
>>>>>>> 40311c0... 更新源码2020-04-19
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(711, 371);
            this.Controls.Add(this.cboPassport);
            this.Controls.Add(this.cboCustoType);
            this.Controls.Add(this.txtCustoAdress);
            this.Controls.Add(this.txtCardID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.txtCustoName);
            this.Controls.Add(this.txtCustoNo);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboSex);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbCustoInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReserList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "预约列表";
            this.Load += new System.EventHandler(this.FrmReserList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn clReserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustoTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clReserWay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clReserRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clReserDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clReserEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clReserRemark;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cboPassport;
        private System.Windows.Forms.ComboBox cboCustoType;
        private System.Windows.Forms.TextBox txtCustoAdress;
        private System.Windows.Forms.TextBox txtCardID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.TextBox txtCustoName;
        private System.Windows.Forms.TextBox txtCustoNo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.GroupBox gbCustoInfo;
    }
}