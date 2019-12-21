using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public sealed class DataGridViewDateColumn : DataGridViewColumn
    {
        public DataGridViewDateColumn()
        {
            base.CellTemplate = new DataGridViewDateCell();
        }
    }

    public class DataGridViewDateCell : DataGridViewCell
    {
        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
            CalendarEditingControl ctl = (CalendarEditingControl)DataGridView.EditingControl;
            ctl.Value = (DateTime)this.Value;
        }

        public override object DefaultNewRowValue => DateTime.Today;

    }

    public class CalendarEditingControl : DateTimePicker, IDataGridViewEditingControl
    {
        private DataGridView grid;
        public DataGridView EditingControlDataGridView
        {
            get => grid;
            set => grid = value;
        }
        
        public object EditingControlFormattedValue
        {
            get => this.Value.ToShortDateString();
            set
            {
                string newValue = value as string;
                if (newValue != null)
                    this.Value = DateTime.Parse(newValue);
            }
        }
        private int rowIndex;
        public int EditingControlRowIndex
        {
            get => rowIndex;
            set => rowIndex = value;
        }

        private bool valueChanged;
        public bool EditingControlValueChanged
        {
            get => valueChanged;
            set => valueChanged = value;
        }

        public Cursor EditingPanelCursor
        {
            get => base.Cursor;
        }

        public bool RepositionEditingControlOnValueChange
        {
            get => false;
        }

        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {
            this.Font = dataGridViewCellStyle.Font;
        }

        public bool EditingControlWantsInputKey(Keys keyData, bool dataGridViewWantsInputKey)
        {
            switch (keyData & Keys.KeyCode)
            {
                case Keys.Left:
                    return true;
                default:
                    return false;
            }
        }

        public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
        {
            return EditingControlFormattedValue;
        }

        public void PrepareEditingControlForEdit(bool selectAll)
        {
            
        }
    }
}
