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
    public partial class DeviceCommandForm : Form
    {
        public DeviceCommandForm()
        {
            InitializeComponent();
        }

        private void DeviceCommandForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalStatic.DeviceCmdForm = null;
        }
    }
}
