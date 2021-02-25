using MMSLibrary;
using MMSLibrary.DataAccess;
using System;
using System.Windows.Forms;

namespace MMS_CapstoneProject
{
    public partial class ClientForm_draft1 : Form
    {
        private bool btnEditModeClicked = false;


        public ClientForm_draft1()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshDataGridViewData(dataGridViewClient);
        }

        #region EVENTS
        #region GroupBoxMenu Event
        private void btnCreateNewMode_Click(object sender, EventArgs e)
        {
            ClearClientTextBox();

            gbEdit.Visible = false;
            gbMenu.Visible = false;
            gbCreate.Visible = true;
            gbClientTexBox.Enabled = true;

            dataGridViewClient.Enabled = false;
        }

        private void btnEditMode_Click(object sender, EventArgs e)
        {
            btnEditModeClicked = true;

            ClearClientTextBox();

            gbEdit.Visible = true;
            gbMenu.Visible = false;
            gbCreate.Visible = false;
            gbClientTexBox.Enabled = true;

            dataGridViewClient.Enabled = true;

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
        #endregion
        #region GroupBox Create Mode Event
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;

            string errorMessage = string.Empty;
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
            if (!txtPrimaryContactCell.MaskCompleted)
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

                ClientDataAccess.SaveClient(client);
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
        #endregion
        #region GroupBox Edit Mode Event
        private void btnUpdate_Click(object sender, EventArgs e)
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
            if (!txtPrimaryContactCell.MaskCompleted)
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


                txtClientName.Text = string.Empty;
                txtPrimaryContactName.Clear();
                txtPrimaryContactCell.Clear();
                txtPrimaryContactEmail.Clear();

                lblErrorMessage.Text = "Successfully update client";
                lblErrorMessage.Visible = true;


                var test = rbClientIsDeleted_1.Checked;

                if (rbClientIsDeleted_1.Checked)
                {
                    ClientDataAccess.DeactivateClient(int.Parse(txtClientId.Text));
                }
                else
                {
                    ClientDataAccess.ActivateClient(int.Parse(txtClientId.Text));
                }

                ClientDataAccess.UpdateClient(client, int.Parse(txtClientId.Text));
                RefreshDataGridViewData(dataGridViewClient);
            }
            else
            {
                lblErrorMessage.Text = "Error Message: " + errorMessage;
                lblErrorMessage.Visible = true;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            ClientDataAccess.DeactivateClient(int.Parse(txtClientId.Text));

            ClearClientTextBox();

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            dataGridViewClient.ClearSelection();

            RefreshDataGridViewData(dataGridViewClient);
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            this.dataGridViewClient.CurrentCell = this.dataGridViewClient.Rows[0].Cells[this.dataGridViewClient.CurrentCell.ColumnIndex];
            btnPrevious.Enabled = false;
            btnNext.Enabled = true;
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            this.dataGridViewClient.CurrentCell = this.dataGridViewClient.Rows[dataGridViewClient.Rows.Count - 1].Cells[this.dataGridViewClient.CurrentCell.ColumnIndex];
            btnNext.Enabled = false;
            btnPrevious.Enabled = true;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewClient.CurrentRow.Index < dataGridViewClient.Rows.Count - 1)
            {
                btnPrevious.Enabled = true;
                this.dataGridViewClient.CurrentCell = this.dataGridViewClient.Rows[this.dataGridViewClient.CurrentRow.Index + 1].Cells[this.dataGridViewClient.CurrentCell.ColumnIndex];
                if (this.dataGridViewClient.CurrentRow.Index == dataGridViewClient.Rows.Count - 1)
                    btnNext.Enabled = false;
            }
            else
            {
                btnNext.Enabled = false;
            }
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewClient.CurrentRow.Index > 0)
            {
                btnNext.Enabled = true;
                this.dataGridViewClient.CurrentCell = this.dataGridViewClient.Rows[this.dataGridViewClient.CurrentRow.Index - 1].Cells[this.dataGridViewClient.CurrentCell.ColumnIndex];
                if (this.dataGridViewClient.CurrentRow.Index == 0)
                    btnPrevious.Enabled = false;
            }
            else
            {
                btnPrevious.Enabled = false;
            }
        }
        #endregion
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearClientTextBox();

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            dataGridViewClient.ClearSelection();
        }

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            btnEditModeClicked = false;

            gbEdit.Visible = false;
            gbMenu.Visible = true;
            gbCreate.Visible = false;

            dataGridViewClient.Enabled = false;
            dataGridViewClient.ClearSelection();

            gbClientTexBox.Enabled = false;

        }
        private void dataGridViewClient_CurrentCellChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewClient.CurrentRow != null && btnEditModeClicked)
            {
                txtClientId.Text = dataGridViewClient.CurrentRow.Cells[0].Value.ToString();
                txtClientName.Text = dataGridViewClient.CurrentRow.Cells[1].Value.ToString();
                txtPrimaryContactName.Text = dataGridViewClient.CurrentRow.Cells[2].Value.ToString();
                txtPrimaryContactCell.Text = dataGridViewClient.CurrentRow.Cells[3].Value.ToString();
                txtPrimaryContactEmail.Text = dataGridViewClient.CurrentRow.Cells[4].Value.ToString();

                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;

                if (dataGridViewClient.CurrentRow.Cells[5].Value.ToString() == "False")
                {
                    rbClientIsDeleted.Checked = true;
                }
                else
                {
                    rbClientIsDeleted_1.Checked = true;
                }
            }
        }
        #endregion
        #region FUNCTIONS
        /// <summary>
        /// IsValidEmail - Check if email is valid
        /// </summary>
        /// <param name="email">string, input email address</param>
        /// <returns>bool, true or false</returns>
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// ClearClientTextBox - clear all textbox in client form
        /// </summary>
        private void ClearClientTextBox()
        {
            txtClientId.Clear();
            txtClientName.Clear();
            txtPrimaryContactName.Clear();
            txtPrimaryContactCell.Clear();
            txtPrimaryContactEmail.Clear();
        }
        /// <summary>
        /// RefreshDataGridViewData -  refresh data grid data
        /// </summary>
        public void RefreshDataGridViewData(DataGridView dataGridView)
        {
            var source = new BindingSource();

            if (dataGridView == dataGridViewClient)
            {
                source = new BindingSource(ClientDataAccess.LoadAllClient(), null);
            }

            dataGridView.DataSource = source;
            dataGridView.AutoResizeColumns();

            int dgv_width = dataGridView.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            this.Width = 430 + dgv_width;

            dataGridViewClient.ClearSelection();
        }
        #endregion

    }
}
