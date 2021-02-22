using MMSLibrary;
using MMSLibrary.DataAccess;
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
    public partial class ClientForm : Form
    {
        private readonly MainForm _mainForm;
        public ClientForm(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            btnEnter.Click += btnCreate_Click;
        }
        public ClientForm(MainForm mainForm, ClientModel clientModel)
        {
            _mainForm = mainForm;
            InitializeComponent();
            btnEnter.Click += btnUpdate_Click;

            txtClientId.Text = clientModel.Id.ToString();
            txtClientName.Text = clientModel.Name;
            txtClientPrimaryContactName.Text = clientModel.PrimaryContactName;
            txtClientPrimaryContactCell.Text = clientModel.PrimaryContactCell;
            txtClientPrimaryContactEmail.Text = clientModel.PrimaryContactEmail;
            
            if (clientModel.IsDeleted)
            {
                rdoIsDeleted_Enabled.Checked = true;
            }
            else
            {
                rdoIsDeleted_Disabled.Checked = true;
            }

            btnEnter.Text = "Update";
        }
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

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            _mainForm.RefreshAllDataGridView();
        }

        private void btnEscape_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClientId.Clear();
            txtClientName.Clear();
            txtClientPrimaryContactName.Clear();
            txtClientPrimaryContactCell.Clear();
            txtClientPrimaryContactEmail.Clear();
            rdoIsDeleted_Enabled.Checked = true;
        }
    }
}
