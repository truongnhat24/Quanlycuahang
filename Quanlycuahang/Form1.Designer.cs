namespace Quanlycuahang
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFind = new System.Windows.Forms.Button();
            this.txtCategorySearch = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtCategory = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.dateTimePickerHSD = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerNSX = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIDSearch = new System.Windows.Forms.TextBox();
            this.radHSD = new System.Windows.Forms.RadioButton();
            this.radNSX = new System.Windows.Forms.RadioButton();
            this.radCompany = new System.Windows.Forms.RadioButton();
            this.radCategory = new System.Windows.Forms.RadioButton();
            this.radName = new System.Windows.Forms.RadioButton();
            this.dateTimePickerNSXSearch = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHSDSearch = new System.Windows.Forms.DateTimePicker();
            this.radID = new System.Windows.Forms.RadioButton();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.txtCompanySearch = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCateUpdate = new System.Windows.Forms.Button();
            this.btnCateFind = new System.Windows.Forms.Button();
            this.btnCateDelete = new System.Windows.Forms.Button();
            this.btnCateAdd = new System.Windows.Forms.Button();
            this.dataGridViewCategory = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputCategory = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(569, 260);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(94, 29);
            this.btnFind.TabIndex = 16;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtCategorySearch
            // 
            this.txtCategorySearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCategorySearch.FormattingEnabled = true;
            this.txtCategorySearch.Items.AddRange(new object[] {
            "Nuoc ngot",
            "Banh",
            "Keo",
            "Bia"});
            this.txtCategorySearch.Location = new System.Drawing.Point(214, 173);
            this.txtCategorySearch.Name = "txtCategorySearch";
            this.txtCategorySearch.Size = new System.Drawing.Size(151, 28);
            this.txtCategorySearch.TabIndex = 17;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column6});
            this.dataGridView.Location = new System.Drawing.Point(77, 314);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(1109, 261);
            this.dataGridView.TabIndex = 19;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 175;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 175;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Loại hàng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 175;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Công ty sản xuất";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 175;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Năm sản xuất";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 175;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Hạn sử dụng";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 175;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(8, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1263, 641);
            this.tabControl1.TabIndex = 20;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtCategory);
            this.tabPage1.Controls.Add(this.dataGridView);
            this.tabPage1.Controls.Add(this.txtId);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.txtCompany);
            this.tabPage1.Controls.Add(this.dateTimePickerHSD);
            this.tabPage1.Controls.Add(this.dateTimePickerNSX);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1255, 608);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý sản phẩm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtCategory
            // 
            this.txtCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCategory.FormattingEnabled = true;
            this.txtCategory.Items.AddRange(new object[] {
            "Nuoc ngot",
            "Banh",
            "Keo",
            "Bia"});
            this.txtCategory.Location = new System.Drawing.Point(256, 189);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(203, 28);
            this.txtCategory.TabIndex = 16;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(257, 40);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(202, 27);
            this.txtId.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tên hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Loại hàng";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(257, 112);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(202, 27);
            this.txtName.TabIndex = 6;
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(888, 44);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(222, 27);
            this.txtCompany.TabIndex = 7;
            // 
            // dateTimePickerHSD
            // 
            this.dateTimePickerHSD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerHSD.Location = new System.Drawing.Point(888, 181);
            this.dateTimePickerHSD.Name = "dateTimePickerHSD";
            this.dateTimePickerHSD.Size = new System.Drawing.Size(222, 27);
            this.dateTimePickerHSD.TabIndex = 15;
            // 
            // dateTimePickerNSX
            // 
            this.dateTimePickerNSX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNSX.Location = new System.Drawing.Point(888, 112);
            this.dateTimePickerNSX.Name = "dateTimePickerNSX";
            this.dateTimePickerNSX.Size = new System.Drawing.Size(222, 27);
            this.dateTimePickerNSX.TabIndex = 14;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(383, 256);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(752, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hạn sử dụng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(746, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Năm sản xuất";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(728, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Công ty sản xuất";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(551, 256);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(728, 256);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewSearch);
            this.tabPage2.Controls.Add(this.txtIDSearch);
            this.tabPage2.Controls.Add(this.radHSD);
            this.tabPage2.Controls.Add(this.radNSX);
            this.tabPage2.Controls.Add(this.radCompany);
            this.tabPage2.Controls.Add(this.radCategory);
            this.tabPage2.Controls.Add(this.radName);
            this.tabPage2.Controls.Add(this.dateTimePickerNSXSearch);
            this.tabPage2.Controls.Add(this.dateTimePickerHSDSearch);
            this.tabPage2.Controls.Add(this.radID);
            this.tabPage2.Controls.Add(this.txtNameSearch);
            this.tabPage2.Controls.Add(this.txtCompanySearch);
            this.tabPage2.Controls.Add(this.btnFind);
            this.tabPage2.Controls.Add(this.txtCategorySearch);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(1255, 608);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tìm kiếm sản phẩm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridViewSearch.Location = new System.Drawing.Point(82, 324);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.RowHeadersWidth = 51;
            this.dataGridViewSearch.RowTemplate.Height = 29;
            this.dataGridViewSearch.Size = new System.Drawing.Size(1103, 261);
            this.dataGridViewSearch.TabIndex = 38;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 175;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên hàng";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 175;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Loại hàng";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 175;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Công ty sản xuất";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 175;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Năm sản xuất";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 175;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Hạn sử dụng";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 175;
            // 
            // txtIDSearch
            // 
            this.txtIDSearch.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtIDSearch.Location = new System.Drawing.Point(214, 35);
            this.txtIDSearch.Name = "txtIDSearch";
            this.txtIDSearch.Size = new System.Drawing.Size(151, 27);
            this.txtIDSearch.TabIndex = 37;
            // 
            // radHSD
            // 
            this.radHSD.AutoSize = true;
            this.radHSD.Location = new System.Drawing.Point(729, 176);
            this.radHSD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radHSD.Name = "radHSD";
            this.radHSD.Size = new System.Drawing.Size(114, 24);
            this.radHSD.TabIndex = 36;
            this.radHSD.TabStop = true;
            this.radHSD.Text = "Hạn sử dụng";
            this.radHSD.UseVisualStyleBackColor = true;
            // 
            // radNSX
            // 
            this.radNSX.AutoSize = true;
            this.radNSX.Location = new System.Drawing.Point(729, 107);
            this.radNSX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radNSX.Name = "radNSX";
            this.radNSX.Size = new System.Drawing.Size(123, 24);
            this.radNSX.TabIndex = 35;
            this.radNSX.TabStop = true;
            this.radNSX.Text = "Ngày sản xuất";
            this.radNSX.UseVisualStyleBackColor = true;
            // 
            // radCompany
            // 
            this.radCompany.AutoSize = true;
            this.radCompany.Location = new System.Drawing.Point(729, 37);
            this.radCompany.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radCompany.Name = "radCompany";
            this.radCompany.Size = new System.Drawing.Size(139, 24);
            this.radCompany.TabIndex = 34;
            this.radCompany.TabStop = true;
            this.radCompany.Text = "Công ty sản xuất";
            this.radCompany.UseVisualStyleBackColor = true;
            // 
            // radCategory
            // 
            this.radCategory.AutoSize = true;
            this.radCategory.Location = new System.Drawing.Point(50, 173);
            this.radCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radCategory.Name = "radCategory";
            this.radCategory.Size = new System.Drawing.Size(95, 24);
            this.radCategory.TabIndex = 33;
            this.radCategory.TabStop = true;
            this.radCategory.Text = "Loại hàng";
            this.radCategory.UseVisualStyleBackColor = true;
            // 
            // radName
            // 
            this.radName.AutoSize = true;
            this.radName.Location = new System.Drawing.Point(50, 104);
            this.radName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radName.Name = "radName";
            this.radName.Size = new System.Drawing.Size(90, 24);
            this.radName.TabIndex = 32;
            this.radName.TabStop = true;
            this.radName.Text = "Tên hàng";
            this.radName.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerNSXSearch
            // 
            this.dateTimePickerNSXSearch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNSXSearch.Location = new System.Drawing.Point(907, 104);
            this.dateTimePickerNSXSearch.Name = "dateTimePickerNSXSearch";
            this.dateTimePickerNSXSearch.Size = new System.Drawing.Size(151, 27);
            this.dateTimePickerNSXSearch.TabIndex = 31;
            // 
            // dateTimePickerHSDSearch
            // 
            this.dateTimePickerHSDSearch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerHSDSearch.Location = new System.Drawing.Point(907, 176);
            this.dateTimePickerHSDSearch.Name = "dateTimePickerHSDSearch";
            this.dateTimePickerHSDSearch.Size = new System.Drawing.Size(151, 27);
            this.dateTimePickerHSDSearch.TabIndex = 30;
            // 
            // radID
            // 
            this.radID.AutoSize = true;
            this.radID.Location = new System.Drawing.Point(50, 35);
            this.radID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radID.Name = "radID";
            this.radID.Size = new System.Drawing.Size(51, 24);
            this.radID.TabIndex = 29;
            this.radID.TabStop = true;
            this.radID.Text = "Mã";
            this.radID.UseVisualStyleBackColor = true;
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Location = new System.Drawing.Point(214, 101);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(151, 27);
            this.txtNameSearch.TabIndex = 28;
            // 
            // txtCompanySearch
            // 
            this.txtCompanySearch.Location = new System.Drawing.Point(907, 35);
            this.txtCompanySearch.Name = "txtCompanySearch";
            this.txtCompanySearch.Size = new System.Drawing.Size(151, 27);
            this.txtCompanySearch.TabIndex = 27;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCateUpdate);
            this.tabPage3.Controls.Add(this.btnCateFind);
            this.tabPage3.Controls.Add(this.btnCateDelete);
            this.tabPage3.Controls.Add(this.btnCateAdd);
            this.tabPage3.Controls.Add(this.dataGridViewCategory);
            this.tabPage3.Controls.Add(this.inputCategory);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1255, 608);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Loại hàng";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCateUpdate
            // 
            this.btnCateUpdate.Location = new System.Drawing.Point(408, 215);
            this.btnCateUpdate.Name = "btnCateUpdate";
            this.btnCateUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnCateUpdate.TabIndex = 8;
            this.btnCateUpdate.Text = "Sửa";
            this.btnCateUpdate.UseVisualStyleBackColor = true;
            this.btnCateUpdate.Click += new System.EventHandler(this.btnCateUpdate_Click);
            // 
            // btnCateFind
            // 
            this.btnCateFind.Location = new System.Drawing.Point(408, 289);
            this.btnCateFind.Name = "btnCateFind";
            this.btnCateFind.Size = new System.Drawing.Size(94, 29);
            this.btnCateFind.TabIndex = 7;
            this.btnCateFind.Text = "Tìm kiếm";
            this.btnCateFind.UseVisualStyleBackColor = true;
            this.btnCateFind.Click += new System.EventHandler(this.btnCateFind_Click);
            // 
            // btnCateDelete
            // 
            this.btnCateDelete.Location = new System.Drawing.Point(266, 289);
            this.btnCateDelete.Name = "btnCateDelete";
            this.btnCateDelete.Size = new System.Drawing.Size(94, 29);
            this.btnCateDelete.TabIndex = 6;
            this.btnCateDelete.Text = "Xóa";
            this.btnCateDelete.UseVisualStyleBackColor = true;
            this.btnCateDelete.Click += new System.EventHandler(this.btnCateDelete_Click);
            // 
            // btnCateAdd
            // 
            this.btnCateAdd.Location = new System.Drawing.Point(266, 215);
            this.btnCateAdd.Name = "btnCateAdd";
            this.btnCateAdd.Size = new System.Drawing.Size(94, 29);
            this.btnCateAdd.TabIndex = 5;
            this.btnCateAdd.Text = "Thêm";
            this.btnCateAdd.UseVisualStyleBackColor = true;
            this.btnCateAdd.Click += new System.EventHandler(this.btnCateAdd_Click);
            // 
            // dataGridViewCategory
            // 
            this.dataGridViewCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7});
            this.dataGridViewCategory.Location = new System.Drawing.Point(643, 130);
            this.dataGridViewCategory.Name = "dataGridViewCategory";
            this.dataGridViewCategory.RowHeadersWidth = 51;
            this.dataGridViewCategory.RowTemplate.Height = 29;
            this.dataGridViewCategory.Size = new System.Drawing.Size(398, 188);
            this.dataGridViewCategory.TabIndex = 4;
            this.dataGridViewCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategory_CellClick);
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Loại hàng";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 300;
            // 
            // inputCategory
            // 
            this.inputCategory.Location = new System.Drawing.Point(266, 130);
            this.inputCategory.Name = "inputCategory";
            this.inputCategory.Size = new System.Drawing.Size(236, 27);
            this.inputCategory.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 660);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnFind;
        private ComboBox txtCategorySearch;
        private DataGridView dataGridView;
        private RadioButton radID;
        private TextBox txtNameSearch;
        private TextBox txtCompanySearch;
        private DateTimePicker dateTimePickerNSXSearch;
        private DateTimePicker dateTimePickerHSDSearch;
        private RadioButton radHSD;
        private RadioButton radNSX;
        private RadioButton radCompany;
        private RadioButton radCategory;
        private RadioButton radName;
        private TextBox txtIDSearch;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private ComboBox txtCategory;
        private TextBox txtId;
        private Label label1;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtCompany;
        private DateTimePicker dateTimePickerHSD;
        private DateTimePicker dateTimePickerNSX;
        private Button btnAdd;
        private Label label2;
        private Label label3;
        private Label label6;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dataGridViewSearch;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private TabPage tabPage3;
        private Button btnCateUpdate;
        private Button btnCateFind;
        private Button btnCateDelete;
        private Button btnCateAdd;
        private DataGridView dataGridViewCategory;
        private DataGridViewTextBoxColumn Column7;
        private TextBox inputCategory;
    }
}