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
            this.Width = 430 + dgv_width;

            dataGridViewClient.ClearSelection();
        }

        // REPLACED WITH CURRENT CELL CHANGED
        //private void dataGridViewClient_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        DataGridViewRow row = dataGridViewClient.Rows[e.RowIndex];
        //        txtClientId.Text = row.Cells[0].Value.ToString();
        //        txtClientName.Text = row.Cells[1].Value.ToString();
        //        txtPrimaryContactName.Text = row.Cells[2].Value.ToString();
        //        txtPrimaryContactCell.Text = row.Cells[3].Value.ToString();
        //        txtPrimaryContactEmail.Text = row.Cells[4].Value.ToString();


        //    }
        //    btnDelete.Enabled = true;
        //    btnUpdate.Enabled = true;
        //    btnAddNew.Enabled = false;
        //}

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

            dataGridViewClient.ClearSelection();
        }

        private void btnCreateNewMode_Click(object sender, EventArgs e)
        {
            gbEdit.Visible = false;
            gbMenu.Visible = false;
            gbCreate.Visible = true;
            gbClientTexBox.Enabled = true;

            dataGridViewClient.Enabled = false;
        }

        private void btnEditMode_Click(object sender, EventArgs e)
        {
            gbEdit.Visible = true;
            gbMenu.Visible = false;
            gbCreate.Visible = false;
            gbClientTexBox.Enabled = true;

            dataGridViewClient.Enabled = true;
        }

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            gbEdit.Visible = false;
            gbMenu.Visible = true;
            gbCreate.Visible = false;

            dataGridViewClient.Enabled = false;
            dataGridViewClient.ClearSelection();

            gbClientTexBox.Enabled = false;

            txtClientId.Clear();
            txtClientName.Clear();
            txtPrimaryContactName.Clear();
            txtPrimaryContactCell.Clear();
            txtPrimaryContactEmail.Clear();
        }

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

        private void dataGridViewClient_CurrentCellChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewClient.CurrentRow != null)
            {
                txtClientId.Text = dataGridViewClient.CurrentRow.Cells[0].Value.ToString();
                txtClientName.Text = dataGridViewClient.CurrentRow.Cells[1].Value.ToString();
                txtPrimaryContactName.Text = dataGridViewClient.CurrentRow.Cells[2].Value.ToString();
                txtPrimaryContactCell.Text = dataGridViewClient.CurrentRow.Cells[3].Value.ToString();
                txtPrimaryContactEmail.Text = dataGridViewClient.CurrentRow.Cells[4].Value.ToString();

                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnAddNew.Enabled = false;
            }
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
    }
}
