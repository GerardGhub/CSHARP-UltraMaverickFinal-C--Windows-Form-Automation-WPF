﻿
namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal
{
    partial class frmStoreOrderActivationRemarks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStoreOrderActivationRemarks));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.matBtnCancel = new System.Windows.Forms.ToolStripButton();
            this.matBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.matBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.matBtnNew = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.metroSave = new MetroFramework.Controls.MetroButton();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.dgvAVGOrderTrend = new Guna.UI2.WinForms.Guna2DataGridView();
            this.soar_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soar_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soar_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soar_added_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soar_date_added = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soar_updated_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soar_updated_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matBtnSave = new System.Windows.Forms.ToolStripButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.matcmbType = new MaterialSkin.Controls.MaterialComboBox();
            this.mattxtSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.txtmatRemarks = new MaterialSkin.Controls.MaterialTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.metroFinalSaving = new MetroFramework.Controls.MetroButton();
            this.matRadioActive = new MaterialSkin.Controls.MaterialRadioButton();
            this.matRadioNotActive = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAVGOrderTrend)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.SuspendLayout();
            // 
            // matBtnCancel
            // 
            this.matBtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("matBtnCancel.Image")));
            this.matBtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnCancel.Name = "matBtnCancel";
            this.matBtnCancel.Size = new System.Drawing.Size(95, 41);
            this.matBtnCancel.Text = "&Cancel";
            this.matBtnCancel.Visible = false;
            this.matBtnCancel.Click += new System.EventHandler(this.matBtnCancel_Click);
            // 
            // matBtnDelete
            // 
            this.matBtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("matBtnDelete.Image")));
            this.matBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnDelete.Name = "matBtnDelete";
            this.matBtnDelete.Size = new System.Drawing.Size(102, 41);
            this.matBtnDelete.Text = "&InActive";
            this.matBtnDelete.Click += new System.EventHandler(this.matBtnDelete_Click);
            // 
            // matBtnEdit
            // 
            this.matBtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("matBtnEdit.Image")));
            this.matBtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnEdit.Name = "matBtnEdit";
            this.matBtnEdit.Size = new System.Drawing.Size(76, 41);
            this.matBtnEdit.Text = "&Edit";
            this.matBtnEdit.Click += new System.EventHandler(this.matBtnEdit_Click);
            // 
            // matBtnNew
            // 
            this.matBtnNew.Image = ((System.Drawing.Image)(resources.GetObject("matBtnNew.Image")));
            this.matBtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnNew.Name = "matBtnNew";
            this.matBtnNew.Size = new System.Drawing.Size(82, 41);
            this.matBtnNew.Text = "&New";
            this.matBtnNew.Click += new System.EventHandler(this.matBtnNew_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.label2.Location = new System.Drawing.Point(1239, 908);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 617;
            this.label2.Text = "Items";
            // 
            // lbltotalrecords
            // 
            this.lbltotalrecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotalrecords.AutoSize = true;
            this.lbltotalrecords.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalrecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.lbltotalrecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotalrecords.Location = new System.Drawing.Point(1149, 894);
            this.lbltotalrecords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotalrecords.Name = "lbltotalrecords";
            this.lbltotalrecords.Size = new System.Drawing.Size(40, 42);
            this.lbltotalrecords.TabIndex = 616;
            this.lbltotalrecords.Text = "0";
            // 
            // metroSave
            // 
            this.metroSave.Location = new System.Drawing.Point(535, 225);
            this.metroSave.Margin = new System.Windows.Forms.Padding(1);
            this.metroSave.Name = "metroSave";
            this.metroSave.Size = new System.Drawing.Size(91, 25);
            this.metroSave.TabIndex = 612;
            this.metroSave.Text = "Add";
            this.metroSave.UseSelectable = true;
            this.metroSave.Visible = false;
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dgvAVGOrderTrend);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(31, 304);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.materialCard2.Size = new System.Drawing.Size(1287, 574);
            this.materialCard2.TabIndex = 610;
            // 
            // dgvAVGOrderTrend
            // 
            this.dgvAVGOrderTrend.AllowUserToAddRows = false;
            this.dgvAVGOrderTrend.AllowUserToDeleteRows = false;
            this.dgvAVGOrderTrend.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAVGOrderTrend.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAVGOrderTrend.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAVGOrderTrend.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvAVGOrderTrend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAVGOrderTrend.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAVGOrderTrend.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAVGOrderTrend.ColumnHeadersHeight = 35;
            this.dgvAVGOrderTrend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAVGOrderTrend.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.soar_id,
            this.soar_desc,
            this.soar_type,
            this.soar_added_by,
            this.soar_date_added,
            this.soar_updated_by,
            this.soar_updated_date});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAVGOrderTrend.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAVGOrderTrend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAVGOrderTrend.EnableHeadersVisualStyles = false;
            this.dgvAVGOrderTrend.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvAVGOrderTrend.Location = new System.Drawing.Point(7, 7);
            this.dgvAVGOrderTrend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAVGOrderTrend.MultiSelect = false;
            this.dgvAVGOrderTrend.Name = "dgvAVGOrderTrend";
            this.dgvAVGOrderTrend.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAVGOrderTrend.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAVGOrderTrend.RowHeadersVisible = false;
            this.dgvAVGOrderTrend.RowHeadersWidth = 102;
            this.dgvAVGOrderTrend.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAVGOrderTrend.RowTemplate.DividerHeight = 5;
            this.dgvAVGOrderTrend.RowTemplate.Height = 40;
            this.dgvAVGOrderTrend.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAVGOrderTrend.Size = new System.Drawing.Size(1273, 560);
            this.dgvAVGOrderTrend.TabIndex = 593;
            this.dgvAVGOrderTrend.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvAVGOrderTrend.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAVGOrderTrend.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAVGOrderTrend.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAVGOrderTrend.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAVGOrderTrend.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAVGOrderTrend.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvAVGOrderTrend.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvAVGOrderTrend.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvAVGOrderTrend.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvAVGOrderTrend.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAVGOrderTrend.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAVGOrderTrend.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAVGOrderTrend.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvAVGOrderTrend.ThemeStyle.ReadOnly = true;
            this.dgvAVGOrderTrend.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAVGOrderTrend.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvAVGOrderTrend.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAVGOrderTrend.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvAVGOrderTrend.ThemeStyle.RowsStyle.Height = 40;
            this.dgvAVGOrderTrend.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvAVGOrderTrend.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAVGOrderTrend.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAVGOrderTrend_CellFormatting);
            this.dgvAVGOrderTrend.CurrentCellChanged += new System.EventHandler(this.dgvAVGOrderTrend_CurrentCellChanged);
            // 
            // soar_id
            // 
            this.soar_id.DataPropertyName = "soar_id";
            this.soar_id.FillWeight = 40.60914F;
            this.soar_id.HeaderText = "ID";
            this.soar_id.MinimumWidth = 12;
            this.soar_id.Name = "soar_id";
            this.soar_id.ReadOnly = true;
            // 
            // soar_desc
            // 
            this.soar_desc.DataPropertyName = "soar_desc";
            this.soar_desc.FillWeight = 99.49239F;
            this.soar_desc.HeaderText = "REMARKS";
            this.soar_desc.MinimumWidth = 12;
            this.soar_desc.Name = "soar_desc";
            this.soar_desc.ReadOnly = true;
            // 
            // soar_type
            // 
            this.soar_type.DataPropertyName = "soar_type";
            this.soar_type.FillWeight = 99.49239F;
            this.soar_type.HeaderText = "TYPE";
            this.soar_type.MinimumWidth = 12;
            this.soar_type.Name = "soar_type";
            this.soar_type.ReadOnly = true;
            // 
            // soar_added_by
            // 
            this.soar_added_by.DataPropertyName = "soar_added_by";
            this.soar_added_by.FillWeight = 99.49239F;
            this.soar_added_by.HeaderText = "ADDED BY";
            this.soar_added_by.MinimumWidth = 12;
            this.soar_added_by.Name = "soar_added_by";
            this.soar_added_by.ReadOnly = true;
            // 
            // soar_date_added
            // 
            this.soar_date_added.DataPropertyName = "soar_date_added";
            this.soar_date_added.FillWeight = 99.49239F;
            this.soar_date_added.HeaderText = "DATE ADDED";
            this.soar_date_added.MinimumWidth = 12;
            this.soar_date_added.Name = "soar_date_added";
            this.soar_date_added.ReadOnly = true;
            // 
            // soar_updated_by
            // 
            this.soar_updated_by.DataPropertyName = "soar_updated_by";
            this.soar_updated_by.HeaderText = "UPDATED BY";
            this.soar_updated_by.MinimumWidth = 6;
            this.soar_updated_by.Name = "soar_updated_by";
            this.soar_updated_by.ReadOnly = true;
            // 
            // soar_updated_date
            // 
            this.soar_updated_date.DataPropertyName = "soar_updated_date";
            this.soar_updated_date.HeaderText = "UPDATED DATE";
            this.soar_updated_date.MinimumWidth = 6;
            this.soar_updated_date.Name = "soar_updated_date";
            this.soar_updated_date.ReadOnly = true;
            // 
            // matBtnSave
            // 
            this.matBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("matBtnSave.Image")));
            this.matBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnSave.Name = "matBtnSave";
            this.matBtnSave.Size = new System.Drawing.Size(82, 41);
            this.matBtnSave.Text = "&Save";
            this.matBtnSave.Visible = false;
            this.matBtnSave.Click += new System.EventHandler(this.matBtnSave_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.matcmbType);
            this.materialCard1.Controls.Add(this.mattxtSearch);
            this.materialCard1.Controls.Add(this.txtmatRemarks);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(31, 94);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.materialCard1.Size = new System.Drawing.Size(1287, 123);
            this.materialCard1.TabIndex = 611;
            // 
            // matcmbType
            // 
            this.matcmbType.AutoResize = false;
            this.matcmbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.matcmbType.Depth = 0;
            this.matcmbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.matcmbType.DropDownHeight = 174;
            this.matcmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.matcmbType.DropDownWidth = 121;
            this.matcmbType.Enabled = false;
            this.matcmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.matcmbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.matcmbType.FormattingEnabled = true;
            this.matcmbType.Hint = "Type";
            this.matcmbType.IntegralHeight = false;
            this.matcmbType.ItemHeight = 43;
            this.matcmbType.Items.AddRange(new object[] {
            "Cancel",
            "Return"});
            this.matcmbType.Location = new System.Drawing.Point(547, 47);
            this.matcmbType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matcmbType.MaxDropDownItems = 4;
            this.matcmbType.MouseState = MaterialSkin.MouseState.OUT;
            this.matcmbType.Name = "matcmbType";
            this.matcmbType.Size = new System.Drawing.Size(429, 49);
            this.matcmbType.TabIndex = 601;
            // 
            // mattxtSearch
            // 
            this.mattxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mattxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtSearch.Depth = 0;
            this.mattxtSearch.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtSearch.Hint = "Search";
            this.mattxtSearch.Location = new System.Drawing.Point(1016, 46);
            this.mattxtSearch.Margin = new System.Windows.Forms.Padding(1);
            this.mattxtSearch.MaxLength = 50;
            this.mattxtSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtSearch.Multiline = false;
            this.mattxtSearch.Name = "mattxtSearch";
            this.mattxtSearch.Size = new System.Drawing.Size(263, 50);
            this.mattxtSearch.TabIndex = 600;
            this.mattxtSearch.Text = "";
            this.mattxtSearch.TextChanged += new System.EventHandler(this.mattxtSearch_TextChanged);
            this.mattxtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mattxtSearch_KeyPress);
            // 
            // txtmatRemarks
            // 
            this.txtmatRemarks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmatRemarks.Depth = 0;
            this.txtmatRemarks.Enabled = false;
            this.txtmatRemarks.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtmatRemarks.Hint = "Remarks";
            this.txtmatRemarks.Location = new System.Drawing.Point(31, 47);
            this.txtmatRemarks.Margin = new System.Windows.Forms.Padding(1);
            this.txtmatRemarks.MaxLength = 50;
            this.txtmatRemarks.MouseState = MaterialSkin.MouseState.OUT;
            this.txtmatRemarks.Multiline = false;
            this.txtmatRemarks.Name = "txtmatRemarks";
            this.txtmatRemarks.Size = new System.Drawing.Size(459, 50);
            this.txtmatRemarks.TabIndex = 0;
            this.txtmatRemarks.Text = "";
            this.txtmatRemarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmatRemarks_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Location = new System.Drawing.Point(48, 254);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 44);
            this.panel1.TabIndex = 614;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip2.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matBtnNew,
            this.matBtnEdit,
            this.matBtnDelete,
            this.matBtnSave,
            this.matBtnCancel});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip2.Size = new System.Drawing.Size(428, 44);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // metroFinalSaving
            // 
            this.metroFinalSaving.Location = new System.Drawing.Point(552, 252);
            this.metroFinalSaving.Margin = new System.Windows.Forms.Padding(1);
            this.metroFinalSaving.Name = "metroFinalSaving";
            this.metroFinalSaving.Size = new System.Drawing.Size(91, 25);
            this.metroFinalSaving.TabIndex = 613;
            this.metroFinalSaving.Text = "Saving";
            this.metroFinalSaving.UseSelectable = true;
            this.metroFinalSaving.Visible = false;
            // 
            // matRadioActive
            // 
            this.matRadioActive.AutoSize = true;
            this.matRadioActive.Depth = 0;
            this.matRadioActive.Location = new System.Drawing.Point(24, 17);
            this.matRadioActive.Margin = new System.Windows.Forms.Padding(0);
            this.matRadioActive.MouseLocation = new System.Drawing.Point(-1, -1);
            this.matRadioActive.MouseState = MaterialSkin.MouseState.HOVER;
            this.matRadioActive.Name = "matRadioActive";
            this.matRadioActive.Ripple = true;
            this.matRadioActive.Size = new System.Drawing.Size(78, 37);
            this.matRadioActive.TabIndex = 597;
            this.matRadioActive.TabStop = true;
            this.matRadioActive.Text = "Active";
            this.matRadioActive.UseVisualStyleBackColor = true;
            this.matRadioActive.CheckedChanged += new System.EventHandler(this.matRadioActive_CheckedChanged);
            // 
            // matRadioNotActive
            // 
            this.matRadioNotActive.AutoSize = true;
            this.matRadioNotActive.Depth = 0;
            this.matRadioNotActive.Location = new System.Drawing.Point(149, 17);
            this.matRadioNotActive.Margin = new System.Windows.Forms.Padding(0);
            this.matRadioNotActive.MouseLocation = new System.Drawing.Point(-1, -1);
            this.matRadioNotActive.MouseState = MaterialSkin.MouseState.HOVER;
            this.matRadioNotActive.Name = "matRadioNotActive";
            this.matRadioNotActive.Ripple = true;
            this.matRadioNotActive.Size = new System.Drawing.Size(91, 37);
            this.matRadioNotActive.TabIndex = 598;
            this.matRadioNotActive.TabStop = true;
            this.matRadioNotActive.Text = "InActive";
            this.matRadioNotActive.UseVisualStyleBackColor = true;
            this.matRadioNotActive.CheckedChanged += new System.EventHandler(this.matRadioNotActive_CheckedChanged);
            // 
            // materialCard3
            // 
            this.materialCard3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.matRadioActive);
            this.materialCard3.Controls.Add(this.matRadioNotActive);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(1023, 225);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.materialCard3.Size = new System.Drawing.Size(295, 73);
            this.materialCard3.TabIndex = 615;
            // 
            // frmStoreOrderActivationRemarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 945);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbltotalrecords);
            this.Controls.Add(this.metroSave);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroFinalSaving);
            this.Controls.Add(this.materialCard3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmStoreOrderActivationRemarks";
            this.Text = "Order Activation Remarks";
            this.Load += new System.EventHandler(this.frmStoreOrderCancelRemarks_Load);
            this.materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAVGOrderTrend)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton matBtnCancel;
        private System.Windows.Forms.ToolStripButton matBtnDelete;
        private System.Windows.Forms.ToolStripButton matBtnEdit;
        private System.Windows.Forms.ToolStripButton matBtnNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltotalrecords;
        private MetroFramework.Controls.MetroButton metroSave;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAVGOrderTrend;
        private System.Windows.Forms.ToolStripButton matBtnSave;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox mattxtSearch;
        private MaterialSkin.Controls.MaterialTextBox txtmatRemarks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private MetroFramework.Controls.MetroButton metroFinalSaving;
        private MaterialSkin.Controls.MaterialRadioButton matRadioActive;
        private MaterialSkin.Controls.MaterialRadioButton matRadioNotActive;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialComboBox matcmbType;
        private System.Windows.Forms.DataGridViewTextBoxColumn soar_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn soar_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn soar_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn soar_added_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn soar_date_added;
        private System.Windows.Forms.DataGridViewTextBoxColumn soar_updated_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn soar_updated_date;
    }
}