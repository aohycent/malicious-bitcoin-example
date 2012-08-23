using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Microsoft.Win32;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Bitcoin\\Bitcoin-Qt", "nTransactionFee", 9);
        }
    }
}
