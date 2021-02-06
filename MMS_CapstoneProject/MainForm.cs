using MMSLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMS_CapstoneProject
{
    public partial class MainForm : Form
    {
        List<ClientModel> clients = new List<ClientModel>();
        List<ClientModel> clients1 = new List<ClientModel>();

        public MainForm()
        {
            clients = SqliteDataAccess.LoadAllClient();
            clients1 = SqliteDataAccess.LoadClient(1);

            bool test = SqliteDataAccess.ActivateClient(1);

            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //TODO: Better make it into a function since we are going to use it multiple time to refresh the data
            RefreshDataGridViewData(dataGridViewClient);

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            string errorMessage = string.Empty;
            lblErrorMessage.Visible = false;
            string clientName = txtClientName.Text;
            string primaryContactName = txtPrimaryContactName.Text;
            string primaryContactCell = txtPrimaryContactCell.Text;
            string primaryContactEmail = txtPrimaryContactEmail.Text;

            if (clientName == string.Empty)
            {
                errorMessage += "Please fill out client name\n";
            }
            if (primaryContactName == string.Empty)
            {
                errorMessage += "Please fill out primary contact name\n";
            }
            if (primaryContactCell == string.Empty)
            {
                errorMessage += "Please fill out primary contact cell\n";
            }
            if (primaryContactEmail == string.Empty)
            {
                errorMessage += "Please fill out primary contact email\n";
            }
            else if (!IsValidEmail(primaryContactEmail))
            {
                errorMessage += primaryContactEmail + " is not a valid email\n";
            }

            if (errorMessage == string.Empty)
            {
                ClientModel client = new ClientModel();
                client.Name = clientName;
                client.PrimaryContactName = primaryContactName;
                client.PrimaryContactCell = primaryContactCell;
                client.PrimaryContactEmail = primaryContactEmail;

                SqliteDataAccess.SaveClient(client);
                RefreshDataGridViewData(dataGridViewClient);

                txtClientName.Text = string.Empty;
                txtPrimaryContactName.Clear();
                txtPrimaryContactCell.Clear();
                txtPrimaryContactEmail.Clear();

                lblErrorMessage.Text = "Successfully inserted new client";
                lblErrorMessage.Visible = true;
            }
            else
            {
                lblErrorMessage.Text = "Error Message: " + errorMessage;
                lblErrorMessage.Visible = true;
            }


        }

        /// <summary>
        /// re
        /// </summary>
        public void RefreshDataGridViewData(DataGridView dataGridView)
        {
            var source = new BindingSource();

            if (dataGridView == dataGridViewClient)
            {
                source = new BindingSource(SqliteDataAccess.LoadAllClient(), null);
            }

            dataGridView.DataSource = source;
            dataGridView.AutoResizeColumns();

            int dgv_width = dataGridView.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            this.Width = 373 + dgv_width;
        }

        private void dataGridViewClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewClient.Rows[e.RowIndex];
                txtClientId.Text = row.Cells[0].Value.ToString();
                txtClientName.Text = row.Cells[1].Value.ToString();
                txtPrimaryContactName.Text = row.Cells[2].Value.ToString();
                txtPrimaryContactCell.Text = row.Cells[3].Value.ToString();
                txtPrimaryContactEmail.Text = row.Cells[4].Value.ToString();


            }
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnAddNew.Enabled = false;
        }

        private void btnRefreshData_Click(object sender, EventArgs e)
        {
            RefreshDataGridViewData(dataGridViewClient);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClientId.Clear();
            txtClientName.Clear();
            txtPrimaryContactName.Clear();
            txtPrimaryContactCell.Clear();
            txtPrimaryContactEmail.Clear();

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

        }

        private void btnCreateNewMode_Click(object sender, EventArgs e)
        {
            gbEdit.Visible = false;
            gbMenu.Visible = false;
            gbCreate.Visible = true;

            dataGridViewClient.Enabled = false;
        }

        private void btnEditMode_Click(object sender, EventArgs e)
        {
            gbEdit.Visible = true;
            gbMenu.Visible = false;
            gbCreate.Visible = false;

            dataGridViewClient.Enabled = true;
        }

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            gbEdit.Visible = false;
            gbMenu.Visible = true;
            gbCreate.Visible = false;

            dataGridViewClient.Enabled = false;

            txtClientId.Clear();
            txtClientName.Clear();
            txtPrimaryContactName.Clear();
            txtPrimaryContactCell.Clear();
            txtPrimaryContactEmail.Clear();
        }

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
