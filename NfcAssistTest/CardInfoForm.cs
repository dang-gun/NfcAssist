using NfcAssistTest.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NfcAssistTest
{
    public partial class CardInfoForm : Form
    {
        public CardInfoForm()
        {
            InitializeComponent();
        }

        private void CardInfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalStatic.CardInfoForm = null;
        }
    }
}
