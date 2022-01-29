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
    public partial class RulesForm : Form
    {
        public RulesForm()
        {
            InitializeComponent();
            label1.Text = "Pravila igre ista su kao kod križić-kružića, \n jedina je razlika što se kod Qubica igra na ploči više dimenzija.\n \n   Potrebno je složiti svoje znakiće u jednom redu, stupcu ili dijagonali.\n\n     Igra se tako što jedan pa drugi igrač naizmjenično kliknu na\n      polje ploče koje žele odigrati. X igrač uvijek igra prvi. \n\nPomoć (Hint) služi igračima da uz pomoć računala \n i njegove analize odigraju najbolji potez.\n   Nakon što računalo prikaže hint korisnik ga može \n     ili ne mora odigrati.\n\nIgra protiv računala automatizirana je i korisnik nakon svojeg \n   poteza mora sačekati da računalo izračuna i odigra svoj. \n\n                  Želimo Vam lijepu zabavu i puno sreće!";
        }

    }
}
