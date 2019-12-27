namespace WindowsFormsApp1
{
    partial class AddProjectForm
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
            this.textBoxConcept = new System.Windows.Forms.TextBox();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.buttonConcept = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTask = new System.Windows.Forms.Button();
            this.textBoxStage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxOrder = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.conceptFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.taskFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textBoxConcept
            // 
            this.textBoxConcept.Location = new System.Drawing.Point(122, 47);
            this.textBoxConcept.Name = "textBoxConcept";
            this.textBoxConcept.Size = new System.Drawing.Size(137, 20);
            this.textBoxConcept.TabIndex = 0;
            // 
            // textBoxTask
            // 
            this.textBoxTask.Location = new System.Drawing.Point(122, 81);
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.Size = new System.Drawing.Size(137, 20);
            this.textBoxTask.TabIndex = 1;
            // 
            // buttonConcept
            // 
            this.buttonConcept.Location = new System.Drawing.Point(265, 47);
            this.buttonConcept.Name = "buttonConcept";
            this.buttonConcept.Size = new System.Drawing.Size(75, 23);
            this.buttonConcept.TabIndex = 2;
            this.buttonConcept.Text = "Выбрать";
            this.buttonConcept.UseVisualStyleBackColor = true;
            this.buttonConcept.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Файл концепта:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Файл тех. задания:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonTask
            // 
            this.buttonTask.Location = new System.Drawing.Point(265, 79);
            this.buttonTask.Name = "buttonTask";
            this.buttonTask.Size = new System.Drawing.Size(75, 23);
            this.buttonTask.TabIndex = 5;
            this.buttonTask.Text = "Выбрать";
            this.buttonTask.UseVisualStyleBackColor = true;
            this.buttonTask.Click += new System.EventHandler(this.buttonTask_Click);
            // 
            // textBoxStage
            // 
            this.textBoxStage.Location = new System.Drawing.Point(122, 114);
            this.textBoxStage.Name = "textBoxStage";
            this.textBoxStage.Size = new System.Drawing.Size(137, 20);
            this.textBoxStage.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Этап выполнения:";
            // 
            // comboBoxOrder
            // 
            this.comboBoxOrder.FormattingEnabled = true;
            this.comboBoxOrder.Location = new System.Drawing.Point(122, 145);
            this.comboBoxOrder.Name = "comboBoxOrder";
            this.comboBoxOrder.Size = new System.Drawing.Size(137, 21);
            this.comboBoxOrder.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Заказ:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(116, 185);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(197, 185);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // conceptFileDialog
            // 
            this.conceptFileDialog.FileName = "conceptFileDialog";
            // 
            // taskFileDialog
            // 
            this.taskFileDialog.FileName = "openFileDialog2";
            // 
            // AddProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 224);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxStage);
            this.Controls.Add(this.buttonTask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConcept);
            this.Controls.Add(this.textBoxTask);
            this.Controls.Add(this.textBoxConcept);
            this.Name = "AddProjectForm";
            this.Text = "Добавить рекламный проект";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxConcept;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.Button buttonConcept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTask;
        private System.Windows.Forms.TextBox textBoxStage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.OpenFileDialog conceptFileDialog;
        private System.Windows.Forms.OpenFileDialog taskFileDialog;
    }
}