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
    public partial class IntroForm : Form
    {
        private bool flag = false;
        public IntroForm()
        {
            InitializeComponent();
            SuspendLayout();
            userInput1.namesDefined += (sender, e) =>
            {
                flag = e;
            };
            ResumeLayout();
        }

        private void start3_MouseClick(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                MessageBox.Show("Krenimo 3x3x3");
            }
            else
            {
                MessageBox.Show("Nije moguće krenuti s igrom! \nUnesite imena igrača ili odaberite računalo kao protivnika.");
            }
        }

        private void start4_MouseClick(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                MessageBox.Show("Krenimo 4x4x4");
            }
            else
            {
                MessageBox.Show("Nije moguće krenuti s igrom! \nUnesite imena igrača ili odaberite računalo kao protivnika.");
            }
        }
    }
}
