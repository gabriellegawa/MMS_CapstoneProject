﻿using MMSLibrary;
using MMSLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace MMS_CapstoneProject
{
    public partial class DataGridViewForm : Form
    {
        private readonly ClientEventForm _clientEventForm;
        private readonly MainForm _mainForm;
        public DataGridViewForm(ClientEventForm clientEventForm, List<ClientModel> list)
        {
            InitializeComponent();
            dgvData.DataSource = ToDataTable(list);
            dgvData.MultiSelect = false;

            dgvData.AutoResizeColumns();
            int dgv_width = dgvData.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            this.Width = 85 + dgv_width;

            btnSelect.Click += btnAddClient_Click;
            _clientEventForm = clientEventForm;
        }

        public DataGridViewForm(ClientEventForm clientEventForm, List<TrackModel> list)
        {
            InitializeComponent();
            dgvData.DataSource = ToDataTable(list);
            dgvData.MultiSelect = false;

            dgvData.AutoResizeColumns();
            int dgv_width = dgvData.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            this.Width = 85 + dgv_width;

            btnSelect.Click += btnAddTrack_Click;
            _clientEventForm = clientEventForm;
        }

        public DataGridViewForm(ClientEventForm clientEventForm, List<TrackWorkerModel> list, List<int> trackWorkerIdList)
        {
            InitializeComponent();
            var dataTable = ToDataTable(list);
            dataTable.Columns.Add("Selected", typeof(bool)).SetOrdinal(0);
            dgvData.DataSource = dataTable;
            dgvData.MultiSelect = false;

            dgvData.AutoResizeColumns();
            int dgv_width = dgvData.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            this.Width = 85 + dgv_width;

            if (trackWorkerIdList != null)
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    DataGridViewCheckBoxCell cell = row.Cells[0] as DataGridViewCheckBoxCell;
                    cell.Value = false;
                    foreach (int trackWorkerId in trackWorkerIdList)
                    {
                        if (row.Cells[1].Value.ToString() == trackWorkerId.ToString())
                        {
                            cell.Value = true;
                            //row.Cells[0].Value = true;
                        }
                    }
                }
            }

            btnSelect.Click += btnAddTrackWorker_Click;
            _clientEventForm = clientEventForm;
        }
        /// <summary>
        /// FOR MAIL
        /// </summary>
        /// <param name="mainForm"></param>
        /// <param name="clientEventsList"></param>
        public DataGridViewForm(MainForm mainForm, List<ClientEventModel> clientEventsList)
        {
            InitializeComponent();

            DataGridView dataGridView = dgvData;
            DataTable dataTable = ToDataTable(clientEventsList);

            foreach (DataRow row in dataTable.Rows)
            {
                if (row["ClientId"] != null)
                {
                    ClientModel clientModel = ClientDataAccess.LoadClient((int)row["ClientId"]);
                    row["ClientName"] = clientModel.Name;
                }
                if (row["TrackId"] != null)
                {

                    TrackModel trackModel = TrackDataAccess.LoadTrack((int)row["TrackId"]);
                    row["TrackName"] = trackModel.Name;
                }
            }
            dataTable.Columns.Add("Applied", typeof(bool)).SetOrdinal(0);
            dataTable.Columns["Id"].SetOrdinal(1);
            dataTable.Columns["ClientName"].SetOrdinal(2);
            dataTable.Columns["TrackName"].SetOrdinal(3);

            dataGridView.DataSource = dataTable;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            dataGridView.Columns["IsDeleted"].Visible = false;
            dataGridView.Columns["ClientId"].Visible = false;
            dataGridView.Columns["TrackId"].Visible = false;

            int dgv_width = dataGridView.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            this.Width = 365 + dgv_width;

            dataGridView.ClearSelection();

            btnSelect.Click += btnAddClientEvent_Click;
            _mainForm = mainForm;
        }

        public DataGridViewForm(ClientEventForm clientEventForm, List<int> trackWorkerIDList)
        {
            InitializeComponent();
            List<TrackWorkerModel> appliedTrackWorkerIdList = new List<TrackWorkerModel>();

            foreach(int trackWorkerID in trackWorkerIDList)
            {
                appliedTrackWorkerIdList.Add(TrackWorkerDataAccess.LoadTrackWorker(trackWorkerID));
            }

            var dataTable = ToDataTable(appliedTrackWorkerIdList);
            dataTable.Columns.Add("Selected", typeof(bool)).SetOrdinal(0);
            dataTable.Columns.Add("Present", typeof(bool)).SetOrdinal(0);
            dgvData.DataSource = dataTable;
            dgvData.MultiSelect = false;

            _clientEventForm = clientEventForm;
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count > 0)
            {
                _clientEventForm.SetClientEventClientId(Convert.ToInt32(dgvData.CurrentRow.Cells["Id"].Value), dgvData.CurrentRow.Cells["Name"].Value.ToString());
                this.Close();
            }
        }

        private void btnAddTrack_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count > 0)
            {
                _clientEventForm.SetClientEventTrackId(Convert.ToInt32(dgvData.CurrentRow.Cells["Id"].Value), dgvData.CurrentRow.Cells["Name"].Value.ToString());
                this.Close();
            }
        }

        private void btnAddTrackWorker_Click(object sender, EventArgs e)
        {
            List<int> trackWorkerIdList = new List<int>();
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                var isChecked = row.Cells[0].Value.ToString();

                if (isChecked == "True")
                {
                    trackWorkerIdList.Add(int.Parse(row.Cells[1].Value.ToString()));
                }
            }

            if (trackWorkerIdList.Count() > 0)
            {
                _clientEventForm.SetClientEventTrackWorkerId(trackWorkerIdList);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select atleast 1 worker", "Empty Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddClientEvent_Click(object sender, EventArgs e)
        {
            List<int> clientEventIdList = new List<int>();
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                var isChecked = row.Cells[0].Value.ToString();

                if (isChecked == "True")
                {
                    clientEventIdList.Add(int.Parse(row.Cells[1].Value.ToString()));
                }
            }

            if (clientEventIdList.Count() > 0)
            {
                _mainForm.SetClientEventIdList(clientEventIdList);
                _mainForm.SetWebBrowserTable();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select atleast 1 event", "Empty Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void txtDataGridViewSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = "";
            int rowCount = (dgvData.DataSource as DataTable).Columns.Count;

            // 1 is because we are not filtering by id
            for (int count = 1; count < rowCount - 1; count++)
            {
                if (dgvData.Columns[count].HeaderText.ToString() != "Id" && dgvData.Columns[count].HeaderText.ToString().StartsWith("Is") == false)
                {
                    searchQuery += string.Format(dgvData.Columns[count].HeaderText.ToString() + " LIKE '%{0}%'", txtDataGridViewSearch.Text.Trim());

                    searchQuery += " OR ";
                }
            }
            searchQuery = searchQuery.Substring(0, searchQuery.Length - 3);

            (dgvData.DataSource as DataTable).DefaultView.RowFilter = searchQuery;
        }
    }
}
