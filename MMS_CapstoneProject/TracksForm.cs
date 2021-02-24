using MMSLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMS_CapstoneProject
{
    public partial class TracksForm : Form
    {
        private readonly MainForm _mainForm;
        public TracksForm(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();

            btnEnter.Click += btnCreate_Click;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTrackId.Clear();
            txtTrackName.Clear();
            cbTrackConfiguration.Items.Clear();
            rdoIsDeleted_Enabled.Checked = true;
        }
    }
}
