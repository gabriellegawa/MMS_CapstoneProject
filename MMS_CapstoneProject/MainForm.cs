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

            Console.WriteLine("ASD");

            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //TODO: Better make it into a function since we are going to use it multiple time to refresh the data
            var source = new BindingSource(SqliteDataAccess.LoadAllClient(), null);

            dataGridView1.DataSource = source;
            dataGridView1.AutoResizeColumns();

            int dgv_width = dataGridView1.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);

            this.Width = 373 + dgv_width;

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            string clientName = txtClientName.Text;
            string primaryContactName = txtPrimaryContactName.Text;
            string primaryContactCell = txtPrimaryContactCell.Text;
            string primaryContactEmail = txtPrimaryContactEmail.Text;

            ClientModel client = new ClientModel(clientName, primaryContactName, primaryContactCell, primaryContactCell, false);

            
            Console.WriteLine(clientName);
        }
    }
}
