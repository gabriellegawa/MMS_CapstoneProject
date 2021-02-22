using MMSLibrary;
using MMSLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMS_CapstoneProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClientAddNew_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm(this);
            clientForm.ShowDialog();
        }

        private void btnTrackWorkerAddNew_Click(object sender, EventArgs e)
        {
            TrackWorkerForm trackWorkerForm = new TrackWorkerForm(this);
            trackWorkerForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshAllDataGridView();
        }
        public void RefreshAllDataGridView()
        {
            RefreshDataGridViewData(dgvTrackWorker, TrackWorkerDataAccess.LoadAllTrackWorker());
            RefreshDataGridViewData(dgvClient, ClientDataAccess.LoadAllClient());
        }

        public void RefreshDataGridViewData<T>(DataGridView dataGridView, List<T> list)
        {
            dataGridView.DataSource = ToDataTable(list);
            dataGridView.AutoResizeColumns();

            int dgv_width = dataGridView.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            this.Width = 365 + dgv_width;

            dataGridView.ClearSelection();
        }

        private void dgvTrackWorker_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                TrackWorkerModel trackWorker = new TrackWorkerModel();

                trackWorker.Id = int.Parse(dgvTrackWorker.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                trackWorker.FirstName = dgvTrackWorker.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
                trackWorker.LastName = dgvTrackWorker.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
                trackWorker.Cell = dgvTrackWorker.Rows[e.RowIndex].Cells["Cell"].Value.ToString();
                trackWorker.Email = dgvTrackWorker.Rows[e.RowIndex].Cells["Email"].Value.ToString();

                if (dgvTrackWorker.Rows[e.RowIndex].Cells["IsCapableCaptain"].Value.ToString() == "1")
                {
                    trackWorker.IsCapableCaptain = true;
                }
                else
                {
                    trackWorker.IsCapableCaptain = false;
                }
                if (dgvTrackWorker.Rows[e.RowIndex].Cells["IsDeleted"].Value.ToString() == "1")
                {
                    trackWorker.IsDeleted = true;
                }
                else
                {
                    trackWorker.IsDeleted = false;
                }
                TrackWorkerForm trackWorkerForm = new TrackWorkerForm(this, trackWorker);
                trackWorkerForm.ShowDialog();
            }
        }

        private void txtTrackWorkerSearch_TextChanged(object sender, EventArgs e)
        {
            // START with
            //(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name LIKE '{0}%'", searchTextBox.Text);
            // CONTAIN

            string searchQuery = "";
            int rowCount = (dgvTrackWorker.DataSource as DataTable).Rows.Count;

            // 1 is because we are not filtering by id
            for (int count = 1; count <= rowCount; count++)
            {
                searchQuery += string.Format(dgvTrackWorker.Columns[count].HeaderText.ToString() + " LIKE '%{0}%'", txtTrackWorkerSearch.Text.Trim());
                if (count != rowCount)
                {
                    searchQuery += " OR ";
                }
            }
            (dgvTrackWorker.DataSource as DataTable).DefaultView.RowFilter = searchQuery;
        }

        /// <summary>
        /// credit : https://stackoverflow.com/questions/18100783/how-to-convert-a-list-into-data-table
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Defining type of data column gives proper data table 
                var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name, type);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

        private void dgvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ClientModel clientModel = new ClientModel();

                clientModel.Id = int.Parse(dgvClient.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                clientModel.Name = dgvClient.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                clientModel.PrimaryContactName = dgvClient.Rows[e.RowIndex].Cells["PrimaryContactName"].Value.ToString();
                clientModel.PrimaryContactCell = dgvClient.Rows[e.RowIndex].Cells["PrimaryContactCell"].Value.ToString();
                clientModel.PrimaryContactEmail = dgvClient.Rows[e.RowIndex].Cells["PrimaryContactEmail"].Value.ToString();

                if (dgvClient.Rows[e.RowIndex].Cells["IsDeleted"].Value.ToString() == "1")
                {
                    clientModel.IsDeleted = true;
                }
                else
                {
                    clientModel.IsDeleted = false;
                }
                ClientForm clientForm = new ClientForm(this, clientModel);
                clientForm.ShowDialog();
            }
        }
    }
}
