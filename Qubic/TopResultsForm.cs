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
    public partial class TopResultsForm : Form
    {
        private database db;
        public TopResultsForm()
        {
            InitializeComponent();
            db = new database();
        }
    }
}