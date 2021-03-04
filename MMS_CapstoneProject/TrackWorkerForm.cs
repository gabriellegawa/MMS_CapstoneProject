using MMSLibrary;
using MMSLibrary.DataAccess;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MMS_CapstoneProject
{
    public partial class TrackWorkerForm : Form
    {
        private readonly MainForm _mainForm;
        /// <summary>
        /// TrackWorkerForm constructor from main form, we pass mainform since we need to refresh datagridview on main form and this is one of the way
        /// FOR CREATION OF TRACKWORKER
        /// </summary>
        /// <param name="mainForm">main form</param>
        public TrackWorkerForm(MainForm mainForm)
        {
            InitializeComponent();

            _mainForm = mainForm;
            // Wire btnEnter click event into btnCreate_Click event
            btnEnter.Click += btnCreate_Click;
        }
        /// <summary>
        /// TrackWorkerForm constructor from main form, we pass mainform since we need to refresh datagridview on main form and this is one of the way
        ///     and we pass track worker object that we get from datagridview.
        /// FOR UPDATE OF TRACKWORKER
        /// </summary>
        /// <param name="mainForm">main form</param>
        /// <param name="trackWorker">track worker from datagridview</param>
        public TrackWorkerForm(MainForm mainForm, TrackWorkerModel trackWorker)
        {
            InitializeComponent();

            _mainForm = mainForm;
            // Wire btnEnter click event into btnUpdate_Click event
            btnEnter.Click += btnUpdate_Click;

            // Moving TrackWorker data into the form
            txtTrackWorkerId.Text = trackWorker.Id.ToString();
            txtTrackWorkerFirstName.Text = trackWorker.FirstName;
            txtTrackWorkerLastName.Text = trackWorker.LastName;
            txtTrackWorkerCell.Text = trackWorker.Cell;
            txtTrackWorkerEmail.Text = trackWorker.Email;
            if (trackWorker.IsCapableCaptain)
            {
                rdoIsCapableCaptain_True.Checked = true;
            }
            else
            {
                rdoIsCapableCaptain_False.Checked = true;
            }
            if (trackWorker.IsDeleted)
            {
                rdoIsDeleted_Disabled.Checked = true;
            }
            else
            {
                rdoIsDeleted_Enabled.Checked = true;
            }
            // Change the btnEnter text into Update
            btnEnter.Text = "&Update";
        }
        /// <summary>
        /// btnCreate_Click - button create event for inserting new track worker into database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            bool bFirstNameValid = ValidatingFirstNameTextbox();
            bool bLastNameValid = ValidatingLastNameTextbox();
            bool bCellValid = ValidatingCellTextbox();
            bool bEmailValid = ValidatingEmailTextbox();

            if (bFirstNameValid && bLastNameValid && bCellValid && bEmailValid)
            {
                TrackWorkerModel trackWorker = new TrackWorkerModel();
                trackWorker.FirstName = txtTrackWorkerFirstName.Text.Trim();
                trackWorker.LastName = txtTrackWorkerLastName.Text.Trim();
                trackWorker.Cell = txtTrackWorkerCell.Text.Trim();
                trackWorker.Email = txtTrackWorkerEmail.Text.Trim();
                trackWorker.IsCapableCaptain = rdoIsCapableCaptain_True.Checked ? true : false;

                try
                {
                    TrackWorkerDataAccess.SaveTrackWorker(trackWorker);
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
            bool bFirstNameValid = ValidatingFirstNameTextbox();
            bool bLastNameValid = ValidatingLastNameTextbox();
            bool bCellValid = ValidatingCellTextbox();
            bool bEmailValid = ValidatingEmailTextbox();

            if (bFirstNameValid && bLastNameValid && bCellValid && bEmailValid)
            {
                TrackWorkerModel trackWorker = new TrackWorkerModel();
                trackWorker.FirstName = txtTrackWorkerFirstName.Text.Trim();
                trackWorker.LastName = txtTrackWorkerLastName.Text.Trim();
                trackWorker.Cell = txtTrackWorkerCell.Text.Trim();
                trackWorker.Email = txtTrackWorkerEmail.Text.Trim();
                trackWorker.IsCapableCaptain = rdoIsCapableCaptain_True.Checked ? true : false;
                trackWorker.IsDeleted = rdoIsDeleted_Disabled.Checked ? true : false;

                try
                {
                    TrackWorkerDataAccess.UpdateTrackWorker(trackWorker, int.Parse(txtTrackWorkerId.Text));
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

        private bool ValidatingFirstNameTextbox()
        {
            bool bStatus = true;
            if (string.IsNullOrWhiteSpace(txtTrackWorkerFirstName.Text))
            {
                txtTrackWorkerFirstName.Focus();
                errorProviderApp.SetError(txtTrackWorkerFirstName, "First Name should not be left blank!");
                bStatus = false;
            }
            else
            {
                errorProviderApp.SetError(txtTrackWorkerFirstName, "");
            }
            return bStatus;
        }

        private bool ValidatingLastNameTextbox()
        {
            bool bStatus = true;
            if (string.IsNullOrWhiteSpace(txtTrackWorkerLastName.Text))
            {
                txtTrackWorkerLastName.Focus();
                errorProviderApp.SetError(txtTrackWorkerLastName, "Last Name should not be left blank!");
                bStatus = false;
            }
            else
            {
                errorProviderApp.SetError(txtTrackWorkerLastName, "");
            }
            return bStatus;
        }

        private bool ValidatingCellTextbox()
        {
            bool bStatus = true;
            if (!txtTrackWorkerCell.MaskFull)
            {
                txtTrackWorkerCell.Focus();
                errorProviderApp.SetError(txtTrackWorkerCell, "Cell should not be left blank!");
                bStatus = false;
            }
            else
            {
                errorProviderApp.SetError(txtTrackWorkerCell, "");
            }
            return bStatus;
        }

        private bool ValidatingEmailTextbox()
        {
            bool bStatus = true;
            if (string.IsNullOrWhiteSpace(txtTrackWorkerEmail.Text))
            {
                txtTrackWorkerEmail.Focus();
                errorProviderApp.SetError(txtTrackWorkerEmail, "Email should not be left blank!");
                bStatus = false;
            }
            else if (!IsValidEmail(txtTrackWorkerEmail.Text))
            {
                txtTrackWorkerEmail.Focus();
                errorProviderApp.SetError(txtTrackWorkerEmail, "Email is not valid!");
                bStatus = false;
            }
            else
            {
                errorProviderApp.SetError(txtTrackWorkerEmail, "");
            }
            return bStatus;
        }

        private void TrackWorkerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            _mainForm.RefreshDataGridViewTrackWorker();
        }
        

        private void btnEscape_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTrackWorkerId.Clear();
            txtTrackWorkerFirstName.Clear();
            txtTrackWorkerLastName.Clear();
            txtTrackWorkerCell.Clear();
            txtTrackWorkerEmail.Clear();
            rdoIsCapableCaptain_True.Checked = true;
            rdoIsDeleted_Enabled.Checked = true;
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/standard/base-types/how-to-verify-that-strings-are-in-valid-email-format
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }
}
