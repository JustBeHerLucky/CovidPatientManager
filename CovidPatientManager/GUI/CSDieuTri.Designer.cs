
namespace CovidPatientManager.GUI
{
    partial class CSDieuTri
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSDieuTri));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.diaDiemDieuTriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.covidPatientManagerDTBDataSet2 = new CovidPatientManager.CovidPatientManagerDTBDataSet2();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDDiaDiemDieuTri1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDiemDieuTri1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSucChua1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHienTai1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.colHienTai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSucChua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDiemDieuTri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDDiaDiemDieuTri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.diaDiemDieuTriTableAdapter = new CovidPatientManager.CovidPatientManagerDTBDataSet2TableAdapters.DiaDiemDieuTriTableAdapter();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtHienTai = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSucChua = new DevExpress.XtraEditors.TextEdit();
            this.txtDiemDT = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaDiemDieuTriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidPatientManagerDTBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHienTai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSucChua.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiemDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Location = new System.Drawing.Point(461, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(409, 503);
            this.panelControl1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.diaDiemDieuTriBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(405, 499);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // diaDiemDieuTriBindingSource
            // 
            this.diaDiemDieuTriBindingSource.DataMember = "DiaDiemDieuTri";
            this.diaDiemDieuTriBindingSource.DataSource = this.covidPatientManagerDTBDataSet2;
            // 
            // covidPatientManagerDTBDataSet2
            // 
            this.covidPatientManagerDTBDataSet2.DataSetName = "CovidPatientManagerDTBDataSet2";
            this.covidPatientManagerDTBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDDiaDiemDieuTri1,
            this.colTenDiemDieuTri1,
            this.colSucChua1,
            this.colHienTai1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colIDDiaDiemDieuTri1
            // 
            this.colIDDiaDiemDieuTri1.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colIDDiaDiemDieuTri1.AppearanceCell.Options.UseFont = true;
            this.colIDDiaDiemDieuTri1.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colIDDiaDiemDieuTri1.AppearanceHeader.Options.UseFont = true;
            this.colIDDiaDiemDieuTri1.Caption = "ID";
            this.colIDDiaDiemDieuTri1.FieldName = "IDDiaDiemDieuTri";
            this.colIDDiaDiemDieuTri1.MaxWidth = 100;
            this.colIDDiaDiemDieuTri1.Name = "colIDDiaDiemDieuTri1";
            this.colIDDiaDiemDieuTri1.Visible = true;
            this.colIDDiaDiemDieuTri1.VisibleIndex = 0;
            // 
            // colTenDiemDieuTri1
            // 
            this.colTenDiemDieuTri1.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTenDiemDieuTri1.AppearanceCell.Options.UseFont = true;
            this.colTenDiemDieuTri1.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTenDiemDieuTri1.AppearanceHeader.Options.UseFont = true;
            this.colTenDiemDieuTri1.Caption = "Tên địa điểm";
            this.colTenDiemDieuTri1.FieldName = "TenDiemDieuTri";
            this.colTenDiemDieuTri1.Name = "colTenDiemDieuTri1";
            this.colTenDiemDieuTri1.Visible = true;
            this.colTenDiemDieuTri1.VisibleIndex = 1;
            // 
            // colSucChua1
            // 
            this.colSucChua1.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSucChua1.AppearanceCell.Options.UseFont = true;
            this.colSucChua1.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSucChua1.AppearanceHeader.Options.UseFont = true;
            this.colSucChua1.Caption = "Sức chứa";
            this.colSucChua1.FieldName = "SucChua";
            this.colSucChua1.MaxWidth = 100;
            this.colSucChua1.Name = "colSucChua1";
            this.colSucChua1.Visible = true;
            this.colSucChua1.VisibleIndex = 2;
            // 
            // colHienTai1
            // 
            this.colHienTai1.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHienTai1.AppearanceCell.Options.UseFont = true;
            this.colHienTai1.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHienTai1.AppearanceHeader.Options.UseFont = true;
            this.colHienTai1.Caption = "Hiện tại";
            this.colHienTai1.FieldName = "HienTai";
            this.colHienTai1.MaxWidth = 100;
            this.colHienTai1.Name = "colHienTai1";
            this.colHienTai1.Visible = true;
            this.colHienTai1.VisibleIndex = 3;
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Location = new System.Drawing.Point(12, 12);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(443, 501);
            this.panelControl2.TabIndex = 1;
            // 
            // colHienTai
            // 
            this.colHienTai.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHienTai.AppearanceCell.Options.UseFont = true;
            this.colHienTai.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHienTai.AppearanceHeader.Options.UseFont = true;
            this.colHienTai.Caption = "Hiện tại";
            this.colHienTai.FieldName = "HienTai";
            this.colHienTai.MinWidth = 40;
            this.colHienTai.Name = "colHienTai";
            this.colHienTai.OptionsColumn.ReadOnly = true;
            // 
            // colSucChua
            // 
            this.colSucChua.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSucChua.AppearanceCell.Options.UseFont = true;
            this.colSucChua.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSucChua.AppearanceHeader.Options.UseFont = true;
            this.colSucChua.Caption = "Sức chứa";
            this.colSucChua.FieldName = "SucChua";
            this.colSucChua.MinWidth = 50;
            this.colSucChua.Name = "colSucChua";
            // 
            // colTenDiemDieuTri
            // 
            this.colTenDiemDieuTri.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTenDiemDieuTri.AppearanceCell.Options.UseFont = true;
            this.colTenDiemDieuTri.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTenDiemDieuTri.AppearanceHeader.Options.UseFont = true;
            this.colTenDiemDieuTri.Caption = "Điểm điều trị";
            this.colTenDiemDieuTri.FieldName = "TenDiemDieuTri";
            this.colTenDiemDieuTri.MinWidth = 150;
            this.colTenDiemDieuTri.Name = "colTenDiemDieuTri";
            this.colTenDiemDieuTri.Width = 150;
            // 
            // colIDDiaDiemDieuTri
            // 
            this.colIDDiaDiemDieuTri.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colIDDiaDiemDieuTri.AppearanceCell.Options.UseFont = true;
            this.colIDDiaDiemDieuTri.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colIDDiaDiemDieuTri.AppearanceHeader.Options.UseFont = true;
            this.colIDDiaDiemDieuTri.Caption = "ID";
            this.colIDDiaDiemDieuTri.FieldName = "IDDiaDiemDieuTri";
            this.colIDDiaDiemDieuTri.MinWidth = 50;
            this.colIDDiaDiemDieuTri.Name = "colIDDiaDiemDieuTri";
            // 
            // diaDiemDieuTriTableAdapter
            // 
            this.diaDiemDieuTriTableAdapter.ClearBeforeFill = true;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.btnLuu);
            this.groupControl1.Controls.Add(this.btnThem);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtHienTai);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtSucChua);
            this.groupControl1.Controls.Add(this.txtDiemDT);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(439, 497);
            this.groupControl1.TabIndex = 47;
            this.groupControl1.Text = "CƠ SỞ ĐIỀU TRỊ";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(41, 148);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 17);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Hiện tại";
            // 
            // txtHienTai
            // 
            this.txtHienTai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHienTai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diaDiemDieuTriBindingSource, "HienTai", true));
            this.txtHienTai.Location = new System.Drawing.Point(155, 145);
            this.txtHienTai.Name = "txtHienTai";
            this.txtHienTai.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHienTai.Properties.Appearance.Options.UseFont = true;
            this.txtHienTai.Properties.ReadOnly = true;
            this.txtHienTai.Properties.UseReadOnlyAppearance = false;
            this.txtHienTai.Size = new System.Drawing.Size(243, 24);
            this.txtHienTai.TabIndex = 14;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(41, 109);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 17);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Sức chứa";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(41, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 17);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Điểm điều trị";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(41, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(13, 17);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "ID";
            // 
            // txtSucChua
            // 
            this.txtSucChua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSucChua.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diaDiemDieuTriBindingSource, "SucChua", true));
            this.txtSucChua.Location = new System.Drawing.Point(155, 106);
            this.txtSucChua.Name = "txtSucChua";
            this.txtSucChua.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSucChua.Properties.Appearance.Options.UseFont = true;
            this.txtSucChua.Size = new System.Drawing.Size(243, 24);
            this.txtSucChua.TabIndex = 10;
            // 
            // txtDiemDT
            // 
            this.txtDiemDT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiemDT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diaDiemDieuTriBindingSource, "TenDiemDieuTri", true));
            this.txtDiemDT.Location = new System.Drawing.Point(155, 64);
            this.txtDiemDT.Name = "txtDiemDT";
            this.txtDiemDT.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemDT.Properties.Appearance.Options.UseFont = true;
            this.txtDiemDT.Size = new System.Drawing.Size(243, 24);
            this.txtDiemDT.TabIndex = 9;
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diaDiemDieuTriBindingSource, "IDDiaDiemDieuTri", true));
            this.txtID.Location = new System.Drawing.Point(155, 25);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Properties.ReadOnly = true;
            this.txtID.Properties.UseReadOnlyAppearance = false;
            this.txtID.Size = new System.Drawing.Size(243, 24);
            this.txtID.TabIndex = 8;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(90, 278);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(100, 44);
            this.simpleButton2.TabIndex = 50;
            this.simpleButton2.Text = "Hủy";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(237, 278);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(100, 44);
            this.simpleButton1.TabIndex = 49;
            this.simpleButton1.Text = "Xóa";
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLuu.ImageOptions.SvgImage")));
            this.btnLuu.Location = new System.Drawing.Point(237, 196);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 44);
            this.btnLuu.TabIndex = 48;
            this.btnLuu.Text = "Lưu";
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Location = new System.Drawing.Point(90, 196);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 44);
            this.btnThem.TabIndex = 47;
            this.btnThem.Text = "Thêm";
            // 
            // CSDieuTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 527);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "CSDieuTri";
            this.Text = "CƠ SỞ ĐIỀU TRỊ";
            this.Load += new System.EventHandler(this.CSDieuTri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaDiemDieuTriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidPatientManagerDTBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHienTai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSucChua.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiemDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colHienTai;
        private DevExpress.XtraGrid.Columns.GridColumn colSucChua;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDiemDieuTri;
        private DevExpress.XtraGrid.Columns.GridColumn colIDDiaDiemDieuTri;
        private CovidPatientManagerDTBDataSet2 covidPatientManagerDTBDataSet2;
        private System.Windows.Forms.BindingSource diaDiemDieuTriBindingSource;
        private CovidPatientManagerDTBDataSet2TableAdapters.DiaDiemDieuTriTableAdapter diaDiemDieuTriTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIDDiaDiemDieuTri1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDiemDieuTri1;
        private DevExpress.XtraGrid.Columns.GridColumn colSucChua1;
        private DevExpress.XtraGrid.Columns.GridColumn colHienTai1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtHienTai;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSucChua;
        private DevExpress.XtraEditors.TextEdit txtDiemDT;
        private DevExpress.XtraEditors.TextEdit txtID;
    }
}