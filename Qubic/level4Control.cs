﻿using System;
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
    public partial class level4Control : UserControl
    {
       public event EventHandler<Tuple<int, int>> btnClicked;
        
        public level4Control()
        {
            InitializeComponent();
        }

        private void onClick(object sender, EventArgs e)
        {
            if (btnClicked != null)
            {
                string tag = (string)((Button)sender).Tag;
                int i = tag[0] - '0';
                int j = tag[1] - '0';
                btnClicked(sender, Tuple.Create(i, j));
            }
        }

        public Object this[string key]
        {
            get => this.Controls[key];
        }
    }
}
