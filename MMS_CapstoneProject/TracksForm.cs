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
        private static TrackModel _trackModel = new TrackModel();
        public TracksForm(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();

            btnEnter.Click += btnCreate_Click;
        }
        public TracksForm(MainForm mainForm, TrackModel trackModel)
        {
            _mainForm = mainForm;
            InitializeComponent();
            btnEnter.Click += btnUpdate_Click;

            txtTrackId.Text = trackModel.Id.ToString();
            txtTrackName.Text = trackModel.Name;

            if (trackModel.IsDeleted)
            {
                rdoIsDeleted_Disabled.Checked = true;
            }
            else
            {
                rdoIsDeleted_Enabled.Checked = true;
            }

            btnEnter.Text = "Update";
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                _trackModel = new TrackModel();
                _trackModel.Name = txtTrackName.Text.Trim();

                try
                {
                    TrackDataAccess.SaveTrack(_trackModel);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Runtime Error\n" + ex.Message, "Unexpected Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    this.Close();
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTrackId.Clear();
            txtTrackName.Clear();
            cbTrackConfiguration.Items.Clear();
            rdoIsDeleted_Enabled.Checked = true;
        }

        private void txtTrackName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTrackName.Text))
            {
                e.Cancel = true;
                txtTrackName.Focus();
                errorProviderApp.SetError(txtTrackName, "Track Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtTrackName, "");
            }
        }
    }
}
