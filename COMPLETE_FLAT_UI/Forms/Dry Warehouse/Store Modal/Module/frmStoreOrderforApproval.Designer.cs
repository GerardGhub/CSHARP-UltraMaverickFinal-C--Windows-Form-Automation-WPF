﻿
namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal
{
    partial class frmStoreOrderforApproval
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.matcmbCategory = new MetroFramework.Controls.MetroComboBox();
            this.bunifuPrepaDate = new System.Windows.Forms.DateTimePicker();
            this.materialCheckboxSelectAll = new MaterialSkin.Controls.MaterialCheckbox();
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.matbtnPrint = new MaterialSkin.Controls.MaterialButton();
            this.dgvStoreOrderApproval = new Guna.UI2.WinForms.Guna2DataGridView();
            this.selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.primary_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_ordered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.store_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.route = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockOnHand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AVERAGE_ORDER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORDERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALLOCATION_QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_added = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_COLUMN_ALLOCATED_QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.lbltotaldata = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSelectedSum = new System.Windows.Forms.Label();
            this.matbtnEdit = new MaterialSkin.Controls.MaterialButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvFindDataForAlocation = new Guna.UI2.WinForms.Guna2DataGridView();
            this.groupColorCoding = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreOrderApproval)).BeginInit();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindDataForAlocation)).BeginInit();
            this.groupColorCoding.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel5);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.matcmbCategory);
            this.materialCard1.Controls.Add(this.bunifuPrepaDate);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(20, 81);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.Size = new System.Drawing.Size(1158, 90);
            this.materialCard1.TabIndex = 582;
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(957, 14);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(124, 19);
            this.materialLabel5.TabIndex = 584;
            this.materialLabel5.Text = "Preparation Date:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(19, 14);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(68, 19);
            this.materialLabel2.TabIndex = 578;
            this.materialLabel2.Text = "Category:";
            // 
            // matcmbCategory
            // 
            this.matcmbCategory.FormattingEnabled = true;
            this.matcmbCategory.ItemHeight = 23;
            this.matcmbCategory.Location = new System.Drawing.Point(18, 39);
            this.matcmbCategory.Name = "matcmbCategory";
            this.matcmbCategory.Size = new System.Drawing.Size(182, 29);
            this.matcmbCategory.TabIndex = 577;
            this.matcmbCategory.UseSelectable = true;
            this.matcmbCategory.SelectionChangeCommitted += new System.EventHandler(this.matcmbPackaging_SelectionChangeCommitted);
            // 
            // bunifuPrepaDate
            // 
            this.bunifuPrepaDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPrepaDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuPrepaDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.bunifuPrepaDate.CustomFormat = "yyyy-MM-dd";
            this.bunifuPrepaDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuPrepaDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bunifuPrepaDate.Location = new System.Drawing.Point(957, 37);
            this.bunifuPrepaDate.Name = "bunifuPrepaDate";
            this.bunifuPrepaDate.Size = new System.Drawing.Size(170, 31);
            this.bunifuPrepaDate.TabIndex = 574;
            this.bunifuPrepaDate.ValueChanged += new System.EventHandler(this.bunifuPrepaDate_ValueChanged);
            // 
            // materialCheckboxSelectAll
            // 
            this.materialCheckboxSelectAll.AutoSize = true;
            this.materialCheckboxSelectAll.Depth = 0;
            this.materialCheckboxSelectAll.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCheckboxSelectAll.Location = new System.Drawing.Point(22, 173);
            this.materialCheckboxSelectAll.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckboxSelectAll.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckboxSelectAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckboxSelectAll.Name = "materialCheckboxSelectAll";
            this.materialCheckboxSelectAll.Ripple = true;
            this.materialCheckboxSelectAll.Size = new System.Drawing.Size(100, 37);
            this.materialCheckboxSelectAll.TabIndex = 585;
            this.materialCheckboxSelectAll.Text = "Select All";
            this.materialCheckboxSelectAll.UseVisualStyleBackColor = true;
            this.materialCheckboxSelectAll.Visible = false;
            this.materialCheckboxSelectAll.CheckedChanged += new System.EventHandler(this.materialCheckboxSelectAll_CheckedChanged);
            // 
            // lbltotalrecords
            // 
            this.lbltotalrecords.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbltotalrecords.AutoSize = true;
            this.lbltotalrecords.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalrecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.lbltotalrecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotalrecords.Location = new System.Drawing.Point(975, 812);
            this.lbltotalrecords.Name = "lbltotalrecords";
            this.lbltotalrecords.Size = new System.Drawing.Size(51, 36);
            this.lbltotalrecords.TabIndex = 580;
            this.lbltotalrecords.Text = "76";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(1017, 828);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 581;
            this.label3.Text = "Items";
            // 
            // matbtnPrint
            // 
            this.matbtnPrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matbtnPrint.Depth = 0;
            this.matbtnPrint.DrawShadows = true;
            this.matbtnPrint.HighEmphasis = true;
            this.matbtnPrint.Icon = null;
            this.matbtnPrint.Location = new System.Drawing.Point(20, 720);
            this.matbtnPrint.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.matbtnPrint.MouseState = MaterialSkin.MouseState.HOVER;
            this.matbtnPrint.Name = "matbtnPrint";
            this.matbtnPrint.Size = new System.Drawing.Size(87, 36);
            this.matbtnPrint.TabIndex = 583;
            this.matbtnPrint.Text = "APPROVE";
            this.matbtnPrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matbtnPrint.UseAccentColor = false;
            this.matbtnPrint.UseVisualStyleBackColor = true;
            this.matbtnPrint.Click += new System.EventHandler(this.matbtnPrint_Click);
            // 
            // dgvStoreOrderApproval
            // 
            this.dgvStoreOrderApproval.AllowUserToAddRows = false;
            this.dgvStoreOrderApproval.AllowUserToDeleteRows = false;
            this.dgvStoreOrderApproval.AllowUserToResizeRows = false;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.White;
            this.dgvStoreOrderApproval.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle33;
            this.dgvStoreOrderApproval.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStoreOrderApproval.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvStoreOrderApproval.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStoreOrderApproval.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStoreOrderApproval.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dgvStoreOrderApproval.ColumnHeadersHeight = 45;
            this.dgvStoreOrderApproval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStoreOrderApproval.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selected,
            this.primary_id,
            this.order_id,
            this.date_ordered,
            this.fox,
            this.store_name,
            this.route,
            this.area,
            this.category,
            this.item_code,
            this.description,
            this.uom,
            this.qty,
            this.StockOnHand,
            this.AVERAGE_ORDER,
            this.ORDERS,
            this.ALLOCATION_QTY,
            this.date_added,
            this.TOTAL_COLUMN_ALLOCATED_QTY});
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStoreOrderApproval.DefaultCellStyle = dataGridViewCellStyle35;
            this.dgvStoreOrderApproval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStoreOrderApproval.EnableHeadersVisualStyles = false;
            this.dgvStoreOrderApproval.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvStoreOrderApproval.Location = new System.Drawing.Point(5, 6);
            this.dgvStoreOrderApproval.MultiSelect = false;
            this.dgvStoreOrderApproval.Name = "dgvStoreOrderApproval";
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStoreOrderApproval.RowHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.dgvStoreOrderApproval.RowHeadersVisible = false;
            this.dgvStoreOrderApproval.RowHeadersWidth = 102;
            this.dgvStoreOrderApproval.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStoreOrderApproval.RowTemplate.DividerHeight = 5;
            this.dgvStoreOrderApproval.RowTemplate.Height = 40;
            this.dgvStoreOrderApproval.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStoreOrderApproval.Size = new System.Drawing.Size(1148, 477);
            this.dgvStoreOrderApproval.TabIndex = 594;
            this.dgvStoreOrderApproval.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvStoreOrderApproval.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStoreOrderApproval.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvStoreOrderApproval.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvStoreOrderApproval.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvStoreOrderApproval.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvStoreOrderApproval.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvStoreOrderApproval.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvStoreOrderApproval.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvStoreOrderApproval.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvStoreOrderApproval.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStoreOrderApproval.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvStoreOrderApproval.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStoreOrderApproval.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvStoreOrderApproval.ThemeStyle.ReadOnly = false;
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.Height = 40;
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvStoreOrderApproval.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReprinting_CellContentClick);
            this.dgvStoreOrderApproval.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReprinting_CellContentDoubleClick);
            this.dgvStoreOrderApproval.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvStoreOrderApproval_CellFormatting);
            this.dgvStoreOrderApproval.CurrentCellChanged += new System.EventHandler(this.dgvReprinting_CurrentCellChanged);
            // 
            // selected
            // 
            this.selected.DataPropertyName = "selected";
            this.selected.FalseValue = "FALSE";
            this.selected.HeaderText = "*";
            this.selected.MinimumWidth = 12;
            this.selected.Name = "selected";
            this.selected.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.selected.TrueValue = "TRUE";
            this.selected.Width = 20;
            // 
            // primary_id
            // 
            this.primary_id.DataPropertyName = "primary_id";
            this.primary_id.FillWeight = 66.91177F;
            this.primary_id.HeaderText = "ID";
            this.primary_id.MinimumWidth = 12;
            this.primary_id.Name = "primary_id";
            this.primary_id.Width = 48;
            // 
            // order_id
            // 
            this.order_id.DataPropertyName = "order_id";
            this.order_id.FillWeight = 66.57212F;
            this.order_id.HeaderText = "ORDER ID";
            this.order_id.MinimumWidth = 12;
            this.order_id.Name = "order_id";
            this.order_id.Width = 93;
            // 
            // date_ordered
            // 
            this.date_ordered.DataPropertyName = "date_ordered";
            this.date_ordered.FillWeight = 66.57212F;
            this.date_ordered.HeaderText = "ORDER DATE";
            this.date_ordered.MinimumWidth = 12;
            this.date_ordered.Name = "date_ordered";
            this.date_ordered.Width = 111;
            // 
            // fox
            // 
            this.fox.DataPropertyName = "fox";
            this.fox.FillWeight = 66.57212F;
            this.fox.HeaderText = "STORE CODE";
            this.fox.MinimumWidth = 12;
            this.fox.Name = "fox";
            this.fox.Width = 112;
            // 
            // store_name
            // 
            this.store_name.DataPropertyName = "store_name";
            this.store_name.HeaderText = "STORE";
            this.store_name.MinimumWidth = 6;
            this.store_name.Name = "store_name";
            this.store_name.Width = 77;
            // 
            // route
            // 
            this.route.DataPropertyName = "route";
            this.route.FillWeight = 66.91177F;
            this.route.HeaderText = "ROUTE";
            this.route.MinimumWidth = 12;
            this.route.Name = "route";
            this.route.Width = 80;
            // 
            // area
            // 
            this.area.DataPropertyName = "area";
            this.area.FillWeight = 66.91177F;
            this.area.HeaderText = "AREA";
            this.area.MinimumWidth = 12;
            this.area.Name = "area";
            this.area.Width = 70;
            // 
            // category
            // 
            this.category.DataPropertyName = "category";
            this.category.FillWeight = 66.91177F;
            this.category.HeaderText = "CATEGORY";
            this.category.MinimumWidth = 12;
            this.category.Name = "category";
            this.category.Width = 108;
            // 
            // item_code
            // 
            this.item_code.DataPropertyName = "item_code";
            this.item_code.HeaderText = "ITEM CODE";
            this.item_code.MinimumWidth = 6;
            this.item_code.Name = "item_code";
            this.item_code.Width = 102;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "DESCRIPTION";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.Width = 127;
            // 
            // uom
            // 
            this.uom.DataPropertyName = "uom";
            this.uom.HeaderText = "UOM";
            this.uom.MinimumWidth = 6;
            this.uom.Name = "uom";
            this.uom.Width = 68;
            // 
            // qty
            // 
            this.qty.DataPropertyName = "qty";
            this.qty.HeaderText = "QTY";
            this.qty.MinimumWidth = 6;
            this.qty.Name = "qty";
            this.qty.Width = 61;
            // 
            // StockOnHand
            // 
            this.StockOnHand.DataPropertyName = "StockOnHand";
            this.StockOnHand.HeaderText = "SOH";
            this.StockOnHand.Name = "StockOnHand";
            this.StockOnHand.Width = 64;
            // 
            // AVERAGE_ORDER
            // 
            this.AVERAGE_ORDER.DataPropertyName = "AVERAGE_ORDER";
            this.AVERAGE_ORDER.HeaderText = "AVERAGE ORDER";
            this.AVERAGE_ORDER.Name = "AVERAGE_ORDER";
            this.AVERAGE_ORDER.Width = 138;
            // 
            // ORDERS
            // 
            this.ORDERS.DataPropertyName = "ORDERS";
            this.ORDERS.HeaderText = "TOTAL ORDER";
            this.ORDERS.Name = "ORDERS";
            this.ORDERS.Width = 116;
            // 
            // ALLOCATION_QTY
            // 
            this.ALLOCATION_QTY.DataPropertyName = "ALLOCATION_QTY";
            this.ALLOCATION_QTY.HeaderText = "ALLOCATED";
            this.ALLOCATION_QTY.Name = "ALLOCATION_QTY";
            this.ALLOCATION_QTY.Width = 113;
            // 
            // date_added
            // 
            this.date_added.DataPropertyName = "date_added";
            this.date_added.HeaderText = "DATE ADDED";
            this.date_added.MinimumWidth = 6;
            this.date_added.Name = "date_added";
            this.date_added.Width = 112;
            // 
            // TOTAL_COLUMN_ALLOCATED_QTY
            // 
            this.TOTAL_COLUMN_ALLOCATED_QTY.DataPropertyName = "TOTAL_COLUMN_ALLOCATED_QTY";
            this.TOTAL_COLUMN_ALLOCATED_QTY.HeaderText = "TOTAL COLUMN ALLOCATED QTY";
            this.TOTAL_COLUMN_ALLOCATED_QTY.Name = "TOTAL_COLUMN_ALLOCATED_QTY";
            this.TOTAL_COLUMN_ALLOCATED_QTY.Width = 208;
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dgvStoreOrderApproval);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(20, 209);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.Size = new System.Drawing.Size(1158, 489);
            this.materialCard2.TabIndex = 579;
            // 
            // lbltotaldata
            // 
            this.lbltotaldata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotaldata.AutoSize = true;
            this.lbltotaldata.BackColor = System.Drawing.Color.Transparent;
            this.lbltotaldata.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotaldata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotaldata.Location = new System.Drawing.Point(1095, 720);
            this.lbltotaldata.Name = "lbltotaldata";
            this.lbltotaldata.Size = new System.Drawing.Size(32, 40);
            this.lbltotaldata.TabIndex = 639;
            this.lbltotaldata.Text = "0";
            this.lbltotaldata.TextChanged += new System.EventHandler(this.lbltotaldata_TextChanged);
            this.lbltotaldata.Click += new System.EventHandler(this.lbltotaldata_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(1140, 734);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 640;
            this.label4.Text = "Items";
            // 
            // labelSelectedSum
            // 
            this.labelSelectedSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSelectedSum.AutoSize = true;
            this.labelSelectedSum.BackColor = System.Drawing.Color.Transparent;
            this.labelSelectedSum.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.labelSelectedSum.Location = new System.Drawing.Point(959, 169);
            this.labelSelectedSum.Name = "labelSelectedSum";
            this.labelSelectedSum.Size = new System.Drawing.Size(32, 40);
            this.labelSelectedSum.TabIndex = 641;
            this.labelSelectedSum.Text = "0";
            this.labelSelectedSum.Visible = false;
            this.labelSelectedSum.TextChanged += new System.EventHandler(this.labelSelectedSum_TextChanged);
            // 
            // matbtnEdit
            // 
            this.matbtnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matbtnEdit.Depth = 0;
            this.matbtnEdit.DrawShadows = true;
            this.matbtnEdit.HighEmphasis = true;
            this.matbtnEdit.Icon = null;
            this.matbtnEdit.Location = new System.Drawing.Point(128, 720);
            this.matbtnEdit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.matbtnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.matbtnEdit.Name = "matbtnEdit";
            this.matbtnEdit.Size = new System.Drawing.Size(53, 36);
            this.matbtnEdit.TabIndex = 642;
            this.matbtnEdit.Text = "EDIT";
            this.matbtnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matbtnEdit.UseAccentColor = false;
            this.matbtnEdit.UseVisualStyleBackColor = true;
            this.matbtnEdit.Visible = false;
            this.matbtnEdit.Click += new System.EventHandler(this.matbtnEdit_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(430, 730);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 643;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvFindDataForAlocation
            // 
            this.dgvFindDataForAlocation.AllowUserToAddRows = false;
            this.dgvFindDataForAlocation.AllowUserToDeleteRows = false;
            this.dgvFindDataForAlocation.AllowUserToResizeRows = false;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.White;
            this.dgvFindDataForAlocation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle37;
            this.dgvFindDataForAlocation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFindDataForAlocation.BackgroundColor = System.Drawing.Color.Yellow;
            this.dgvFindDataForAlocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFindDataForAlocation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFindDataForAlocation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle38;
            this.dgvFindDataForAlocation.ColumnHeadersHeight = 35;
            this.dgvFindDataForAlocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFindDataForAlocation.DefaultCellStyle = dataGridViewCellStyle39;
            this.dgvFindDataForAlocation.EnableHeadersVisualStyles = false;
            this.dgvFindDataForAlocation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvFindDataForAlocation.Location = new System.Drawing.Point(335, 710);
            this.dgvFindDataForAlocation.MultiSelect = false;
            this.dgvFindDataForAlocation.Name = "dgvFindDataForAlocation";
            this.dgvFindDataForAlocation.ReadOnly = true;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFindDataForAlocation.RowHeadersDefaultCellStyle = dataGridViewCellStyle40;
            this.dgvFindDataForAlocation.RowHeadersVisible = false;
            this.dgvFindDataForAlocation.RowHeadersWidth = 102;
            this.dgvFindDataForAlocation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFindDataForAlocation.RowTemplate.DividerHeight = 5;
            this.dgvFindDataForAlocation.RowTemplate.Height = 40;
            this.dgvFindDataForAlocation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFindDataForAlocation.Size = new System.Drawing.Size(63, 34);
            this.dgvFindDataForAlocation.TabIndex = 644;
            this.dgvFindDataForAlocation.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvFindDataForAlocation.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFindDataForAlocation.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvFindDataForAlocation.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvFindDataForAlocation.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvFindDataForAlocation.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvFindDataForAlocation.ThemeStyle.BackColor = System.Drawing.Color.Yellow;
            this.dgvFindDataForAlocation.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvFindDataForAlocation.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvFindDataForAlocation.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvFindDataForAlocation.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFindDataForAlocation.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvFindDataForAlocation.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFindDataForAlocation.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvFindDataForAlocation.ThemeStyle.ReadOnly = true;
            this.dgvFindDataForAlocation.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFindDataForAlocation.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvFindDataForAlocation.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFindDataForAlocation.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvFindDataForAlocation.ThemeStyle.RowsStyle.Height = 40;
            this.dgvFindDataForAlocation.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvFindDataForAlocation.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvFindDataForAlocation.Visible = false;
            // 
            // groupColorCoding
            // 
            this.groupColorCoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupColorCoding.BackColor = System.Drawing.SystemColors.Window;
            this.groupColorCoding.Controls.Add(this.panel2);
            this.groupColorCoding.Controls.Add(this.materialLabel6);
            this.groupColorCoding.Controls.Add(this.materialLabel4);
            this.groupColorCoding.Controls.Add(this.panel1);
            this.groupColorCoding.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupColorCoding.Location = new System.Drawing.Point(696, 700);
            this.groupColorCoding.Name = "groupColorCoding";
            this.groupColorCoding.Size = new System.Drawing.Size(394, 62);
            this.groupColorCoding.TabIndex = 595;
            this.groupColorCoding.TabStop = false;
            this.groupColorCoding.Text = "Color Coding Guide :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Location = new System.Drawing.Point(329, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(39, 29);
            this.panel2.TabIndex = 1;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel6.Location = new System.Drawing.Point(202, 27);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(87, 14);
            this.materialLabel6.TabIndex = 2;
            this.materialLabel6.Text = "Abnormal Order";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel4.Location = new System.Drawing.Point(13, 28);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(77, 14);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "For Allocation";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Location = new System.Drawing.Point(131, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(39, 29);
            this.panel1.TabIndex = 0;
            // 
            // frmStoreOrderforApproval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 768);
            this.Controls.Add(this.groupColorCoding);
            this.Controls.Add(this.dgvFindDataForAlocation);
            this.Controls.Add(this.materialCheckboxSelectAll);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.matbtnEdit);
            this.Controls.Add(this.labelSelectedSum);
            this.Controls.Add(this.lbltotaldata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.lbltotalrecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.matbtnPrint);
            this.Controls.Add(this.materialCard2);
            this.Name = "frmStoreOrderforApproval";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order  Approval";
            this.Load += new System.EventHandler(this.frmStoreOrderforApproval_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreOrderApproval)).EndInit();
            this.materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindDataForAlocation)).EndInit();
            this.groupColorCoding.ResumeLayout(false);
            this.groupColorCoding.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.DateTimePicker bunifuPrepaDate;
        private System.Windows.Forms.Label lbltotalrecords;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialButton matbtnPrint;
        private Guna.UI2.WinForms.Guna2DataGridView dgvStoreOrderApproval;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.Label lbltotaldata;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.Label labelSelectedSum;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckboxSelectAll;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MetroFramework.Controls.MetroComboBox matcmbCategory;
        private MaterialSkin.Controls.MaterialButton matbtnEdit;
        public System.Windows.Forms.TextBox textBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvFindDataForAlocation;
        private System.Windows.Forms.GroupBox groupColorCoding;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn primary_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_ordered;
        private System.Windows.Forms.DataGridViewTextBoxColumn fox;
        private System.Windows.Forms.DataGridViewTextBoxColumn store_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn route;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn uom;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockOnHand;
        private System.Windows.Forms.DataGridViewTextBoxColumn AVERAGE_ORDER;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALLOCATION_QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_added;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_COLUMN_ALLOCATED_QTY;
    }
}