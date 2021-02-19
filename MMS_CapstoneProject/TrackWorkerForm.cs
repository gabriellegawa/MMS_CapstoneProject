using MMSLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMS_CapstoneProject
{
    public partial class TrackWorkerForm : Form
    {
        public TrackWorkerForm()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                TrackWorkerModel trackWorker = new TrackWorkerModel();
                trackWorker.FirstName = txtTrackWorkerFirstName.Text;
                trackWorker.LastName = txtTrackWorkerLastName.Text;
                trackWorker.Email = txtTrackWorkerEmail.Text;
                trackWorker.Cell = txtTrackWorkerCell.Text;
                trackWorker.IsCapableCaptain = rdoIsCapableCaptain_True.Checked ? true : false;


            }
        }

        private void txtTrackWorkerFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTrackWorkerFirstName.Text))
            {
                e.Cancel = true;
                txtTrackWorkerFirstName.Focus();
                errorProviderApp.SetError(txtTrackWorkerFirstName, "First Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtTrackWorkerFirstName, "");
            }
        }

        private void txtTrackWorkerLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTrackWorkerLastName.Text))
            {
                e.Cancel = true;
                txtTrackWorkerLastName.Focus();
                errorProviderApp.SetError(txtTrackWorkerLastName, "Last Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtTrackWorkerLastName, "");
            }
        }


        private void txtTrackWorkerEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTrackWorkerEmail.Text))
            {
                e.Cancel = true;
                txtTrackWorkerEmail.Focus();
                errorProviderApp.SetError(txtTrackWorkerEmail, "Email should not be left blank!");
            }
            else if(!IsValidEmail(txtTrackWorkerEmail.Text))
            {
                e.Cancel = true;
                txtTrackWorkerEmail.Focus();
                errorProviderApp.SetError(txtTrackWorkerEmail, "Email is not valid!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtTrackWorkerEmail, "");
            }
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

        private void TrackWorkerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
