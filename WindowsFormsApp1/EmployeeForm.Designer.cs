namespace WindowsFormsApp1
{
    partial class EmployeeForm
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
            this.firstNameInput = new System.Windows.Forms.TextBox();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.pathronymicInput = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.secondNameLabel = new System.Windows.Forms.Label();
            this.pathronymicLabel = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            this.positionInput = new System.Windows.Forms.TextBox();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PassLabel = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.chiefAgencyCheck = new System.Windows.Forms.CheckBox();
            this.chiefDepartmentCheck = new System.Windows.Forms.CheckBox();
            this.creativeOfficerCheck = new System.Windows.Forms.CheckBox();
            this.productionOfficerCheck = new System.Windows.Forms.CheckBox();
            this.mediaOfficerCheck = new System.Windows.Forms.CheckBox();
            this.customerRelationsOfficerCheck = new System.Windows.Forms.CheckBox();
            this.administratieOfficerCheck = new System.Windows.Forms.CheckBox();
            this.rolePanel = new System.Windows.Forms.Panel();
            this.BlockedFlag = new System.Windows.Forms.CheckBox();
            this.rolePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameInput
            // 
            this.firstNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameInput.Location = new System.Drawing.Point(313, 69);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(271, 30);
            this.firstNameInput.TabIndex = 1;
            this.firstNameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lastNameInput
            // 
            this.lastNameInput.BackColor = System.Drawing.SystemColors.Window;
            this.lastNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameInput.Location = new System.Drawing.Point(36, 69);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(271, 30);
            this.lastNameInput.TabIndex = 0;
            this.lastNameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pathronymicInput
            // 
            this.pathronymicInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathronymicInput.Location = new System.Drawing.Point(590, 69);
            this.pathronymicInput.Name = "pathronymicInput";
            this.pathronymicInput.Size = new System.Drawing.Size(271, 30);
            this.pathronymicInput.TabIndex = 2;
            this.pathronymicInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameLabel.Location = new System.Drawing.Point(425, 41);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(54, 25);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "Имя";
            // 
            // secondNameLabel
            // 
            this.secondNameLabel.AutoSize = true;
            this.secondNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondNameLabel.Location = new System.Drawing.Point(128, 41);
            this.secondNameLabel.Name = "secondNameLabel";
            this.secondNameLabel.Size = new System.Drawing.Size(103, 25);
            this.secondNameLabel.TabIndex = 1;
            this.secondNameLabel.Text = "Фамилия";
            // 
            // pathronymicLabel
            // 
            this.pathronymicLabel.AutoSize = true;
            this.pathronymicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathronymicLabel.Location = new System.Drawing.Point(690, 41);
            this.pathronymicLabel.Name = "pathronymicLabel";
            this.pathronymicLabel.Size = new System.Drawing.Size(104, 25);
            this.pathronymicLabel.TabIndex = 1;
            this.pathronymicLabel.Text = "Отчество";
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.positionLabel.Location = new System.Drawing.Point(405, 115);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(123, 25);
            this.positionLabel.TabIndex = 2;
            this.positionLabel.Text = "Должность";
            // 
            // positionInput
            // 
            this.positionInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.positionInput.Location = new System.Drawing.Point(36, 143);
            this.positionInput.Name = "positionInput";
            this.positionInput.Size = new System.Drawing.Size(825, 30);
            this.positionInput.TabIndex = 4;
            this.positionInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.departmentComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.departmentComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(36, 216);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(825, 33);
            this.departmentComboBox.TabIndex = 5;
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departmentLabel.Location = new System.Drawing.Point(423, 188);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(74, 25);
            this.departmentLabel.TabIndex = 5;
            this.departmentLabel.Text = "Отдел";
            // 
            // acceptBtn
            // 
            this.acceptBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.acceptBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.acceptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acceptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.acceptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acceptBtn.ForeColor = System.Drawing.Color.Black;
            this.acceptBtn.Location = new System.Drawing.Point(704, 554);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(152, 50);
            this.acceptBtn.TabIndex = 101;
            this.acceptBtn.Text = "Принять";
            this.acceptBtn.UseVisualStyleBackColor = false;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.BackColor = System.Drawing.Color.LightCoral;
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.ForeColor = System.Drawing.Color.Black;
            this.cancelBtn.Location = new System.Drawing.Point(529, 554);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(152, 50);
            this.cancelBtn.TabIndex = 100;
            this.cancelBtn.Text = "Отменить";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(423, 255);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(68, 25);
            this.LoginLabel.TabIndex = 2;
            this.LoginLabel.Text = "Логин";
            // 
            // LoginBox
            // 
            this.LoginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginBox.Location = new System.Drawing.Point(36, 283);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(825, 30);
            this.LoginBox.TabIndex = 6;
            this.LoginBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassLabel.Location = new System.Drawing.Point(417, 325);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(80, 25);
            this.PassLabel.TabIndex = 2;
            this.PassLabel.Text = "Пароль";
            // 
            // PassBox
            // 
            this.PassBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassBox.Location = new System.Drawing.Point(36, 353);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '*';
            this.PassBox.Size = new System.Drawing.Size(825, 30);
            this.PassBox.TabIndex = 7;
            this.PassBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoleLabel.Location = new System.Drawing.Point(433, 386);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(58, 25);
            this.RoleLabel.TabIndex = 5;
            this.RoleLabel.Text = "Роли";
            // 
            // chiefAgencyCheck
            // 
            this.chiefAgencyCheck.AutoSize = true;
            this.chiefAgencyCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chiefAgencyCheck.Location = new System.Drawing.Point(23, 3);
            this.chiefAgencyCheck.Name = "chiefAgencyCheck";
            this.chiefAgencyCheck.Size = new System.Drawing.Size(215, 24);
            this.chiefAgencyCheck.TabIndex = 0;
            this.chiefAgencyCheck.Text = "Начальник агентства";
            this.chiefAgencyCheck.UseVisualStyleBackColor = true;
            // 
            // chiefDepartmentCheck
            // 
            this.chiefDepartmentCheck.AutoSize = true;
            this.chiefDepartmentCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chiefDepartmentCheck.Location = new System.Drawing.Point(23, 30);
            this.chiefDepartmentCheck.Name = "chiefDepartmentCheck";
            this.chiefDepartmentCheck.Size = new System.Drawing.Size(190, 24);
            this.chiefDepartmentCheck.TabIndex = 1;
            this.chiefDepartmentCheck.Text = "Начальник отдела";
            this.chiefDepartmentCheck.UseVisualStyleBackColor = true;
            // 
            // creativeOfficerCheck
            // 
            this.creativeOfficerCheck.AutoSize = true;
            this.creativeOfficerCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.creativeOfficerCheck.Location = new System.Drawing.Point(23, 84);
            this.creativeOfficerCheck.Name = "creativeOfficerCheck";
            this.creativeOfficerCheck.Size = new System.Drawing.Size(255, 24);
            this.creativeOfficerCheck.TabIndex = 4;
            this.creativeOfficerCheck.Text = "Сотр. творческого отдела";
            this.creativeOfficerCheck.UseVisualStyleBackColor = true;
            // 
            // productionOfficerCheck
            // 
            this.productionOfficerCheck.AutoSize = true;
            this.productionOfficerCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productionOfficerCheck.Location = new System.Drawing.Point(468, 3);
            this.productionOfficerCheck.Name = "productionOfficerCheck";
            this.productionOfficerCheck.Size = new System.Drawing.Size(317, 24);
            this.productionOfficerCheck.TabIndex = 5;
            this.productionOfficerCheck.Text = "Сотр. производственного отдела";
            this.productionOfficerCheck.UseVisualStyleBackColor = true;
            // 
            // mediaOfficerCheck
            // 
            this.mediaOfficerCheck.AutoSize = true;
            this.mediaOfficerCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mediaOfficerCheck.Location = new System.Drawing.Point(468, 30);
            this.mediaOfficerCheck.Name = "mediaOfficerCheck";
            this.mediaOfficerCheck.Size = new System.Drawing.Size(241, 24);
            this.mediaOfficerCheck.TabIndex = 6;
            this.mediaOfficerCheck.Text = "Сотр. медийного отдела";
            this.mediaOfficerCheck.UseVisualStyleBackColor = true;
            // 
            // customerRelationsOfficerCheck
            // 
            this.customerRelationsOfficerCheck.AutoSize = true;
            this.customerRelationsOfficerCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerRelationsOfficerCheck.Location = new System.Drawing.Point(23, 57);
            this.customerRelationsOfficerCheck.Name = "customerRelationsOfficerCheck";
            this.customerRelationsOfficerCheck.Size = new System.Drawing.Size(344, 24);
            this.customerRelationsOfficerCheck.TabIndex = 3;
            this.customerRelationsOfficerCheck.Text = "Сотр. отдела по работе с клиентами";
            this.customerRelationsOfficerCheck.UseVisualStyleBackColor = true;
            // 
            // administratieOfficerCheck
            // 
            this.administratieOfficerCheck.AutoSize = true;
            this.administratieOfficerCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.administratieOfficerCheck.Location = new System.Drawing.Point(468, 57);
            this.administratieOfficerCheck.Name = "administratieOfficerCheck";
            this.administratieOfficerCheck.Size = new System.Drawing.Size(320, 24);
            this.administratieOfficerCheck.TabIndex = 7;
            this.administratieOfficerCheck.Text = "Сотр. административного отдела";
            this.administratieOfficerCheck.UseVisualStyleBackColor = true;
            // 
            // rolePanel
            // 
            this.rolePanel.BackColor = System.Drawing.SystemColors.Window;
            this.rolePanel.Controls.Add(this.administratieOfficerCheck);
            this.rolePanel.Controls.Add(this.customerRelationsOfficerCheck);
            this.rolePanel.Controls.Add(this.mediaOfficerCheck);
            this.rolePanel.Controls.Add(this.productionOfficerCheck);
            this.rolePanel.Controls.Add(this.creativeOfficerCheck);
            this.rolePanel.Controls.Add(this.chiefDepartmentCheck);
            this.rolePanel.Controls.Add(this.chiefAgencyCheck);
            this.rolePanel.Location = new System.Drawing.Point(36, 414);
            this.rolePanel.Name = "rolePanel";
            this.rolePanel.Size = new System.Drawing.Size(825, 110);
            this.rolePanel.TabIndex = 8;
            // 
            // BlockedFlag
            // 
            this.BlockedFlag.AutoSize = true;
            this.BlockedFlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BlockedFlag.Location = new System.Drawing.Point(36, 554);
            this.BlockedFlag.Name = "BlockedFlag";
            this.BlockedFlag.Size = new System.Drawing.Size(152, 24);
            this.BlockedFlag.TabIndex = 102;
            this.BlockedFlag.Text = "Заблокирован";
            this.BlockedFlag.UseVisualStyleBackColor = true;
            // 
            // EmployeeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(883, 634);
            this.Controls.Add(this.BlockedFlag);
            this.Controls.Add(this.rolePanel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.departmentComboBox);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.positionInput);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.pathronymicLabel);
            this.Controls.Add(this.secondNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.pathronymicInput);
            this.Controls.Add(this.lastNameInput);
            this.Controls.Add(this.firstNameInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EmployeeForm";
            this.rolePanel.ResumeLayout(false);
            this.rolePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameInput;
        private System.Windows.Forms.TextBox lastNameInput;
        private System.Windows.Forms.TextBox pathronymicInput;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label secondNameLabel;
        private System.Windows.Forms.Label pathronymicLabel;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.TextBox positionInput;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.CheckBox chiefAgencyCheck;
        private System.Windows.Forms.CheckBox chiefDepartmentCheck;
        private System.Windows.Forms.CheckBox creativeOfficerCheck;
        private System.Windows.Forms.CheckBox productionOfficerCheck;
        private System.Windows.Forms.CheckBox mediaOfficerCheck;
        private System.Windows.Forms.CheckBox customerRelationsOfficerCheck;
        private System.Windows.Forms.CheckBox administratieOfficerCheck;
        private System.Windows.Forms.Panel rolePanel;
        private System.Windows.Forms.CheckBox BlockedFlag;
    }
}