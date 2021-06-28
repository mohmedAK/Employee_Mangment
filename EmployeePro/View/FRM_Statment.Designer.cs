
namespace EmployeePro.View
{
    partial class FRM_Statment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Statment));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonIAddEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcEmployee = new DevExpress.XtraGrid.GridControl();
            this.cLSEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvEmployee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmpId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinalTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPreview = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repPreview = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repDelte = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLSEmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDelte)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonIAddEmployee});
            this.barManager1.MaxItemId = 1;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonIAddEmployee, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.Text = "Tools";
            // 
            // barButtonIAddEmployee
            // 
            this.barButtonIAddEmployee.Caption = "New Employee";
            this.barButtonIAddEmployee.Id = 0;
            this.barButtonIAddEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonIAddEmployee.ImageOptions.Image")));
            this.barButtonIAddEmployee.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonIAddEmployee.ImageOptions.LargeImage")));
            this.barButtonIAddEmployee.Name = "barButtonIAddEmployee";
            this.barButtonIAddEmployee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonIAddEmployee_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(902, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 484);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(902, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 458);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(902, 26);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 458);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(902, 458);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.gcEmployee);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(896, 452);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "All Employee";
            // 
            // gcEmployee
            // 
            this.gcEmployee.DataSource = this.cLSEmployeeBindingSource;
            this.gcEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcEmployee.Location = new System.Drawing.Point(2, 39);
            this.gcEmployee.MainView = this.gvEmployee;
            this.gcEmployee.MenuManager = this.barManager1;
            this.gcEmployee.Name = "gcEmployee";
            this.gcEmployee.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repPreview,
            this.repDelte});
            this.gcEmployee.Size = new System.Drawing.Size(892, 411);
            this.gcEmployee.TabIndex = 0;
            this.gcEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEmployee});
            // 
            // cLSEmployeeBindingSource
            // 
            this.cLSEmployeeBindingSource.DataSource = typeof(EmployeePro.Model.CLS_Employee);
            // 
            // gvEmployee
            // 
            this.gvEmployee.Appearance.HeaderPanel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvEmployee.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvEmployee.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvEmployee.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvEmployee.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gvEmployee.Appearance.Row.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvEmployee.Appearance.Row.Options.UseFont = true;
            this.gvEmployee.Appearance.Row.Options.UseTextOptions = true;
            this.gvEmployee.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvEmployee.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gvEmployee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmpId,
            this.colFName,
            this.colLName,
            this.colAddress,
            this.colImage,
            this.colFinalTotal,
            this.colPreview,
            this.colDelete});
            this.gvEmployee.GridControl = this.gcEmployee;
            this.gvEmployee.Name = "gvEmployee";
            this.gvEmployee.OptionsView.ShowGroupPanel = false;
            // 
            // colEmpId
            // 
            this.colEmpId.FieldName = "EmpId";
            this.colEmpId.Name = "colEmpId";
            this.colEmpId.OptionsColumn.AllowEdit = false;
            this.colEmpId.OptionsColumn.AllowFocus = false;
            this.colEmpId.OptionsColumn.AllowMove = false;
            // 
            // colFName
            // 
            this.colFName.FieldName = "FName";
            this.colFName.Name = "colFName";
            this.colFName.OptionsColumn.AllowEdit = false;
            this.colFName.OptionsColumn.AllowFocus = false;
            this.colFName.OptionsColumn.AllowMove = false;
            this.colFName.Visible = true;
            this.colFName.VisibleIndex = 0;
            this.colFName.Width = 177;
            // 
            // colLName
            // 
            this.colLName.FieldName = "LName";
            this.colLName.Name = "colLName";
            this.colLName.OptionsColumn.AllowEdit = false;
            this.colLName.OptionsColumn.AllowFocus = false;
            this.colLName.OptionsColumn.AllowMove = false;
            this.colLName.Visible = true;
            this.colLName.VisibleIndex = 1;
            this.colLName.Width = 190;
            // 
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.OptionsColumn.AllowEdit = false;
            this.colAddress.OptionsColumn.AllowFocus = false;
            this.colAddress.OptionsColumn.AllowMove = false;
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 2;
            this.colAddress.Width = 167;
            // 
            // colImage
            // 
            this.colImage.FieldName = "Image";
            this.colImage.Name = "colImage";
            this.colImage.OptionsColumn.AllowEdit = false;
            this.colImage.OptionsColumn.AllowFocus = false;
            this.colImage.OptionsColumn.AllowMove = false;
            // 
            // colFinalTotal
            // 
            this.colFinalTotal.FieldName = "FinalTotal";
            this.colFinalTotal.Name = "colFinalTotal";
            this.colFinalTotal.OptionsColumn.AllowEdit = false;
            this.colFinalTotal.OptionsColumn.AllowFocus = false;
            this.colFinalTotal.OptionsColumn.AllowMove = false;
            this.colFinalTotal.Visible = true;
            this.colFinalTotal.VisibleIndex = 3;
            this.colFinalTotal.Width = 159;
            // 
            // colPreview
            // 
            this.colPreview.ColumnEdit = this.repPreview;
            this.colPreview.Name = "colPreview";
            this.colPreview.OptionsColumn.AllowMove = false;
            this.colPreview.Visible = true;
            this.colPreview.VisibleIndex = 4;
            this.colPreview.Width = 100;
            // 
            // repPreview
            // 
            this.repPreview.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repPreview.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repPreview.Name = "repPreview";
            this.repPreview.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repPreview.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repPreview_ButtonClick);
            // 
            // colDelete
            // 
            this.colDelete.Caption = " ";
            this.colDelete.ColumnEdit = this.repDelte;
            this.colDelete.Name = "colDelete";
            this.colDelete.OptionsColumn.AllowMove = false;
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 5;
            this.colDelete.Width = 82;
            // 
            // repDelte
            // 
            this.repDelte.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.repDelte.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repDelte.Name = "repDelte";
            this.repDelte.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // FRM_Statment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 484);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.LookAndFeel.SkinName = "Money Twins";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "FRM_Statment";
            this.Text = "Statment";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLSEmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDelte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gcEmployee;
        private System.Windows.Forms.BindingSource cLSEmployeeBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpId;
        private DevExpress.XtraGrid.Columns.GridColumn colFName;
        private DevExpress.XtraGrid.Columns.GridColumn colLName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
        private DevExpress.XtraGrid.Columns.GridColumn colFinalTotal;
        private DevExpress.XtraBars.BarButtonItem barButtonIAddEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn colPreview;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repPreview;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repDelte;
    }
}