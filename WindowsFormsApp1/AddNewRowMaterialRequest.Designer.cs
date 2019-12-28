namespace WindowsFormsApp1
{
	partial class AddNewRowMaterialRequest
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
			this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxAmount = new System.Windows.Forms.TextBox();
			this.textBoxUnit = new System.Windows.Forms.TextBox();
			this.btn_AddNewRowMaterial = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// comboBoxMaterial
			// 
			this.comboBoxMaterial.FormattingEnabled = true;
			this.comboBoxMaterial.Location = new System.Drawing.Point(167, 64);
			this.comboBoxMaterial.Name = "comboBoxMaterial";
			this.comboBoxMaterial.Size = new System.Drawing.Size(121, 21);
			this.comboBoxMaterial.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(101, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Материал:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(92, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Количество:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(49, 154);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Единица измерения:";
			// 
			// textBoxAmount
			// 
			this.textBoxAmount.Location = new System.Drawing.Point(167, 104);
			this.textBoxAmount.Name = "textBoxAmount";
			this.textBoxAmount.Size = new System.Drawing.Size(100, 20);
			this.textBoxAmount.TabIndex = 4;
			// 
			// textBoxUnit
			// 
			this.textBoxUnit.Location = new System.Drawing.Point(167, 151);
			this.textBoxUnit.Name = "textBoxUnit";
			this.textBoxUnit.Size = new System.Drawing.Size(100, 20);
			this.textBoxUnit.TabIndex = 5;
			// 
			// btn_AddNewRowMaterial
			// 
			this.btn_AddNewRowMaterial.Location = new System.Drawing.Point(226, 217);
			this.btn_AddNewRowMaterial.Name = "btn_AddNewRowMaterial";
			this.btn_AddNewRowMaterial.Size = new System.Drawing.Size(75, 23);
			this.btn_AddNewRowMaterial.TabIndex = 6;
			this.btn_AddNewRowMaterial.Text = "Добавить ";
			this.btn_AddNewRowMaterial.UseVisualStyleBackColor = true;
			this.btn_AddNewRowMaterial.Click += new System.EventHandler(this.btn_AddNewRowMaterial_Click);
			// 
			// AddNewRowMaterialRequest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(704, 392);
			this.Controls.Add(this.btn_AddNewRowMaterial);
			this.Controls.Add(this.textBoxUnit);
			this.Controls.Add(this.textBoxAmount);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBoxMaterial);
			this.Name = "AddNewRowMaterialRequest";
			this.Text = "AddNewRowMaterialRequest";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddNewRowMaterialRequest_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxMaterial;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxAmount;
		private System.Windows.Forms.TextBox textBoxUnit;
		private System.Windows.Forms.Button btn_AddNewRowMaterial;
	}
}