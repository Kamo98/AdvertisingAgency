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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabClientPage = new System.Windows.Forms.TabPage();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.buttonClientsUpdate = new System.Windows.Forms.Button();
            this.buttonClientsSave = new System.Windows.Forms.Button();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.EmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneColumn = new WindowsFormsApp1.DataGridViewNumberColumn();
            this.Column1 = new WindowsFormsApp1.DataGridViewDateColumn();
            this.tabOrderPage = new System.Windows.Forms.TabPage();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.buttonOrdersUpdate = new System.Windows.Forms.Button();
            this.buttonOrdersSave = new System.Windows.Forms.Button();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.promotionalPage = new System.Windows.Forms.TabPage();
            this.buttonProjectAdd = new System.Windows.Forms.Button();
            this.buttonProjectUpdate = new System.Windows.Forms.Button();
            this.buttonProjectSave = new System.Windows.Forms.Button();
            this.dataGridViewProjects = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabClientPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.tabOrderPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.promotionalPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabClientPage);
            this.tabControl1.Controls.Add(this.tabOrderPage);
            this.tabControl1.Controls.Add(this.promotionalPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 418);
            this.tabControl1.TabIndex = 1;
            // 
            // tabClientPage
            // 
            this.tabClientPage.BackColor = System.Drawing.Color.LightGray;
            this.tabClientPage.Controls.Add(this.buttonAddClient);
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
            // buttonAddClient
            // 
            this.buttonAddClient.Location = new System.Drawing.Point(547, 350);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(75, 23);
            this.buttonAddClient.TabIndex = 3;
            this.buttonAddClient.Text = "Добавить";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // buttonClientsUpdate
            // 
            this.buttonClientsUpdate.Location = new System.Drawing.Point(628, 350);
            this.buttonClientsUpdate.Name = "buttonClientsUpdate";
            this.buttonClientsUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonClientsUpdate.TabIndex = 2;
            this.buttonClientsUpdate.Text = "Обновить";
            this.buttonClientsUpdate.UseVisualStyleBackColor = true;
            this.buttonClientsUpdate.Click += new System.EventHandler(this.buttonClientsUpdate_Click);
            // 
            // buttonClientsSave
            // 
            this.buttonClientsSave.Location = new System.Drawing.Point(709, 350);
            this.buttonClientsSave.Name = "buttonClientsSave";
            this.buttonClientsSave.Size = new System.Drawing.Size(75, 23);
            this.buttonClientsSave.TabIndex = 1;
            this.buttonClientsSave.Text = "Сохранить";
            this.buttonClientsSave.UseVisualStyleBackColor = true;
            this.buttonClientsSave.Click += new System.EventHandler(this.buttonClientsSave_Click);
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.AllowUserToOrderColumns = true;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmailColumn,
            this.AddressColumn,
            this.NameColumn,
            this.PhoneColumn,
            this.Column1});
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
            // PhoneColumn
            // 
            dataGridViewCellStyle1.Format = "d";
            this.PhoneColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.PhoneColumn.HeaderText = "Телефон";
            this.PhoneColumn.Name = "PhoneColumn";
            this.PhoneColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PhoneColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // tabOrderPage
            // 
            this.tabOrderPage.BackColor = System.Drawing.Color.LightGray;
            this.tabOrderPage.Controls.Add(this.buttonAddOrder);
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
            // buttonAddOrder
            // 
            this.buttonAddOrder.Location = new System.Drawing.Point(547, 350);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonAddOrder.TabIndex = 5;
            this.buttonAddOrder.Text = "Добавить";
            this.buttonAddOrder.UseVisualStyleBackColor = true;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
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
            this.buttonOrdersSave.Click += new System.EventHandler(this.buttonOrdersSave_Click);
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
            // promotionalPage
            // 
            this.promotionalPage.BackColor = System.Drawing.Color.LightGray;
            this.promotionalPage.Controls.Add(this.buttonProjectAdd);
            this.promotionalPage.Controls.Add(this.buttonProjectUpdate);
            this.promotionalPage.Controls.Add(this.buttonProjectSave);
            this.promotionalPage.Controls.Add(this.dataGridViewProjects);
            this.promotionalPage.Location = new System.Drawing.Point(4, 22);
            this.promotionalPage.Name = "promotionalPage";
            this.promotionalPage.Padding = new System.Windows.Forms.Padding(3);
            this.promotionalPage.Size = new System.Drawing.Size(792, 392);
            this.promotionalPage.TabIndex = 2;
            this.promotionalPage.Text = "Рекламные проекты";
            // 
            // buttonProjectAdd
            // 
            this.buttonProjectAdd.Location = new System.Drawing.Point(547, 350);
            this.buttonProjectAdd.Name = "buttonProjectAdd";
            this.buttonProjectAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonProjectAdd.TabIndex = 3;
            this.buttonProjectAdd.Text = "Добавить";
            this.buttonProjectAdd.UseVisualStyleBackColor = true;
            // 
            // buttonProjectUpdate
            // 
            this.buttonProjectUpdate.Location = new System.Drawing.Point(628, 350);
            this.buttonProjectUpdate.Name = "buttonProjectUpdate";
            this.buttonProjectUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonProjectUpdate.TabIndex = 2;
            this.buttonProjectUpdate.Text = "Обновить";
            this.buttonProjectUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonProjectSave
            // 
            this.buttonProjectSave.Location = new System.Drawing.Point(709, 350);
            this.buttonProjectSave.Name = "buttonProjectSave";
            this.buttonProjectSave.Size = new System.Drawing.Size(75, 23);
            this.buttonProjectSave.TabIndex = 1;
            this.buttonProjectSave.Text = "Сохранить";
            this.buttonProjectSave.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProjects
            // 
            this.dataGridViewProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjects.Location = new System.Drawing.Point(-4, 0);
            this.dataGridViewProjects.Name = "dataGridViewProjects";
            this.dataGridViewProjects.Size = new System.Drawing.Size(800, 344);
            this.dataGridViewProjects.TabIndex = 0;
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
            this.promotionalPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).EndInit();
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private DataGridViewNumberColumn PhoneColumn;
        private DataGridViewDateColumn Column1;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.TabPage promotionalPage;
        private System.Windows.Forms.Button buttonProjectAdd;
        private System.Windows.Forms.Button buttonProjectUpdate;
        private System.Windows.Forms.Button buttonProjectSave;
        private System.Windows.Forms.DataGridView dataGridViewProjects;
    }
}