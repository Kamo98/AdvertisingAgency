namespace WindowsFormsApp1
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.btnSignIn = new System.Windows.Forms.Button();
			this.textBoxLogin = new System.Windows.Forms.TextBox();
			this.textBoxPass = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.labelTest = new System.Windows.Forms.Label();
			this.panelAuthorization = new System.Windows.Forms.Panel();
			this.panelAuthorization.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Size = new System.Drawing.Size(931, 24);
			this.mainMenuStrip.TabIndex = 0;
			this.mainMenuStrip.Text = "menuStrip1";
			// 
			// btnSignIn
			// 
			this.btnSignIn.Location = new System.Drawing.Point(168, 179);
			this.btnSignIn.Name = "btnSignIn";
			this.btnSignIn.Size = new System.Drawing.Size(138, 26);
			this.btnSignIn.TabIndex = 1;
			this.btnSignIn.Text = "Авторизоваться";
			this.btnSignIn.UseVisualStyleBackColor = true;
			this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
			// 
			// textBoxLogin
			// 
			this.textBoxLogin.Location = new System.Drawing.Point(132, 57);
			this.textBoxLogin.Name = "textBoxLogin";
			this.textBoxLogin.Size = new System.Drawing.Size(264, 20);
			this.textBoxLogin.TabIndex = 2;
			this.textBoxLogin.Text = "Kamo98";
			// 
			// textBoxPass
			// 
			this.textBoxPass.Location = new System.Drawing.Point(132, 114);
			this.textBoxPass.Name = "textBoxPass";
			this.textBoxPass.Size = new System.Drawing.Size(264, 20);
			this.textBoxPass.TabIndex = 3;
			this.textBoxPass.Text = "Ntcnbhjdfybt_01";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(64, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Логин";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(64, 117);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Пароль";
			// 
			// labelTest
			// 
			this.labelTest.AutoSize = true;
			this.labelTest.Location = new System.Drawing.Point(966, 91);
			this.labelTest.Name = "labelTest";
			this.labelTest.Size = new System.Drawing.Size(0, 13);
			this.labelTest.TabIndex = 6;
			// 
			// panelAuthorization
			// 
			this.panelAuthorization.Controls.Add(this.label1);
			this.panelAuthorization.Controls.Add(this.btnSignIn);
			this.panelAuthorization.Controls.Add(this.label2);
			this.panelAuthorization.Controls.Add(this.textBoxLogin);
			this.panelAuthorization.Controls.Add(this.textBoxPass);
			this.panelAuthorization.Location = new System.Drawing.Point(225, 67);
			this.panelAuthorization.Name = "panelAuthorization";
			this.panelAuthorization.Size = new System.Drawing.Size(453, 264);
			this.panelAuthorization.TabIndex = 7;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(931, 427);
			this.Controls.Add(this.panelAuthorization);
			this.Controls.Add(this.labelTest);
			this.Controls.Add(this.mainMenuStrip);
			this.MainMenuStrip = this.mainMenuStrip;
			this.Name = "Form1";
			this.Text = "Advertising agency";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.panelAuthorization.ResumeLayout(false);
			this.panelAuthorization.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private System.Windows.Forms.MenuStrip mainMenuStrip;
		private System.Windows.Forms.Button btnSignIn;
		private System.Windows.Forms.TextBox textBoxLogin;
		private System.Windows.Forms.TextBox textBoxPass;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelTest;
		private System.Windows.Forms.Panel panelAuthorization;
	}
}

