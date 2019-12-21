namespace WindowsFormsApp1
{
    partial class ClientDepartmentForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabClientPage = new System.Windows.Forms.TabPage();
            this.buttonClientsUpdate = new System.Windows.Forms.Button();
            this.buttonClientsSave = new System.Windows.Forms.Button();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.EmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabOrderPage = new System.Windows.Forms.TabPage();
            this.buttonOrdersUpdate = new System.Windows.Forms.Button();
            this.buttonOrdersSave = new System.Windows.Forms.Button();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabClientPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.tabOrderPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabClientPage);
            this.tabControl1.Controls.Add(this.tabOrderPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 418);
            this.tabControl1.TabIndex = 1;
            // 
            // tabClientPage
            // 
            this.tabClientPage.BackColor = System.Drawing.Color.LightGray;
            this.tabClientPage.Controls.Add(this.buttonClientsUpdate);
            this.tabClientPage.Controls.Add(this.buttonClientsSave);
            this.tabClientPage.Controls.Add(this.dataGridViewClients);
            this.tabClientPage.Location = new System.Drawing.Point(4, 22);
            this.tabClientPage.Name = "tabClientPage";
            this.tabClientPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientPage.Size = new System.Drawing.Size(792, 392);
            this.tabClientPage.TabIndex = 0;
            this.tabClientPage.Text = "Клиенты";
            // 
            // buttonClientsUpdate
            // 
            this.buttonClientsUpdate.Location = new System.Drawing.Point(628, 350);
            this.buttonClientsUpdate.Name = "buttonClientsUpdate";
            this.buttonClientsUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonClientsUpdate.TabIndex = 2;
            this.buttonClientsUpdate.Text = "Обновить";
            this.buttonClientsUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonClientsSave
            // 
            this.buttonClientsSave.Location = new System.Drawing.Point(709, 350);
            this.buttonClientsSave.Name = "buttonClientsSave";
            this.buttonClientsSave.Size = new System.Drawing.Size(75, 23);
            this.buttonClientsSave.TabIndex = 1;
            this.buttonClientsSave.Text = "Сохранить";
            this.buttonClientsSave.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.AllowUserToOrderColumns = true;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmailColumn,
            this.AddressColumn,
            this.NameColumn,
            this.NumberColumn});
            this.dataGridViewClients.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.Size = new System.Drawing.Size(792, 344);
            this.dataGridViewClients.TabIndex = 0;
            this.dataGridViewClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClients_CellContentClick);
            // 
            // EmailColumn
            // 
            this.EmailColumn.HeaderText = "Почта";
            this.EmailColumn.Name = "EmailColumn";
            // 
            // AddressColumn
            // 
            this.AddressColumn.HeaderText = "Адрес";
            this.AddressColumn.Name = "AddressColumn";
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Ф.И.О";
            this.NameColumn.Name = "NameColumn";
            // 
            // NumberColumn
            // 
            this.NumberColumn.HeaderText = "Телефон";
            this.NumberColumn.Name = "NumberColumn";
            // 
            // tabOrderPage
            // 
            this.tabOrderPage.BackColor = System.Drawing.Color.LightGray;
            this.tabOrderPage.Controls.Add(this.buttonOrdersUpdate);
            this.tabOrderPage.Controls.Add(this.buttonOrdersSave);
            this.tabOrderPage.Controls.Add(this.dataGridViewOrders);
            this.tabOrderPage.Location = new System.Drawing.Point(4, 22);
            this.tabOrderPage.Name = "tabOrderPage";
            this.tabOrderPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrderPage.Size = new System.Drawing.Size(792, 392);
            this.tabOrderPage.TabIndex = 1;
            this.tabOrderPage.Text = "Заказы";
            // 
            // buttonOrdersUpdate
            // 
            this.buttonOrdersUpdate.Location = new System.Drawing.Point(628, 350);
            this.buttonOrdersUpdate.Name = "buttonOrdersUpdate";
            this.buttonOrdersUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonOrdersUpdate.TabIndex = 4;
            this.buttonOrdersUpdate.Text = "Обновить";
            this.buttonOrdersUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonOrdersSave
            // 
            this.buttonOrdersSave.Location = new System.Drawing.Point(709, 350);
            this.buttonOrdersSave.Name = "buttonOrdersSave";
            this.buttonOrdersSave.Size = new System.Drawing.Size(75, 23);
            this.buttonOrdersSave.TabIndex = 3;
            this.buttonOrdersSave.Text = "Сохранить";
            this.buttonOrdersSave.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToOrderColumns = true;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(-4, 0);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.Size = new System.Drawing.Size(792, 344);
            this.dataGridViewOrders.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ClientDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "ClientDepartmentForm";
            this.Text = "Отдел клиентов";
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.tabClientPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.tabOrderPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabClientPage;
        private System.Windows.Forms.TabPage tabOrderPage;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Button buttonClientsUpdate;
        private System.Windows.Forms.Button buttonClientsSave;
        private System.Windows.Forms.Button buttonOrdersUpdate;
        private System.Windows.Forms.Button buttonOrdersSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}