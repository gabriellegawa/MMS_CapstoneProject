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


            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //TODO: Better make it into a function since we are going to use it multiple time to refresh the data
            RefreshDataGridViewData();

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            string clientName = txtClientName.Text;
            string primaryContactName = txtPrimaryContactName.Text;
            string primaryContactCell = txtPrimaryContactCell.Text;
            string primaryContactEmail = txtPrimaryContactEmail.Text;

            //ClientModel client = new ClientModel(clientName, primaryContactName, primaryContactCell, primaryContactCell, false);
            ClientModel client = new ClientModel();
            client.Name = clientName;
            client.PrimaryContactName = primaryContactName;
            client.PrimaryContactCell = primaryContactCell;
            client.PrimaryContactEmail = primaryContactEmail;

            SqliteDataAccess.SaveClient(client);
            RefreshDataGridViewData();

            Console.WriteLine(client);
            Console.WriteLine(client);
        }

        /// <summary>
        /// re
        /// </summary>
        public void RefreshDataGridViewData()
        {
            var source = new BindingSource(SqliteDataAccess.LoadAllClient(), null);

            dataGridViewClient.DataSource = source;
            dataGridViewClient.AutoResizeColumns();

            int dgv_width = dataGridViewClient.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);

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

        }
    }
}
