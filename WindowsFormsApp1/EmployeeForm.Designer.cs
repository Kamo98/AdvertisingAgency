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
            this.secondNameInput = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // firstNameInput
            // 
            this.firstNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameInput.Location = new System.Drawing.Point(313, 69);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(271, 30);
            this.firstNameInput.TabIndex = 0;
            this.firstNameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // secondNameInput
            // 
            this.secondNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondNameInput.Location = new System.Drawing.Point(36, 69);
            this.secondNameInput.Name = "secondNameInput";
            this.secondNameInput.Size = new System.Drawing.Size(271, 30);
            this.secondNameInput.TabIndex = 0;
            this.secondNameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pathronymicInput
            // 
            this.pathronymicInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathronymicInput.Location = new System.Drawing.Point(590, 69);
            this.pathronymicInput.Name = "pathronymicInput";
            this.pathronymicInput.Size = new System.Drawing.Size(271, 30);
            this.pathronymicInput.TabIndex = 0;
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
            this.positionInput.TabIndex = 3;
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
            this.departmentComboBox.TabIndex = 4;
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
            this.acceptBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.acceptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acceptBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.acceptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acceptBtn.ForeColor = System.Drawing.Color.Black;
            this.acceptBtn.Location = new System.Drawing.Point(709, 294);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(152, 50);
            this.acceptBtn.TabIndex = 6;
            this.acceptBtn.Text = "Принять";
            this.acceptBtn.UseVisualStyleBackColor = false;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.LightCoral;
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.ForeColor = System.Drawing.Color.Black;
            this.cancelBtn.Location = new System.Drawing.Point(534, 294);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(152, 50);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Отменить";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(900, 400);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.departmentComboBox);
            this.Controls.Add(this.positionInput);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.pathronymicLabel);
            this.Controls.Add(this.secondNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.pathronymicInput);
            this.Controls.Add(this.secondNameInput);
            this.Controls.Add(this.firstNameInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameInput;
        private System.Windows.Forms.TextBox secondNameInput;
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
    }
}