namespace WindowsFormsApp1
{
    partial class MaterialTypeForm
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
			this.dataGridViewTypeMaterials = new System.Windows.Forms.DataGridView();
			this.NameTypeMaterialColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonTyprMaterialUpdate = new System.Windows.Forms.Button();
			this.buttonTypeMaterialsSave = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypeMaterials)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewTypeMaterials
			// 
			this.dataGridViewTypeMaterials.AllowUserToOrderColumns = true;
			this.dataGridViewTypeMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTypeMaterials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameTypeMaterialColumn});
			this.dataGridViewTypeMaterials.Location = new System.Drawing.Point(4, 53);
			this.dataGridViewTypeMaterials.Name = "dataGridViewTypeMaterials";
			this.dataGridViewTypeMaterials.Size = new System.Drawing.Size(792, 344);
			this.dataGridViewTypeMaterials.TabIndex = 1;
			// 
			// NameTypeMaterialColumn
			// 
			this.NameTypeMaterialColumn.HeaderText = "Тип материала";
			this.NameTypeMaterialColumn.Name = "NameTypeMaterialColumn";
			// 
			// buttonTyprMaterialUpdate
			// 
			this.buttonTyprMaterialUpdate.Location = new System.Drawing.Point(632, 415);
			this.buttonTyprMaterialUpdate.Name = "buttonTyprMaterialUpdate";
			this.buttonTyprMaterialUpdate.Size = new System.Drawing.Size(75, 23);
			this.buttonTyprMaterialUpdate.TabIndex = 4;
			this.buttonTyprMaterialUpdate.Text = "Обновить";
			this.buttonTyprMaterialUpdate.UseVisualStyleBackColor = true;
			// 
			// buttonTypeMaterialsSave
			// 
			this.buttonTypeMaterialsSave.Location = new System.Drawing.Point(713, 415);
			this.buttonTypeMaterialsSave.Name = "buttonTypeMaterialsSave";
			this.buttonTypeMaterialsSave.Size = new System.Drawing.Size(75, 23);
			this.buttonTypeMaterialsSave.TabIndex = 3;
			this.buttonTypeMaterialsSave.Text = "Сохранить";
			this.buttonTypeMaterialsSave.UseVisualStyleBackColor = true;
			// 
			// MaterialTypeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonTyprMaterialUpdate);
			this.Controls.Add(this.buttonTypeMaterialsSave);
			this.Controls.Add(this.dataGridViewTypeMaterials);
			this.Name = "MaterialTypeForm";
			this.Text = "MaterialTypeForm";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypeMaterials)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewTypeMaterials;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameTypeMaterialColumn;
		private System.Windows.Forms.Button buttonTyprMaterialUpdate;
		private System.Windows.Forms.Button buttonTypeMaterialsSave;
	}
}