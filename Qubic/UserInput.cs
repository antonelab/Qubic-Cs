using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qubic
{
    public partial class UserInput : UserControl
    {
        public event EventHandler<bool> namesDefined;
        public UserInput()
        {
            InitializeComponent();
        }

        private void oComputer_CheckedChanged(object sender, EventArgs e)
        {
            if (oComputer.Checked)
            {
                xComputer.Enabled = false;
                oName.Text = "";
                oName.Enabled = false;
                
            }
            else
            {
                xComputer.Enabled = true;
                oName.Enabled = true;
                oName.Text = "";
            }
            checkNames();
        }

        private void xComputer_CheckedChanged(object sender, EventArgs e)
        {
            if (xComputer.Checked)
            {
                oComputer.Enabled = false;
                xName.Text = "";
                xName.Enabled = false;
                
            }
            else
            {
                oComputer.Enabled = true;
                xName.Enabled = true;
                xName.Text = "";
            }
            checkNames();
        }

        private void xName_TextChanged(object sender, EventArgs e)
        {
            checkNames();
        }
        private void oName_TextChanged(object sender, EventArgs e)
        {
            checkNames();
        }

        private void checkNames()
        {
            if (namesDefined != null)
            {
                namesDefined(this, (!oName.Text.Equals("") || oComputer.Checked) && (!xName.Text.Equals("") || xComputer.Checked));
            }
        }

    }
}
