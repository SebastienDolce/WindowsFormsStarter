using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw1pt2
{
    public partial class InputForm : Form
    {
        public event EventHandler AcceptClicked;
        ErrorProvider errorProvider;
        public string input { get; set; }
        public InputForm()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
            Ok.CausesValidation = true;
            Apply.CausesValidation = true;
        }
        void applyValidation(object sender, CancelEventArgs e)
        {
            if(tb1.Text.Length < 1)
            {
                string error = "Text box needs something in it";
                e.Cancel = true;
                this.errorProvider.SetError((Control)sender, error);
                MessageBox.Show("The Text Box is empty");
            }
            else
            {
                e.Cancel = false;
            }
        }
        private void Ok_Click(object sender, EventArgs e)
        {
            Apply_Click(sender, e);
            CancelButt_Click(sender, e);
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            input = tb1.Text;
            tb1.Text = "";
            if (AcceptClicked != null) AcceptClicked(this, EventArgs.Empty);
        }
        
        private void CancelButt_Click(object sender, EventArgs e)
        {
            if(sender is Button)
            {
                Button butt = sender as Button;
                butt.Equals(CancelButt);
            }
            this.Close();
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
