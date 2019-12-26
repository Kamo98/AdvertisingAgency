using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class DataGridViewDateColumn : DataGridViewColumn
    {
        public DataGridViewDateColumn():base(new DataGridViewDateCell())
        {
        }

        public override DataGridViewCell CellTemplate
        {
            get
            {
                return base.CellTemplate;
            }
            set
            {
                // Ensure that the cell used for the template is a DataGridViewDateCell.
                if (value != null &&
                    !value.GetType().IsAssignableFrom(typeof(DataGridViewDateCell)))
                {
                    throw new InvalidCastException("Must be a CalendarCell");
                }
                base.CellTemplate = value;
            }
        }
    }

    public class DataGridViewDateCell : DataGridViewTextBoxCell
    {
        public DataGridViewDateCell() : base()
        {
            this.Style.Format = "d";
            //Value = DateTime.Today;

        }

        CalendarEditingControl ctl;
        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
            ctl = DataGridView.EditingControl as CalendarEditingControl;
            if (this.Value == null)
               ctl.Value = (DateTime)this.DefaultNewRowValue;        
            else
               ctl.Value = (DateTime)this.Value;
            
        }

        public override void DetachEditingControl()
        {
            base.DetachEditingControl();
            this.Value = ctl.Value;
        }

        // Return the type of the editing control that CalendarCell uses.
        public override Type EditType => typeof(CalendarEditingControl);

        public override Type ValueType => typeof(DateTime);

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

        public CalendarEditingControl()
        {
            this.Format = DateTimePickerFormat.Short;
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
            this.CalendarForeColor = dataGridViewCellStyle.ForeColor;
            this.CalendarMonthBackground = dataGridViewCellStyle.BackColor;
        }

        public bool EditingControlWantsInputKey(Keys keyData, bool dataGridViewWantsInputKey)
        {
            switch (keyData & Keys.KeyCode)
            {
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                case Keys.Right:
                case Keys.Home:
                case Keys.End:
                case Keys.PageDown:
                case Keys.PageUp:
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
