using MMSLibrary;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MMS_CapstoneProject
{
    public partial class TracksForm : Form
    {
        // track form variable
        private readonly MainForm _mainForm;
        private static TrackModel _trackModel = new TrackModel();

        /// <summary>
        /// TracksForm - for creating new track record
        /// </summary>
        /// <param name="mainForm"></param>
        public TracksForm(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();

            btnEnter.Click += btnCreate_Click;
        }

        /// <summary>
        /// TracksForm - for updating track record
        /// </summary>
        /// <param name="mainForm"></param>
        /// <param name="trackModel"></param>
        public TracksForm(MainForm mainForm, TrackModel trackModel)
        {
            _mainForm = mainForm;
            InitializeComponent();
            btnEnter.Click += btnUpdate_Click;

            txtTrackId.Text = trackModel.TrackID.ToString();
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

        /// <summary>
        /// btnCreate_Click - create new track record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// btnUpdate_Click - update track record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// TracksForm_FormClosing - track form record closing event to update main form datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TracksForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            _mainForm.RefreshDataGridViewTrack();
        }

        /// <summary>
        /// btnEscape_Click - for close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEscape_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// btnClear_Click - clear the form data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            _trackModel = new TrackModel();
            txtTrackId.Clear();
            txtTrackName.Clear();
            rdoIsDeleted_Enabled.Checked = true;
        }

        /// <summary>
        /// txtTrackName_Validating - validating event for track name textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
