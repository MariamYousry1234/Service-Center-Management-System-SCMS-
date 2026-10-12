using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCMSControlsLib
{
    public partial class cusTextBox : TextBox
    {
        public cusTextBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }



        public enum enWritingType { Numbers = 1, Text = 2, None = 3 }
         enWritingType _WritingType = enWritingType.None;
        ErrorProvider _ErrorProvider1 = new ErrorProvider();
        int? _Length = null;
        public bool IsRequired
        {
            set; get;
        }

        public enWritingType WritingType
        {
            set
            {
                _WritingType = value;
            }
            get
            {
                return _WritingType;
            }
        }

        public int? Length
        {
            set
            {
                _Length = value;
            }
            get
            {
                return _Length;
            }
        }
        private bool IsNumber()
        {
            return int.TryParse(this.Text, out int intResult) ||
                float.TryParse(this.Text, out float floatResult);
        }

        public bool IsValid()
        {
            _ErrorProvider1.SetError(this, null);

            if (IsRequired && string.IsNullOrEmpty(this.Text.Trim()))
            {
                _ErrorProvider1.SetError(this, "This field is required!");
                this.Focus();
                return false;

            }

            if(!string.IsNullOrEmpty(this.Text.Trim()))
            {
                if (_WritingType == enWritingType.Numbers && !IsNumber())
                {
                    _ErrorProvider1.SetError(this, "Must be a number!");
                    this.Focus();
                    return false;
                }

                if (Length != null && this.Text.Length != Length)

                {
                    _ErrorProvider1.SetError(this, $"Must be {Length} length");
                    this.Focus();
                    return false;
                }
            }
        
            return true;
        }
    }

}

