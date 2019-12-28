namespace WindowsFormsApp1
{
	partial class TypeOfProduct
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
			this.dataGridViewTypeProducts = new System.Windows.Forms.DataGridView();
			this.NameTypeProductColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonTyprMaterialUpdate = new System.Windows.Forms.Button();
			this.buttonTypeMaterialsSave = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypeProducts)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewTypeProducts
			// 
			this.dataGridViewTypeProducts.AllowUserToOrderColumns = true;
			this.dataGridViewTypeProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTypeProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameTypeProductColumn});
			this.dataGridViewTypeProducts.Location = new System.Drawing.Point(15, 64);
			this.dataGridViewTypeProducts.Name = "dataGridViewTypeProducts";
			this.dataGridViewTypeProducts.Size = new System.Drawing.Size(792, 344);
			this.dataGridViewTypeProducts.TabIndex = 2;
			// 
			// NameTypeProductColumn
			// 
			this.NameTypeProductColumn.HeaderText = "Тип продукта";
			this.NameTypeProductColumn.Name = "NameTypeProductColumn";
			// 
			// buttonTyprMaterialUpdate
			// 
			this.buttonTyprMaterialUpdate.Location = new System.Drawing.Point(651, 437);
			this.buttonTyprMaterialUpdate.Name = "buttonTyprMaterialUpdate";
			this.buttonTyprMaterialUpdate.Size = new System.Drawing.Size(75, 23);
			this.buttonTyprMaterialUpdate.TabIndex = 6;
			this.buttonTyprMaterialUpdate.Text = "Обновить";
			this.buttonTyprMaterialUpdate.UseVisualStyleBackColor = true;
			// 
			// buttonTypeMaterialsSave
			// 
			this.buttonTypeMaterialsSave.Location = new System.Drawing.Point(732, 437);
			this.buttonTypeMaterialsSave.Name = "buttonTypeMaterialsSave";
			this.buttonTypeMaterialsSave.Size = new System.Drawing.Size(75, 23);
			this.buttonTypeMaterialsSave.TabIndex = 5;
			this.buttonTypeMaterialsSave.Text = "Сохранить";
			this.buttonTypeMaterialsSave.UseVisualStyleBackColor = true;
			// 
			// TypeOfProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(822, 472);
			this.Controls.Add(this.buttonTyprMaterialUpdate);
			this.Controls.Add(this.buttonTypeMaterialsSave);
			this.Controls.Add(this.dataGridViewTypeProducts);
			this.Name = "TypeOfProduct";
			this.Text = "TypeOfProduct";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypeProducts)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewTypeProducts;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameTypeProductColumn;
		private System.Windows.Forms.Button buttonTyprMaterialUpdate;
		private System.Windows.Forms.Button buttonTypeMaterialsSave;
	}
}