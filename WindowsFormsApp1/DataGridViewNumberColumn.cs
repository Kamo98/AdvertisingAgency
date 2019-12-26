using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class DataGridViewNumberColumn : DataGridViewColumn
    {
        public DataGridViewNumberColumn() : base(new DataGridViewNumberCell())
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
                    !value.GetType().IsAssignableFrom(typeof(DataGridViewNumberCell)))
                {
                    throw new InvalidCastException("Must be a CalendarCell");
                }
                base.CellTemplate = value;
            }
        }
    }

    public class DataGridViewNumberCell : DataGridViewTextBoxCell
    {
        public DataGridViewNumberCell() : base()
        {
            //Value = DateTime.Today;
            
        }

        // Return the type of the editing control that CalendarCell uses.
        public override Type EditType => typeof(NumberEditingControl);

    }

    public class NumberEditingControl : DataGridViewTextBoxEditingControl
    {
        protected override bool IsInputChar(char charCode)
        {
            try { Int32.Parse(charCode.ToString());}
            catch { return false; }
            return true;                     
        }

        protected override bool ProcessDialogChar(char charCode)
        {
            return true;
            //return base.ProcessDialogChar(charCode);
        }

        public override bool EditingControlWantsInputKey(Keys keyData, bool dataGridViewWantsInputKey)
        {
            switch (keyData & Keys.KeyCode)
            {
                case Keys.NumPad0:
                case Keys.NumPad1:
                case Keys.NumPad2:
                case Keys.NumPad3:
                case Keys.NumPad4:
                case Keys.NumPad5:
                case Keys.NumPad6:
                case Keys.NumPad7:
                case Keys.NumPad8:
                case Keys.NumPad9:
                    return true;
                default:
                    return false;
            }
        }
    }
}

