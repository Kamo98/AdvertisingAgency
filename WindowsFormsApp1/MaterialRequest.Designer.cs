namespace WindowsFormsApp1
{
	partial class MaterialRequest
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
            this.dataGridViewMaterialRequest = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageRequests = new System.Windows.Forms.TabPage();
            this.tabPageRowsRequest = new System.Windows.Forms.TabPage();
            this.buttonAddNewRowRequest = new System.Windows.Forms.Button();
            this.dataGridViewRowRequest = new System.Windows.Forms.DataGridView();
            this.ID_MaterialRequestStringColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameMaterialColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TypeMaterialColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReadyColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID_MaterialRequestColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastChangeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountRowsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoreColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterialRequest)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageRequests.SuspendLayout();
            this.tabPageRowsRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRowRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMaterialRequest
            // 
            this.dataGridViewMaterialRequest.AllowUserToAddRows = false;
            this.dataGridViewMaterialRequest.AllowUserToDeleteRows = false;
            this.dataGridViewMaterialRequest.AllowUserToOrderColumns = true;
            this.dataGridViewMaterialRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaterialRequest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_MaterialRequestColumn,
            this.LastChangeColumn,
            this.CountRowsColumn,
            this.MoreColumn,
            this.TotalPrice});
            this.dataGridViewMaterialRequest.Location = new System.Drawing.Point(25, 7);
            this.dataGridViewMaterialRequest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewMaterialRequest.Name = "dataGridViewMaterialRequest";
            this.dataGridViewMaterialRequest.ReadOnly = true;
            this.dataGridViewMaterialRequest.Size = new System.Drawing.Size(952, 452);
            this.dataGridViewMaterialRequest.TabIndex = 2;
            this.dataGridViewMaterialRequest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMaterialRequest_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageRequests);
            this.tabControl1.Controls.Add(this.tabPageRowsRequest);
            this.tabControl1.Location = new System.Drawing.Point(0, 34);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1032, 495);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPageRequests
            // 
            this.tabPageRequests.Controls.Add(this.dataGridViewMaterialRequest);
            this.tabPageRequests.Location = new System.Drawing.Point(4, 25);
            this.tabPageRequests.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageRequests.Name = "tabPageRequests";
            this.tabPageRequests.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageRequests.Size = new System.Drawing.Size(1024, 466);
            this.tabPageRequests.TabIndex = 0;
            this.tabPageRequests.Text = "Запросы на материалы";
            this.tabPageRequests.UseVisualStyleBackColor = true;
            // 
            // tabPageRowsRequest
            // 
            this.tabPageRowsRequest.Controls.Add(this.buttonAddNewRowRequest);
            this.tabPageRowsRequest.Controls.Add(this.dataGridViewRowRequest);
            this.tabPageRowsRequest.Location = new System.Drawing.Point(4, 25);
            this.tabPageRowsRequest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageRowsRequest.Name = "tabPageRowsRequest";
            this.tabPageRowsRequest.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageRowsRequest.Size = new System.Drawing.Size(1024, 466);
            this.tabPageRowsRequest.TabIndex = 1;
            this.tabPageRowsRequest.Text = "Просмотреть запрос";
            this.tabPageRowsRequest.UseVisualStyleBackColor = true;
            // 
            // buttonAddNewRowRequest
            // 
            this.buttonAddNewRowRequest.Location = new System.Drawing.Point(807, 427);
            this.buttonAddNewRowRequest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddNewRowRequest.Name = "buttonAddNewRowRequest";
            this.buttonAddNewRowRequest.Size = new System.Drawing.Size(100, 28);
            this.buttonAddNewRowRequest.TabIndex = 4;
            this.buttonAddNewRowRequest.Text = "Добавить";
            this.buttonAddNewRowRequest.UseVisualStyleBackColor = true;
            this.buttonAddNewRowRequest.Click += new System.EventHandler(this.buttonAddNewRowRequest_Click);
            // 
            // dataGridViewRowRequest
            // 
            this.dataGridViewRowRequest.AllowUserToAddRows = false;
            this.dataGridViewRowRequest.AllowUserToDeleteRows = false;
            this.dataGridViewRowRequest.AllowUserToOrderColumns = true;
            this.dataGridViewRowRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRowRequest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_MaterialRequestStringColumn,
            this.NameMaterialColumn1,
            this.TypeMaterialColumn,
            this.AmountColumn2,
            this.UnitColumn3,
            this.ReadyColumn});
            this.dataGridViewRowRequest.Location = new System.Drawing.Point(27, 7);
            this.dataGridViewRowRequest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewRowRequest.Name = "dataGridViewRowRequest";
            this.dataGridViewRowRequest.Size = new System.Drawing.Size(880, 390);
            this.dataGridViewRowRequest.TabIndex = 3;
            // 
            // ID_MaterialRequestStringColumn
            // 
            this.ID_MaterialRequestStringColumn.HeaderText = "ID_MaterialRequestString";
            this.ID_MaterialRequestStringColumn.Name = "ID_MaterialRequestStringColumn";
            this.ID_MaterialRequestStringColumn.Visible = false;
            // 
            // NameMaterialColumn1
            // 
            this.NameMaterialColumn1.HeaderText = "Название материала";
            this.NameMaterialColumn1.Name = "NameMaterialColumn1";
            this.NameMaterialColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NameMaterialColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TypeMaterialColumn
            // 
            this.TypeMaterialColumn.HeaderText = "Тип материала";
            this.TypeMaterialColumn.Name = "TypeMaterialColumn";
            this.TypeMaterialColumn.ReadOnly = true;
            // 
            // AmountColumn2
            // 
            this.AmountColumn2.HeaderText = "Количество";
            this.AmountColumn2.Name = "AmountColumn2";
            // 
            // UnitColumn3
            // 
            this.UnitColumn3.HeaderText = "Единица измерения";
            this.UnitColumn3.Name = "UnitColumn3";
            // 
            // ReadyColumn
            // 
            this.ReadyColumn.HeaderText = "Исполнено";
            this.ReadyColumn.Name = "ReadyColumn";
            this.ReadyColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ReadyColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ID_MaterialRequestColumn
            // 
            this.ID_MaterialRequestColumn.HeaderText = "Номер запроса на материал";
            this.ID_MaterialRequestColumn.Name = "ID_MaterialRequestColumn";
            this.ID_MaterialRequestColumn.ReadOnly = true;
            // 
            // LastChangeColumn
            // 
            this.LastChangeColumn.HeaderText = "Дата изменения";
            this.LastChangeColumn.Name = "LastChangeColumn";
            this.LastChangeColumn.ReadOnly = true;
            // 
            // CountRowsColumn
            // 
            this.CountRowsColumn.HeaderText = "Количество строк запроса";
            this.CountRowsColumn.Name = "CountRowsColumn";
            this.CountRowsColumn.ReadOnly = true;
            // 
            // MoreColumn
            // 
            this.MoreColumn.HeaderText = "Просмотреть запрос";
            this.MoreColumn.Name = "MoreColumn";
            this.MoreColumn.ReadOnly = true;
            this.MoreColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MoreColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Общая стоимость";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // MaterialRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 544);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "MaterialRequest";
            this.Text = "MaterialRequest";
            this.Controls.SetChildIndex(this.tabControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterialRequest)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageRequests.ResumeLayout(false);
            this.tabPageRowsRequest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRowRequest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewMaterialRequest;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageRequests;
		private System.Windows.Forms.TabPage tabPageRowsRequest;
		private System.Windows.Forms.DataGridView dataGridViewRowRequest;
		private System.Windows.Forms.Button buttonAddNewRowRequest;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_MaterialRequestStringColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn NameMaterialColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn TypeMaterialColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn UnitColumn3;
		private System.Windows.Forms.DataGridViewCheckBoxColumn ReadyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_MaterialRequestColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastChangeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountRowsColumn;
        private System.Windows.Forms.DataGridViewLinkColumn MoreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
    }
}