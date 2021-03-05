using MMSLibrary;
using System;
using System.ComponentModel;
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

            btnEnter.Text = "&Update";
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
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                _trackModel = new TrackModel();
                _trackModel.Name = txtTrackName.Text.Trim();
                _trackModel.IsDeleted = rdoIsDeleted_Disabled.Checked ? true : false;

                try
                {
                    TrackDataAccess.UpdateTrack(_trackModel, int.Parse(txtTrackId.Text));
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

        private void TracksForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            _mainForm.RefreshDataGridViewTrack();
        }

        private void btnEscape_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _trackModel = new TrackModel();
            txtTrackId.Clear();
            txtTrackName.Clear();
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
