namespace ManagementSystem
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            SidebarPanel = new Panel();
            SidebarControlsPanel = new Panel();
            SidebarContrrolsTableLayout = new TableLayoutPanel();
            ViewEmployeesBtn = new Button();
            RemoveEmployeeBtn = new Button();
            AddEmployeeBtn = new Button();
            SearchEmployeeBtn = new Button();
            button2 = new Button();
            AdminNameLabel = new Label();
            AdminLabel = new Label();
            LogoutBtn = new Button();
            ContentPanel = new Panel();
            SearchEmployeePanel = new Panel();
            SearchButton = new Button();
            EnterEmployeeNameText = new Label();
            EmployeeSalarySearchText = new Label();
            EmployeeEmailSearchText = new Label();
            EmployeeRoleSearchText = new Label();
            EmployeeIdSearchText = new Label();
            EmployeeIdSearchTB = new TextBox();
            EmployeeSalarySearchTB = new TextBox();
            EmployeeEmailSearchTB = new TextBox();
            EmployeeRoleSearchTB = new TextBox();
            SearchEmployeeText = new Label();
            EnterEmployeeNameTB = new TextBox();
            RemoveEmployeePanel = new Panel();
            RemoveEmployeeSubmitBtn = new Button();
            label10 = new Label();
            label11 = new Label();
            RemoveEmployeeIdTB = new TextBox();
            ViewEmployeesPanel = new Panel();
            AddEmployeePanel = new Panel();
            AddEmployeeSubmitBtn = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            EmployeeSalaryTB = new TextBox();
            EmployeeRoleTB = new TextBox();
            EmployeeNameTB = new TextBox();
            EmployeeEmailTB = new TextBox();
            ViewEmployeesDataGrid = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            SidebarPanel.SuspendLayout();
            SidebarControlsPanel.SuspendLayout();
            SidebarContrrolsTableLayout.SuspendLayout();
            ContentPanel.SuspendLayout();
            SearchEmployeePanel.SuspendLayout();
            RemoveEmployeePanel.SuspendLayout();
            ViewEmployeesPanel.SuspendLayout();
            AddEmployeePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ViewEmployeesDataGrid).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // SidebarPanel
            // 
            SidebarPanel.BackColor = Color.FromArgb(29, 29, 65);
            SidebarPanel.Controls.Add(SidebarControlsPanel);
            SidebarPanel.Controls.Add(AdminNameLabel);
            SidebarPanel.Controls.Add(AdminLabel);
            SidebarPanel.Controls.Add(LogoutBtn);
            SidebarPanel.Dock = DockStyle.Left;
            SidebarPanel.Location = new Point(0, 0);
            SidebarPanel.Name = "SidebarPanel";
            SidebarPanel.Size = new Size(267, 550);
            SidebarPanel.TabIndex = 0;
            // 
            // SidebarControlsPanel
            // 
            SidebarControlsPanel.BackColor = Color.FromArgb(39, 39, 75);
            SidebarControlsPanel.Controls.Add(SidebarContrrolsTableLayout);
            SidebarControlsPanel.Controls.Add(button2);
            SidebarControlsPanel.Location = new Point(0, 87);
            SidebarControlsPanel.Name = "SidebarControlsPanel";
            SidebarControlsPanel.Size = new Size(267, 463);
            SidebarControlsPanel.TabIndex = 8;
            // 
            // SidebarContrrolsTableLayout
            // 
            SidebarContrrolsTableLayout.ColumnCount = 1;
            SidebarContrrolsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            SidebarContrrolsTableLayout.Controls.Add(ViewEmployeesBtn, 0, 0);
            SidebarContrrolsTableLayout.Controls.Add(RemoveEmployeeBtn, 0, 2);
            SidebarContrrolsTableLayout.Controls.Add(AddEmployeeBtn, 0, 1);
            SidebarContrrolsTableLayout.Controls.Add(SearchEmployeeBtn, 0, 3);
            SidebarContrrolsTableLayout.Dock = DockStyle.Left;
            SidebarContrrolsTableLayout.Location = new Point(0, 0);
            SidebarContrrolsTableLayout.Name = "SidebarContrrolsTableLayout";
            SidebarContrrolsTableLayout.RowCount = 4;
            SidebarContrrolsTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            SidebarContrrolsTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            SidebarContrrolsTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            SidebarContrrolsTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            SidebarContrrolsTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            SidebarContrrolsTableLayout.Size = new Size(267, 463);
            SidebarContrrolsTableLayout.TabIndex = 9;
            // 
            // ViewEmployeesBtn
            // 
            ViewEmployeesBtn.FlatAppearance.BorderSize = 0;
            ViewEmployeesBtn.FlatStyle = FlatStyle.Flat;
            ViewEmployeesBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ViewEmployeesBtn.ForeColor = Color.White;
            ViewEmployeesBtn.Location = new Point(3, 3);
            ViewEmployeesBtn.Name = "ViewEmployeesBtn";
            ViewEmployeesBtn.Size = new Size(261, 86);
            ViewEmployeesBtn.TabIndex = 9;
            ViewEmployeesBtn.Text = "View Employees";
            ViewEmployeesBtn.UseVisualStyleBackColor = true;
            ViewEmployeesBtn.Click += ViewEmployeesBtn_Click;
            // 
            // RemoveEmployeeBtn
            // 
            RemoveEmployeeBtn.FlatAppearance.BorderSize = 0;
            RemoveEmployeeBtn.FlatStyle = FlatStyle.Flat;
            RemoveEmployeeBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            RemoveEmployeeBtn.ForeColor = Color.White;
            RemoveEmployeeBtn.Location = new Point(3, 233);
            RemoveEmployeeBtn.Name = "RemoveEmployeeBtn";
            RemoveEmployeeBtn.Size = new Size(261, 86);
            RemoveEmployeeBtn.TabIndex = 6;
            RemoveEmployeeBtn.Text = "Remove Employee";
            RemoveEmployeeBtn.UseVisualStyleBackColor = true;
            RemoveEmployeeBtn.Click += RemoveEmployeeBtn_Click;
            // 
            // AddEmployeeBtn
            // 
            AddEmployeeBtn.FlatAppearance.BorderSize = 0;
            AddEmployeeBtn.FlatStyle = FlatStyle.Flat;
            AddEmployeeBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            AddEmployeeBtn.ForeColor = Color.White;
            AddEmployeeBtn.Location = new Point(3, 118);
            AddEmployeeBtn.Name = "AddEmployeeBtn";
            AddEmployeeBtn.Size = new Size(261, 86);
            AddEmployeeBtn.TabIndex = 5;
            AddEmployeeBtn.Text = "Add Employee";
            AddEmployeeBtn.UseVisualStyleBackColor = true;
            AddEmployeeBtn.Click += AddEmployeeBtn_Click;
            // 
            // SearchEmployeeBtn
            // 
            SearchEmployeeBtn.FlatAppearance.BorderSize = 0;
            SearchEmployeeBtn.FlatStyle = FlatStyle.Flat;
            SearchEmployeeBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            SearchEmployeeBtn.ForeColor = Color.White;
            SearchEmployeeBtn.Location = new Point(3, 348);
            SearchEmployeeBtn.Name = "SearchEmployeeBtn";
            SearchEmployeeBtn.Size = new Size(261, 86);
            SearchEmployeeBtn.TabIndex = 7;
            SearchEmployeeBtn.Text = "Search Employee";
            SearchEmployeeBtn.UseVisualStyleBackColor = true;
            SearchEmployeeBtn.Click += SearchEmployeeBtn_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(39, 39, 75);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(3, 69);
            button2.Name = "button2";
            button2.Size = new Size(267, 42);
            button2.TabIndex = 4;
            button2.Text = "View Employees";
            button2.UseVisualStyleBackColor = false;
            // 
            // AdminNameLabel
            // 
            AdminNameLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AdminNameLabel.AutoSize = true;
            AdminNameLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            AdminNameLabel.ForeColor = Color.White;
            AdminNameLabel.Location = new Point(14, 43);
            AdminNameLabel.Name = "AdminNameLabel";
            AdminNameLabel.Size = new Size(106, 20);
            AdminNameLabel.TabIndex = 1;
            AdminNameLabel.Text = "Huseyin Gedes";
            // 
            // AdminLabel
            // 
            AdminLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AdminLabel.AutoSize = true;
            AdminLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            AdminLabel.ForeColor = Color.Firebrick;
            AdminLabel.Location = new Point(12, 18);
            AdminLabel.Name = "AdminLabel";
            AdminLabel.Size = new Size(92, 25);
            AdminLabel.TabIndex = 0;
            AdminLabel.Text = "[ADMIN]";
            AdminLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackgroundImage = (Image)resources.GetObject("LogoutBtn.BackgroundImage");
            LogoutBtn.BackgroundImageLayout = ImageLayout.Stretch;
            LogoutBtn.FlatAppearance.BorderSize = 0;
            LogoutBtn.FlatStyle = FlatStyle.Flat;
            LogoutBtn.Location = new Point(217, 26);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(29, 34);
            LogoutBtn.TabIndex = 3;
            LogoutBtn.UseVisualStyleBackColor = true;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // ContentPanel
            // 
            ContentPanel.BackColor = Color.FromArgb(248, 248, 248);
            ContentPanel.Controls.Add(SearchEmployeePanel);
            ContentPanel.Controls.Add(RemoveEmployeePanel);
            ContentPanel.Controls.Add(ViewEmployeesPanel);
            ContentPanel.Dock = DockStyle.Fill;
            ContentPanel.Location = new Point(267, 0);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(761, 550);
            ContentPanel.TabIndex = 1;
            // 
            // SearchEmployeePanel
            // 
            SearchEmployeePanel.BackColor = Color.DarkGray;
            SearchEmployeePanel.Controls.Add(SearchButton);
            SearchEmployeePanel.Controls.Add(EnterEmployeeNameText);
            SearchEmployeePanel.Controls.Add(EmployeeSalarySearchText);
            SearchEmployeePanel.Controls.Add(EmployeeEmailSearchText);
            SearchEmployeePanel.Controls.Add(EmployeeRoleSearchText);
            SearchEmployeePanel.Controls.Add(EmployeeIdSearchText);
            SearchEmployeePanel.Controls.Add(EmployeeIdSearchTB);
            SearchEmployeePanel.Controls.Add(EmployeeSalarySearchTB);
            SearchEmployeePanel.Controls.Add(EmployeeEmailSearchTB);
            SearchEmployeePanel.Controls.Add(EmployeeRoleSearchTB);
            SearchEmployeePanel.Controls.Add(SearchEmployeeText);
            SearchEmployeePanel.Controls.Add(EnterEmployeeNameTB);
            SearchEmployeePanel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SearchEmployeePanel.Location = new Point(66, 61);
            SearchEmployeePanel.Name = "SearchEmployeePanel";
            SearchEmployeePanel.Size = new Size(647, 425);
            SearchEmployeePanel.TabIndex = 10;
            // 
            // SearchButton
            // 
            SearchButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            SearchButton.Location = new Point(373, 121);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(206, 42);
            SearchButton.TabIndex = 10;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // EnterEmployeeNameText
            // 
            EnterEmployeeNameText.AutoSize = true;
            EnterEmployeeNameText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            EnterEmployeeNameText.Location = new Point(50, 99);
            EnterEmployeeNameText.Name = "EnterEmployeeNameText";
            EnterEmployeeNameText.Size = new Size(198, 25);
            EnterEmployeeNameText.TabIndex = 15;
            EnterEmployeeNameText.Text = "Enter Employee Name";
            // 
            // EmployeeSalarySearchText
            // 
            EmployeeSalarySearchText.AutoSize = true;
            EmployeeSalarySearchText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeSalarySearchText.Location = new Point(373, 290);
            EmployeeSalarySearchText.Name = "EmployeeSalarySearchText";
            EmployeeSalarySearchText.Size = new Size(125, 21);
            EmployeeSalarySearchText.TabIndex = 13;
            EmployeeSalarySearchText.Text = "Employee Salary";
            // 
            // EmployeeEmailSearchText
            // 
            EmployeeEmailSearchText.AutoSize = true;
            EmployeeEmailSearchText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeEmailSearchText.Location = new Point(50, 290);
            EmployeeEmailSearchText.Name = "EmployeeEmailSearchText";
            EmployeeEmailSearchText.Size = new Size(120, 21);
            EmployeeEmailSearchText.TabIndex = 12;
            EmployeeEmailSearchText.Text = "Employee Email";
            // 
            // EmployeeRoleSearchText
            // 
            EmployeeRoleSearchText.AutoSize = true;
            EmployeeRoleSearchText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeRoleSearchText.Location = new Point(373, 190);
            EmployeeRoleSearchText.Name = "EmployeeRoleSearchText";
            EmployeeRoleSearchText.Size = new Size(113, 21);
            EmployeeRoleSearchText.TabIndex = 11;
            EmployeeRoleSearchText.Text = "Employee Role";
            // 
            // EmployeeIdSearchText
            // 
            EmployeeIdSearchText.AutoSize = true;
            EmployeeIdSearchText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeIdSearchText.Location = new Point(50, 190);
            EmployeeIdSearchText.Name = "EmployeeIdSearchText";
            EmployeeIdSearchText.Size = new Size(97, 21);
            EmployeeIdSearchText.TabIndex = 10;
            EmployeeIdSearchText.Text = "Employee ID";
            // 
            // EmployeeIdSearchTB
            // 
            EmployeeIdSearchTB.Enabled = false;
            EmployeeIdSearchTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeIdSearchTB.Location = new Point(50, 217);
            EmployeeIdSearchTB.Name = "EmployeeIdSearchTB";
            EmployeeIdSearchTB.Size = new Size(204, 29);
            EmployeeIdSearchTB.TabIndex = 9;
            EmployeeIdSearchTB.TextAlign = HorizontalAlignment.Center;
            // 
            // EmployeeSalarySearchTB
            // 
            EmployeeSalarySearchTB.Enabled = false;
            EmployeeSalarySearchTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeSalarySearchTB.Location = new Point(373, 317);
            EmployeeSalarySearchTB.Name = "EmployeeSalarySearchTB";
            EmployeeSalarySearchTB.Size = new Size(204, 29);
            EmployeeSalarySearchTB.TabIndex = 8;
            EmployeeSalarySearchTB.TextAlign = HorizontalAlignment.Center;
            // 
            // EmployeeEmailSearchTB
            // 
            EmployeeEmailSearchTB.Enabled = false;
            EmployeeEmailSearchTB.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeEmailSearchTB.Location = new Point(50, 317);
            EmployeeEmailSearchTB.Name = "EmployeeEmailSearchTB";
            EmployeeEmailSearchTB.Size = new Size(204, 27);
            EmployeeEmailSearchTB.TabIndex = 7;
            EmployeeEmailSearchTB.TextAlign = HorizontalAlignment.Center;
            // 
            // EmployeeRoleSearchTB
            // 
            EmployeeRoleSearchTB.Enabled = false;
            EmployeeRoleSearchTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeRoleSearchTB.Location = new Point(373, 217);
            EmployeeRoleSearchTB.Name = "EmployeeRoleSearchTB";
            EmployeeRoleSearchTB.Size = new Size(204, 29);
            EmployeeRoleSearchTB.TabIndex = 6;
            EmployeeRoleSearchTB.TextAlign = HorizontalAlignment.Center;
            // 
            // SearchEmployeeText
            // 
            SearchEmployeeText.AutoSize = true;
            SearchEmployeeText.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            SearchEmployeeText.Location = new Point(215, 26);
            SearchEmployeeText.Name = "SearchEmployeeText";
            SearchEmployeeText.Size = new Size(207, 32);
            SearchEmployeeText.TabIndex = 4;
            SearchEmployeeText.Text = "Search Employee";
            // 
            // EnterEmployeeNameTB
            // 
            EnterEmployeeNameTB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            EnterEmployeeNameTB.Location = new Point(50, 130);
            EnterEmployeeNameTB.Name = "EnterEmployeeNameTB";
            EnterEmployeeNameTB.Size = new Size(204, 33);
            EnterEmployeeNameTB.TabIndex = 1;
            EnterEmployeeNameTB.TextAlign = HorizontalAlignment.Center;
            // 
            // RemoveEmployeePanel
            // 
            RemoveEmployeePanel.BackColor = Color.DarkGray;
            RemoveEmployeePanel.Controls.Add(RemoveEmployeeSubmitBtn);
            RemoveEmployeePanel.Controls.Add(label10);
            RemoveEmployeePanel.Controls.Add(label11);
            RemoveEmployeePanel.Controls.Add(RemoveEmployeeIdTB);
            RemoveEmployeePanel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveEmployeePanel.Location = new Point(66, 61);
            RemoveEmployeePanel.Name = "RemoveEmployeePanel";
            RemoveEmployeePanel.Size = new Size(647, 425);
            RemoveEmployeePanel.TabIndex = 11;
            // 
            // RemoveEmployeeSubmitBtn
            // 
            RemoveEmployeeSubmitBtn.Location = new Point(222, 296);
            RemoveEmployeeSubmitBtn.Name = "RemoveEmployeeSubmitBtn";
            RemoveEmployeeSubmitBtn.Size = new Size(206, 58);
            RemoveEmployeeSubmitBtn.TabIndex = 9;
            RemoveEmployeeSubmitBtn.Text = "Submit";
            RemoveEmployeeSubmitBtn.UseVisualStyleBackColor = true;
            RemoveEmployeeSubmitBtn.Click += RemoveEmployeeSubmitBtn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(249, 153);
            label10.Name = "label10";
            label10.Size = new Size(164, 25);
            label10.TabIndex = 5;
            label10.Text = "Enter Employee Id";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(215, 26);
            label11.Name = "label11";
            label11.Size = new Size(223, 32);
            label11.TabIndex = 4;
            label11.Text = "Remove Employee";
            // 
            // RemoveEmployeeIdTB
            // 
            RemoveEmployeeIdTB.Location = new Point(224, 181);
            RemoveEmployeeIdTB.Name = "RemoveEmployeeIdTB";
            RemoveEmployeeIdTB.Size = new Size(204, 39);
            RemoveEmployeeIdTB.TabIndex = 1;
            RemoveEmployeeIdTB.TextAlign = HorizontalAlignment.Center;
            // 
            // ViewEmployeesPanel
            // 
            ViewEmployeesPanel.BackColor = Color.White;
            ViewEmployeesPanel.Controls.Add(AddEmployeePanel);
            ViewEmployeesPanel.Controls.Add(ViewEmployeesDataGrid);
            ViewEmployeesPanel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ViewEmployeesPanel.Location = new Point(66, 63);
            ViewEmployeesPanel.Name = "ViewEmployeesPanel";
            ViewEmployeesPanel.Size = new Size(645, 423);
            ViewEmployeesPanel.TabIndex = 0;
            // 
            // AddEmployeePanel
            // 
            AddEmployeePanel.BackColor = Color.DarkGray;
            AddEmployeePanel.Controls.Add(AddEmployeeSubmitBtn);
            AddEmployeePanel.Controls.Add(label9);
            AddEmployeePanel.Controls.Add(label8);
            AddEmployeePanel.Controls.Add(label7);
            AddEmployeePanel.Controls.Add(label6);
            AddEmployeePanel.Controls.Add(label5);
            AddEmployeePanel.Controls.Add(EmployeeSalaryTB);
            AddEmployeePanel.Controls.Add(EmployeeRoleTB);
            AddEmployeePanel.Controls.Add(EmployeeNameTB);
            AddEmployeePanel.Controls.Add(EmployeeEmailTB);
            AddEmployeePanel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            AddEmployeePanel.Location = new Point(-2, -2);
            AddEmployeePanel.Name = "AddEmployeePanel";
            AddEmployeePanel.Size = new Size(647, 425);
            AddEmployeePanel.TabIndex = 1;
            // 
            // AddEmployeeSubmitBtn
            // 
            AddEmployeeSubmitBtn.Location = new Point(224, 333);
            AddEmployeeSubmitBtn.Name = "AddEmployeeSubmitBtn";
            AddEmployeeSubmitBtn.Size = new Size(206, 58);
            AddEmployeeSubmitBtn.TabIndex = 9;
            AddEmployeeSubmitBtn.Text = "Submit";
            AddEmployeeSubmitBtn.UseVisualStyleBackColor = true;
            AddEmployeeSubmitBtn.Click += AddEmployeeSubmitBtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(392, 91);
            label9.Name = "label9";
            label9.Size = new Size(48, 25);
            label9.TabIndex = 8;
            label9.Text = "Role";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(392, 226);
            label8.Name = "label8";
            label8.Size = new Size(63, 25);
            label8.TabIndex = 7;
            label8.Text = "Salary";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(86, 226);
            label7.Name = "label7";
            label7.Size = new Size(58, 25);
            label7.TabIndex = 6;
            label7.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(86, 90);
            label6.Name = "label6";
            label6.Size = new Size(62, 25);
            label6.TabIndex = 5;
            label6.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(251, 26);
            label5.Name = "label5";
            label5.Size = new Size(179, 32);
            label5.TabIndex = 4;
            label5.Text = "Add Employee";
            // 
            // EmployeeSalaryTB
            // 
            EmployeeSalaryTB.Location = new Point(392, 254);
            EmployeeSalaryTB.Name = "EmployeeSalaryTB";
            EmployeeSalaryTB.Size = new Size(187, 39);
            EmployeeSalaryTB.TabIndex = 3;
            EmployeeSalaryTB.TextAlign = HorizontalAlignment.Center;
            // 
            // EmployeeRoleTB
            // 
            EmployeeRoleTB.Location = new Point(392, 121);
            EmployeeRoleTB.Name = "EmployeeRoleTB";
            EmployeeRoleTB.Size = new Size(187, 39);
            EmployeeRoleTB.TabIndex = 2;
            EmployeeRoleTB.TextAlign = HorizontalAlignment.Center;
            // 
            // EmployeeNameTB
            // 
            EmployeeNameTB.Location = new Point(86, 121);
            EmployeeNameTB.Name = "EmployeeNameTB";
            EmployeeNameTB.Size = new Size(187, 39);
            EmployeeNameTB.TabIndex = 1;
            EmployeeNameTB.TextAlign = HorizontalAlignment.Center;
            // 
            // EmployeeEmailTB
            // 
            EmployeeEmailTB.Location = new Point(86, 254);
            EmployeeEmailTB.Name = "EmployeeEmailTB";
            EmployeeEmailTB.Size = new Size(187, 39);
            EmployeeEmailTB.TabIndex = 0;
            EmployeeEmailTB.TextAlign = HorizontalAlignment.Center;
            // 
            // ViewEmployeesDataGrid
            // 
            ViewEmployeesDataGrid.Anchor = AnchorStyles.None;
            ViewEmployeesDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewEmployeesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewEmployeesDataGrid.Location = new Point(0, 0);
            ViewEmployeesDataGrid.Name = "ViewEmployeesDataGrid";
            ViewEmployeesDataGrid.RowTemplate.Height = 25;
            ViewEmployeesDataGrid.Size = new Size(645, 423);
            ViewEmployeesDataGrid.TabIndex = 0;
            ViewEmployeesDataGrid.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 50);
            label1.Name = "label1";
            label1.Size = new Size(194, 20);
            label1.TabIndex = 1;
            label1.Text = "James Walsh";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(194, 25);
            label2.TabIndex = 0;
            label2.Text = "-= [ADMIN] =-";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 50);
            label3.Name = "label3";
            label3.Size = new Size(194, 20);
            label3.TabIndex = 1;
            label3.Text = "James Walsh";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(194, 25);
            label4.TabIndex = 0;
            label4.Text = "-= [ADMIN] =-";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1028, 550);
            Controls.Add(ContentPanel);
            Controls.Add(SidebarPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuForm";
            Text = "Management System";
            SidebarPanel.ResumeLayout(false);
            SidebarPanel.PerformLayout();
            SidebarControlsPanel.ResumeLayout(false);
            SidebarContrrolsTableLayout.ResumeLayout(false);
            ContentPanel.ResumeLayout(false);
            SearchEmployeePanel.ResumeLayout(false);
            SearchEmployeePanel.PerformLayout();
            RemoveEmployeePanel.ResumeLayout(false);
            RemoveEmployeePanel.PerformLayout();
            ViewEmployeesPanel.ResumeLayout(false);
            AddEmployeePanel.ResumeLayout(false);
            AddEmployeePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ViewEmployeesDataGrid).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel SidebarPanel;
        private Panel ContentPanel;
        private Label AdminLabel;
        private Label AdminNameLabel;
        private Panel ViewEmployeesPanel;
        private TableLayoutPanel HeaderTableTextLayout;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private Label label4;
        private Button AddEmployeeBtn;
        private Button button2;
        private Button LogoutBtn;
        private Panel SidebarControlsPanel;
        private Button RemoveEmployeeBtn;
        private Button SearchEmployeeBtn;
        private TableLayoutPanel SidebarContrrolsTableLayout;
        private Button ViewEmployeesBtn;
        private Label label5;
        private DataGridView ViewEmployeesDataGrid;
        private Panel AddEmployeePanel;
        private TextBox EmployeeSalaryTB;
        private TextBox EmployeeRoleTB;
        private TextBox EmployeeNameTB;
        private TextBox EmployeeEmailTB;
        private Button AddEmployeeSubmitBtn;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Panel SearchEmployeePanel;
        private Button RemoveEmployeeIdBtn;
        private Label EnterEmployeeIdText;
        private Label SearchEmployeeText;
        private TextBox EnterEmployeeNameTB;
        private Panel RemoveEmployeePanel;
        private Button RemoveEmployeeSubmitBtn;
        private Label label10;
        private Label label11;
        private TextBox RemoveEmployeeIdTB;
        private TextBox EmployeeRoleSearchTB;
        private TextBox EmployeeSalarySearchTB;
        private TextBox EmployeeEmailSearchTB;
        private Label EmployeeSalarySearchText;
        private Label EmployeeEmailSearchText;
        private Label EmployeeRoleSearchText;
        private Label EmployeeIdSearchText;
        private TextBox EmployeeIdSearchTB;
        private Label EnterEmployeeNameText;
        private Button SearchButton;
    }
}