using MMSLibrary;
using MMSLibrary.DataAccess;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MMS_CapstoneProject
{
    public partial class ClientForm : Form
    {
        /// client form variable
        private readonly MainForm _mainForm;

        /// <summary>
        /// ClientEventForm - for creating new client record
        /// </summary>
        /// <param name="mainForm">main form</param>
        public ClientForm(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            btnEnter.Click += btnCreate_Click;
        }

        /// <summary>
        /// ClientForm - for updating client record
        /// </summary>
        /// <param name="mainForm">main form</param>
        /// <param name="clientModel">client record</param>
        public ClientForm(MainForm mainForm, ClientModel clientModel)
        {
            _mainForm = mainForm;
            InitializeComponent();
            btnEnter.Click += btnUpdate_Click;

            // load client data into the form
            txtClientId.Text = clientModel.ClientID.ToString();
            txtClientName.Text = clientModel.Name;
            txtClientPrimaryContactName.Text = clientModel.PrimaryContactName;
            txtClientPrimaryContactCell.Text = clientModel.PrimaryContactCell;
            txtClientPrimaryContactEmail.Text = clientModel.PrimaryContactEmail;

            if (clientModel.IsDeleted)
            {
                rdoIsDeleted_Disabled.Checked = true;
            }
            else
            {
                rdoIsDeleted_Enabled.Checked = true;
            }

            btnEnter.Text = "Update";
        }

        /// <summary>
        /// btnCreate_Click - for new client record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                ClientModel clientModel = new ClientModel();
                clientModel.Name = txtClientName.Text.Trim();
                clientModel.PrimaryContactName = txtClientPrimaryContactName.Text.Trim();
                clientModel.PrimaryContactCell = txtClientPrimaryContactCell.Text.Trim();
                clientModel.PrimaryContactEmail = txtClientPrimaryContactEmail.Text.Trim();

                try
                {
                    ClientDataAccess.SaveClient(clientModel);
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
        /// btnUpdate_Click - for updating client record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                ClientModel clientModel = new ClientModel();
                clientModel.Name = txtClientName.Text.Trim();
                clientModel.PrimaryContactName = txtClientPrimaryContactName.Text.Trim();
                clientModel.PrimaryContactCell = txtClientPrimaryContactCell.Text.Trim();
                clientModel.PrimaryContactEmail = txtClientPrimaryContactEmail.Text.Trim();
                clientModel.IsDeleted = rdoIsDeleted_Disabled.Checked ? true : false;

                try
                {
                    ClientDataAccess.UpdateClient(clientModel, int.Parse(txtClientId.Text));
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
        /// ClientForm_FormClosing - form close event to update main form datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            _mainForm.RefreshDataGridViewClient();
        }

        /// <summary>
        /// btnEscape_Click - close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEscape_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// btnClear_Click - clear the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClientId.Clear();
            txtClientName.Clear();
            txtClientPrimaryContactName.Clear();
            txtClientPrimaryContactCell.Clear();
            txtClientPrimaryContactEmail.Clear();
            rdoIsDeleted_Enabled.Checked = true;
        }

        /// <summary>
        /// txtClientName_Validating - validating event for client name textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtClientName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClientName.Text))
            {
                e.Cancel = true;
                txtClientName.Focus();
                errorProviderApp.SetError(txtClientName, "Client Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtClientName, "");
            }
        }

        /// <summary>
        /// txtClientPrimaryContactName_Validating - validating event for primary contact name textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtClientPrimaryContactName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClientPrimaryContactName.Text))
            {
                e.Cancel = true;
                txtClientPrimaryContactName.Focus();
                errorProviderApp.SetError(txtClientPrimaryContactName, "Client Primary Contact Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtClientPrimaryContactName, "");
            }
        }

        /// <summary>
        /// txtClientPrimaryContactCell_Validating - validating event for primary contact cell textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtClientPrimaryContactCell_Validating(object sender, CancelEventArgs e)
        {
            if (!txtClientPrimaryContactCell.MaskFull)
            {
                e.Cancel = true;
                txtClientPrimaryContactCell.Focus();
                errorProviderApp.SetError(txtClientPrimaryContactCell, "Cell should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtClientPrimaryContactCell, "");
            }
        }

        /// <summary>
        /// txtClientPrimaryContactEmail_Validating - validating event for primary contact email
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtClientPrimaryContactEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClientPrimaryContactEmail.Text))
            {
                e.Cancel = true;
                txtClientPrimaryContactEmail.Focus();
                errorProviderApp.SetError(txtClientPrimaryContactEmail, "Client Primary Contact Email should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtClientPrimaryContactEmail, "");
            }
        }
    }
}
