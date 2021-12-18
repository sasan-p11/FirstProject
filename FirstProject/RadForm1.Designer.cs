
namespace FirstProject
{
    partial class RadForm1
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
            Telerik.WinControls.UI.CartesianArea cartesianArea1 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.CategoricalAxis categoricalAxis1 = new Telerik.WinControls.UI.CategoricalAxis();
            Telerik.WinControls.UI.LinearAxis linearAxis1 = new Telerik.WinControls.UI.LinearAxis();
            Telerik.WinControls.UI.BarSeries barSeries1 = new Telerik.WinControls.UI.BarSeries();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegisterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.lblFilteGender = new Telerik.WinControls.UI.RadLabel();
            this.txtGender = new Telerik.WinControls.UI.RadTextBox();
            this.btnFilter = new Telerik.WinControls.UI.RadButton();
            this.txtFilterAge = new Telerik.WinControls.UI.RadTextBox();
            this.lblFilterAge = new Telerik.WinControls.UI.RadLabel();
            this.tabRegisterUser = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnExpotExcel = new Telerik.WinControls.UI.RadButton();
            this.rdoFilterRegsiterDate = new Telerik.WinControls.UI.RadRadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRegister = new Telerik.WinControls.UI.RadButton();
            this.txtPasswordRegister = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.txtUserNameRegister = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.txtGenderRegister = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.txtAge = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.txtFamily = new Telerik.WinControls.UI.RadTextBox();
            this.lblFamily = new Telerik.WinControls.UI.RadLabel();
            this.txtFirstName = new Telerik.WinControls.UI.RadTextBox();
            this.lblFirstName = new Telerik.WinControls.UI.RadLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.radChart = new Telerik.WinControls.UI.RadChartView();
            this.database_planarDataSet = new FirstProject.database_planarDataSet();
            this.tilecalibregradeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tile_calibre_gradeTableAdapter = new FirstProject.database_planarDataSetTableAdapters.tile_calibre_gradeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFilteGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilterAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFilterAge)).BeginInit();
            this.tabRegisterUser.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExpotExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoFilterRegsiterDate)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserNameRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGenderRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFamily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFamily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFirstName)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_planarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tilecalibregradeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.Gender,
            this.FirstName,
            this.Family,
            this.Age,
            this.RegisterDate,
            this.UserName,
            this.Password});
            this.dataGridView2.Location = new System.Drawing.Point(8, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(866, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // UserId
            // 
            this.UserId.HeaderText = "UserId";
            this.UserId.Name = "UserId";
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            // 
            // Family
            // 
            this.Family.HeaderText = "Family";
            this.Family.Name = "Family";
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            // 
            // RegisterDate
            // 
            this.RegisterDate.HeaderText = "RegisterDate";
            this.RegisterDate.Name = "RegisterDate";
            // 
            // UserName
            // 
            this.UserName.HeaderText = "UserName";
            this.UserName.Name = "UserName";
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(6, 271);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(130, 34);
            this.radButton2.TabIndex = 1;
            this.radButton2.Text = "Log";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // lblFilteGender
            // 
            this.lblFilteGender.Location = new System.Drawing.Point(8, 171);
            this.lblFilteGender.Name = "lblFilteGender";
            this.lblFilteGender.Size = new System.Drawing.Size(76, 18);
            this.lblFilteGender.TabIndex = 2;
            this.lblFilteGender.Text = "Filter Gender :";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(90, 170);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(111, 24);
            this.txtGender.TabIndex = 3;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(142, 271);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(135, 34);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Filter";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtFilterAge
            // 
            this.txtFilterAge.Location = new System.Drawing.Point(90, 200);
            this.txtFilterAge.Name = "txtFilterAge";
            this.txtFilterAge.Size = new System.Drawing.Size(111, 24);
            this.txtFilterAge.TabIndex = 6;
            // 
            // lblFilterAge
            // 
            this.lblFilterAge.Location = new System.Drawing.Point(8, 201);
            this.lblFilterAge.Name = "lblFilterAge";
            this.lblFilterAge.Size = new System.Drawing.Size(59, 18);
            this.lblFilterAge.TabIndex = 5;
            this.lblFilterAge.Text = "Filter Age :";
            // 
            // tabRegisterUser
            // 
            this.tabRegisterUser.Controls.Add(this.tabPage1);
            this.tabRegisterUser.Controls.Add(this.tabPage2);
            this.tabRegisterUser.Controls.Add(this.tabPage3);
            this.tabRegisterUser.Location = new System.Drawing.Point(12, 12);
            this.tabRegisterUser.Name = "tabRegisterUser";
            this.tabRegisterUser.SelectedIndex = 0;
            this.tabRegisterUser.Size = new System.Drawing.Size(865, 337);
            this.tabRegisterUser.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnExpotExcel);
            this.tabPage1.Controls.Add(this.rdoFilterRegsiterDate);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.txtFilterAge);
            this.tabPage1.Controls.Add(this.radButton2);
            this.tabPage1.Controls.Add(this.lblFilterAge);
            this.tabPage1.Controls.Add(this.lblFilteGender);
            this.tabPage1.Controls.Add(this.btnFilter);
            this.tabPage1.Controls.Add(this.txtGender);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(857, 311);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnExpotExcel
            // 
            this.btnExpotExcel.Location = new System.Drawing.Point(283, 271);
            this.btnExpotExcel.Name = "btnExpotExcel";
            this.btnExpotExcel.Size = new System.Drawing.Size(135, 34);
            this.btnExpotExcel.TabIndex = 8;
            this.btnExpotExcel.Text = "Export Excel";
            this.btnExpotExcel.Click += new System.EventHandler(this.btnExpotExcel_Click);
            // 
            // rdoFilterRegsiterDate
            // 
            this.rdoFilterRegsiterDate.Location = new System.Drawing.Point(232, 176);
            this.rdoFilterRegsiterDate.Name = "rdoFilterRegsiterDate";
            this.rdoFilterRegsiterDate.Size = new System.Drawing.Size(116, 18);
            this.rdoFilterRegsiterDate.TabIndex = 7;
            this.rdoFilterRegsiterDate.Text = "Filter Register Date";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRegister);
            this.tabPage2.Controls.Add(this.txtPasswordRegister);
            this.tabPage2.Controls.Add(this.radLabel7);
            this.tabPage2.Controls.Add(this.txtUserNameRegister);
            this.tabPage2.Controls.Add(this.radLabel6);
            this.tabPage2.Controls.Add(this.txtGenderRegister);
            this.tabPage2.Controls.Add(this.radLabel4);
            this.tabPage2.Controls.Add(this.txtAge);
            this.tabPage2.Controls.Add(this.radLabel3);
            this.tabPage2.Controls.Add(this.txtFamily);
            this.tabPage2.Controls.Add(this.lblFamily);
            this.tabPage2.Controls.Add(this.txtFirstName);
            this.tabPage2.Controls.Add(this.lblFirstName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(857, 311);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(18, 230);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(146, 41);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtPasswordRegister
            // 
            this.txtPasswordRegister.Location = new System.Drawing.Point(341, 57);
            this.txtPasswordRegister.Name = "txtPasswordRegister";
            this.txtPasswordRegister.Size = new System.Drawing.Size(152, 24);
            this.txtPasswordRegister.TabIndex = 3;
            // 
            // radLabel7
            // 
            this.radLabel7.Location = new System.Drawing.Point(268, 58);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(59, 18);
            this.radLabel7.TabIndex = 2;
            this.radLabel7.Text = "Password :";
            // 
            // txtUserNameRegister
            // 
            this.txtUserNameRegister.Location = new System.Drawing.Point(341, 20);
            this.txtUserNameRegister.Name = "txtUserNameRegister";
            this.txtUserNameRegister.Size = new System.Drawing.Size(152, 24);
            this.txtUserNameRegister.TabIndex = 3;
            // 
            // radLabel6
            // 
            this.radLabel6.Location = new System.Drawing.Point(268, 21);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(67, 18);
            this.radLabel6.TabIndex = 2;
            this.radLabel6.Text = "User Name :";
            // 
            // txtGenderRegister
            // 
            this.txtGenderRegister.Location = new System.Drawing.Point(90, 145);
            this.txtGenderRegister.Name = "txtGenderRegister";
            this.txtGenderRegister.Size = new System.Drawing.Size(152, 24);
            this.txtGenderRegister.TabIndex = 3;
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(18, 145);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(48, 18);
            this.radLabel4.TabIndex = 2;
            this.radLabel4.Text = "Gender :";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(90, 101);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(152, 24);
            this.txtAge.TabIndex = 3;
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(18, 102);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(32, 18);
            this.radLabel3.TabIndex = 2;
            this.radLabel3.Text = "Age :";
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(90, 57);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(152, 24);
            this.txtFamily.TabIndex = 3;
            // 
            // lblFamily
            // 
            this.lblFamily.Location = new System.Drawing.Point(18, 58);
            this.lblFamily.Name = "lblFamily";
            this.lblFamily.Size = new System.Drawing.Size(44, 18);
            this.lblFamily.TabIndex = 2;
            this.lblFamily.Text = "Family :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(90, 19);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(152, 24);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(18, 20);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(66, 18);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name :";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.radChart);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(857, 311);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // radChart
            // 
            this.radChart.AreaDesign = cartesianArea1;
            categoricalAxis1.IsPrimary = true;
            linearAxis1.AxisType = Telerik.Charting.AxisType.Second;
            linearAxis1.IsPrimary = true;
            linearAxis1.TickOrigin = null;
            this.radChart.Axes.AddRange(new Telerik.WinControls.UI.Axis[] {
            categoricalAxis1,
            linearAxis1});
            this.radChart.Location = new System.Drawing.Point(6, 3);
            this.radChart.Name = "radChart";
            barSeries1.HorizontalAxis = categoricalAxis1;
            barSeries1.VerticalAxis = linearAxis1;
            this.radChart.Series.AddRange(new Telerik.WinControls.UI.ChartSeries[] {
            barSeries1});
            this.radChart.ShowGrid = false;
            this.radChart.Size = new System.Drawing.Size(480, 302);
            this.radChart.TabIndex = 0;
            // 
            // database_planarDataSet
            // 
            this.database_planarDataSet.DataSetName = "database_planarDataSet";
            this.database_planarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tilecalibregradeBindingSource
            // 
            this.tilecalibregradeBindingSource.DataMember = "tile_calibre_grade";
            this.tilecalibregradeBindingSource.DataSource = this.database_planarDataSet;
            // 
            // tile_calibre_gradeTableAdapter
            // 
            this.tile_calibre_gradeTableAdapter.ClearBeforeFill = true;
            // 
            // RadForm1
            // 
            this.ClientSize = new System.Drawing.Size(888, 360);
            this.Controls.Add(this.tabRegisterUser);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Load += new System.EventHandler(this.RadForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFilteGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilterAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFilterAge)).EndInit();
            this.tabRegisterUser.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExpotExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoFilterRegsiterDate)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserNameRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGenderRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFamily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFamily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFirstName)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_planarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tilecalibregradeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Family;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegisterDate;
        private Telerik.WinControls.UI.RadButton radButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private Telerik.WinControls.UI.RadLabel lblFilteGender;
        private Telerik.WinControls.UI.RadTextBox txtGender;
        private Telerik.WinControls.UI.RadButton btnFilter;
        private Telerik.WinControls.UI.RadTextBox txtFilterAge;
        private Telerik.WinControls.UI.RadLabel lblFilterAge;
        private Telerik.WinControls.UI.RadLabel lblFirstName;
        private Telerik.WinControls.UI.RadTextBox txtFirstName;
        private System.Windows.Forms.TabControl tabRegisterUser;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Telerik.WinControls.UI.RadTextBox txtPasswordRegister;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadTextBox txtUserNameRegister;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadTextBox txtGenderRegister;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadTextBox txtAge;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox txtFamily;
        private Telerik.WinControls.UI.RadLabel lblFamily;
        private Telerik.WinControls.UI.RadButton btnRegister;
        private Telerik.WinControls.UI.RadRadioButton rdoFilterRegsiterDate;
        private Telerik.WinControls.UI.RadButton btnExpotExcel;
        private System.Windows.Forms.TabPage tabPage3;
        private Telerik.WinControls.UI.RadChartView radChart;
        private database_planarDataSet database_planarDataSet;
        private System.Windows.Forms.BindingSource tilecalibregradeBindingSource;
        private database_planarDataSetTableAdapters.tile_calibre_gradeTableAdapter tile_calibre_gradeTableAdapter;
    }
}