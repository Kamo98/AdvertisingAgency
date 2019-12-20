namespace WindowsFormsApp1
{
    partial class BaseForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.типыМатериаловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типыМатериаловToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.типыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типыРекламныхПлощадокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.текущийПрофильToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.типыМатериаловToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.настройкиToolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // типыМатериаловToolStripMenuItem
            // 
            this.типыМатериаловToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.типыМатериаловToolStripMenuItem1,
            this.типыToolStripMenuItem,
            this.типыРекламныхПлощадокToolStripMenuItem});
            this.типыМатериаловToolStripMenuItem.Name = "типыМатериаловToolStripMenuItem";
            this.типыМатериаловToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.типыМатериаловToolStripMenuItem.Text = "Справочники";
            this.типыМатериаловToolStripMenuItem.Click += new System.EventHandler(this.типыМатериаловToolStripMenuItem_Click);
            // 
            // типыМатериаловToolStripMenuItem1
            // 
            this.типыМатериаловToolStripMenuItem1.Name = "типыМатериаловToolStripMenuItem1";
            this.типыМатериаловToolStripMenuItem1.Size = new System.Drawing.Size(229, 22);
            this.типыМатериаловToolStripMenuItem1.Text = "Типы материалов";
            // 
            // типыToolStripMenuItem
            // 
            this.типыToolStripMenuItem.Name = "типыToolStripMenuItem";
            this.типыToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.типыToolStripMenuItem.Text = "Типы продуктов";
            this.типыToolStripMenuItem.Click += new System.EventHandler(this.типыToolStripMenuItem_Click);
            // 
            // типыРекламныхПлощадокToolStripMenuItem
            // 
            this.типыРекламныхПлощадокToolStripMenuItem.Name = "типыРекламныхПлощадокToolStripMenuItem";
            this.типыРекламныхПлощадокToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.типыРекламныхПлощадокToolStripMenuItem.Text = "Типы рекламных площадок";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.текущийПрофильToolStripMenuItem,
            this.сменитьПользователяToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.настройкиToolStripMenuItem.Text = "Профиль";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // текущийПрофильToolStripMenuItem
            // 
            this.текущийПрофильToolStripMenuItem.Name = "текущийПрофильToolStripMenuItem";
            this.текущийПрофильToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.текущийПрофильToolStripMenuItem.Text = "Информация";
            this.текущийПрофильToolStripMenuItem.Click += new System.EventHandler(this.текущийПрофильToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // сменитьПользователяToolStripMenuItem
            // 
            this.сменитьПользователяToolStripMenuItem.Name = "сменитьПользователяToolStripMenuItem";
            this.сменитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.сменитьПользователяToolStripMenuItem.Text = "Сменить пользователя";
            this.сменитьПользователяToolStripMenuItem.Click += new System.EventHandler(this.сменитьПользователяToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem1
            // 
            this.настройкиToolStripMenuItem1.Name = "настройкиToolStripMenuItem1";
            this.настройкиToolStripMenuItem1.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem1.Text = "Настройки";
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem типыМатериаловToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типыМатериаловToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem типыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типыРекламныхПлощадокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem текущийПрофильToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem1;
    }
}