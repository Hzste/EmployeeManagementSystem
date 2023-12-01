namespace ManagementSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            BackPanel = new Panel();
            LoginPanel = new Panel();
            SubmitBtn = new Button();
            PasswordPB = new PictureBox();
            TokenTB = new TextBox();
            LoginText = new Label();
            BackPanel.SuspendLayout();
            LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PasswordPB).BeginInit();
            SuspendLayout();
            // 
            // BackPanel
            // 
            BackPanel.BackColor = Color.Transparent;
            BackPanel.Controls.Add(LoginPanel);
            BackPanel.Dock = DockStyle.Fill;
            BackPanel.Location = new Point(0, 0);
            BackPanel.Name = "BackPanel";
            BackPanel.Size = new Size(1028, 550);
            BackPanel.TabIndex = 0;
            // 
            // LoginPanel
            // 
            LoginPanel.Anchor = AnchorStyles.None;
            LoginPanel.Controls.Add(SubmitBtn);
            LoginPanel.Controls.Add(PasswordPB);
            LoginPanel.Controls.Add(TokenTB);
            LoginPanel.Controls.Add(LoginText);
            LoginPanel.Location = new Point(308, 125);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(400, 300);
            LoginPanel.TabIndex = 0;
            // 
            // SubmitBtn
            // 
            SubmitBtn.BackColor = SystemColors.Highlight;
            SubmitBtn.FlatAppearance.BorderSize = 0;
            SubmitBtn.FlatStyle = FlatStyle.Flat;
            SubmitBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SubmitBtn.ForeColor = Color.White;
            SubmitBtn.Location = new Point(90, 141);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(237, 43);
            SubmitBtn.TabIndex = 3;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = false;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // PasswordPB
            // 
            PasswordPB.BackgroundImage = (Image)resources.GetObject("PasswordPB.BackgroundImage");
            PasswordPB.BackgroundImageLayout = ImageLayout.Zoom;
            PasswordPB.Location = new Point(56, 91);
            PasswordPB.Name = "PasswordPB";
            PasswordPB.Size = new Size(28, 25);
            PasswordPB.TabIndex = 2;
            PasswordPB.TabStop = false;
            // 
            // TokenTB
            // 
            TokenTB.Anchor = AnchorStyles.None;
            TokenTB.BorderStyle = BorderStyle.FixedSingle;
            TokenTB.Location = new Point(90, 91);
            TokenTB.MaxLength = 25;
            TokenTB.Name = "TokenTB";
            TokenTB.Size = new Size(241, 23);
            TokenTB.TabIndex = 1;
            TokenTB.TextAlign = HorizontalAlignment.Center;
            TokenTB.UseSystemPasswordChar = true;
            // 
            // LoginText
            // 
            LoginText.Anchor = AnchorStyles.None;
            LoginText.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LoginText.ForeColor = Color.White;
            LoginText.Location = new Point(85, 25);
            LoginText.Name = "LoginText";
            LoginText.Size = new Size(238, 45);
            LoginText.TabIndex = 0;
            LoginText.Text = "Enter Login Token";
            LoginText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1028, 550);
            Controls.Add(BackPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Text = "Management System";
            BackPanel.ResumeLayout(false);
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PasswordPB).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BackPanel;
        private Panel LoginPanel;
        private PictureBox PasswordPB;
        private TextBox TokenTB;
        private Label LoginText;
        private Button SubmitBtn;
    }
}