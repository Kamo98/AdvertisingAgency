using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddProjectForm : Form
    {
        Dictionary<String, int> combo;
        bool addRow = false;
        public AddProjectForm(Dictionary<String,int> combo) : this()
        {
            this.combo = combo;
            foreach (var val in combo)
                comboBoxOrder.Items.Add(val.Key);
            comboBoxOrder.Text = combo.First().Key;
        }

        /*new ColumnDataGridViewWrapper("Дата создания" ,qts("DateOfCreation"),FieldType.Date),
                                                                new ColumnDataGridViewWrapper("Концепт",qts("Concept"),FieldType.Text),
                                                                new ColumnDataGridViewWrapper("Дата окончания", qts("ExpirationDate"),FieldType.Date),
                                                                new ColumnDataGridViewWrapper("Этап выполнения", qts("ExecutionStage"),FieldType.Integer),
                                                                new ColumnDataGridViewWrapper("Тех. задание",qts("TechnicalTask"),FieldType.Text),
                                                                new ColumnDataGridViewWrapper("Заказ",qts("ID_Order"),FieldType.Lis*/
        public object[] RowToInsert => new object[] {null, DateTime.Now, textBoxConcept.Text, null, textBoxStage.Text,textBoxTask.Text, comboBoxOrder.Text };

        public AddProjectForm()
        {
            InitializeComponent();
        }

        public bool AddRow => addRow;

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conceptFileDialog.ShowDialog();
            textBoxConcept.Text = conceptFileDialog.FileName;
        }

        private void buttonTask_Click(object sender, EventArgs e)
        {
            taskFileDialog.ShowDialog();
            textBoxTask.Text = taskFileDialog.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addRow = true;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
