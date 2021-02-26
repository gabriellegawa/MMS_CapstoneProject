﻿using MMSLibrary;
using MMSLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
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

        private void btnTrackAddNew_Click(object sender, EventArgs e)
        {
            TracksForm tracksForm = new TracksForm(this);
            tracksForm.ShowDialog();
        }

        private void btnClientEventAddNew_Click(object sender, EventArgs e)
        {
            ClientEventForm clientEventForm = new ClientEventForm(this);
            clientEventForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshAllDataGridView();
        }

        public void RefreshAllDataGridView()
        {
            RefreshDataGridViewClientEvent();
            RefreshDataGridViewTrackWorker();
            RefreshDataGridViewTrack();
            RefreshDataGridViewClient();
        }

        public void RefreshDataGridViewData<T>(DataGridView dataGridView, List<T> list)
        {
            DataTable dataTable = ToDataTable(list);
            dataGridView.DataSource = dataTable;
            dataGridView.AutoResizeColumns();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            int dgv_width = dataGridView.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            this.Width = 180 + dgv_width;

            dataGridView.ClearSelection();
        }

        public void RefreshDataGridViewClient()
        {
            List<ClientModel> list = ClientDataAccess.LoadAllClient();
            DataGridView dataGridView = dgvClient;
            DataTable dataTable = ToDataTable(list);
            
            dataGridView.DataSource = dataTable;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            dataGridView.Columns["Id"].HeaderText = "Client ID";
            dataGridView.Columns["Name"].HeaderText = "Client Name";
            //dataGridView.Columns["IsDeleted"].Visible = false;

            int dgv_width = dataGridView.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            this.Width = 365 + dgv_width;

            dataGridView.ClearSelection();
        }

        public void RefreshDataGridViewTrackWorker()
        {
            List<TrackWorkerModel> list = TrackWorkerDataAccess.LoadAllTrackWorker();
            DataGridView dataGridView = dgvTrackWorker;
            DataTable dataTable = ToDataTable(list);

            dataGridView.DataSource = dataTable;
            //dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView.AutoResizeColumns();

            dataGridView.Columns["Id"].HeaderText = "Track Worker ID";
            //dataGridView.Columns["IsDeleted"].Visible = false;

            int dgv_width = dataGridView.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);

            this.Width = 365 + dgv_width;

            dataGridView.ClearSelection();
        }

        public void RefreshDataGridViewTrack()
        {
            List<TrackModel> list = TrackDataAccess.LoadAllTrack();
            DataGridView dataGridView = dgvTrack;
            DataTable dataTable = ToDataTable(list);

            dataGridView.DataSource = dataTable;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            dataGridView.Columns["Id"].HeaderText = "Track ID";
            //dataGridView.Columns["IsDeleted"].Visible = false;

            int dgv_width = dataGridView.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            this.Width = 365 + dgv_width;

            dataGridView.ClearSelection();
        }

        public void RefreshDataGridViewClientEvent()
        {
            List<ClientEventModel> list = ClientEventDataAccess.LoadAllClientEvent();
            DataGridView dataGridView = dgvClientEvent;
            DataTable dataTable = ToDataTable(list);

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
            dataTable.Columns["Id"].SetOrdinal(0);
            dataTable.Columns["ClientName"].SetOrdinal(1);
            dataTable.Columns["TrackName"].SetOrdinal(2);

            dataGridView.DataSource = dataTable;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            dataGridView.Columns["IsDeleted"].Visible = false;
            dataGridView.Columns["ClientId"].Visible = false;
            dataGridView.Columns["TrackId"].Visible = false;

            int dgv_width = dataGridView.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            this.Width = 365 + dgv_width;

            dataGridView.ClearSelection();
        }
        private void dgvTrackWorker_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TrackWorkerModel trackWorker = new TrackWorkerModel();

                trackWorker.Id = int.Parse(dgvTrackWorker.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                trackWorker.FirstName = dgvTrackWorker.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
                trackWorker.LastName = dgvTrackWorker.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
                trackWorker.Cell = dgvTrackWorker.Rows[e.RowIndex].Cells["Cell"].Value.ToString();
                trackWorker.Email = dgvTrackWorker.Rows[e.RowIndex].Cells["Email"].Value.ToString();

                if (dgvTrackWorker.Rows[e.RowIndex].Cells["IsCapableCaptain"].Value.ToString() == "True")
                {
                    trackWorker.IsCapableCaptain = true;
                }
                else
                {
                    trackWorker.IsCapableCaptain = false;
                }
                if (dgvTrackWorker.Rows[e.RowIndex].Cells["IsDeleted"].Value.ToString() == "True")
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
            int rowCount = (dgvTrackWorker.DataSource as DataTable).Columns.Count;

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

                if (dgvClient.Rows[e.RowIndex].Cells["IsDeleted"].Value.ToString() == "True")
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

        private void txtClientSearch_TextChanged(object sender, EventArgs e)
        {
            // START with
            //(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name LIKE '{0}%'", searchTextBox.Text);
            // CONTAIN

            string searchQuery = "";
            int rowCount = (dgvClient.DataSource as DataTable).Columns.Count;

            for (int count = 1; count <= rowCount; count++)
            {
                searchQuery += string.Format(dgvClient.Columns[count].HeaderText.ToString() + " LIKE '%{0}%'", txtClientSearch.Text.Trim());
                if (count != rowCount)
                {
                    searchQuery += " OR ";
                }
            }
            (dgvClient.DataSource as DataTable).DefaultView.RowFilter = searchQuery;
        }

        private void dgvTrack_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TrackModel trackModel = new TrackModel();

                trackModel.Id = int.Parse(dgvTrack.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                trackModel.Name = dgvTrack.Rows[e.RowIndex].Cells["Name"].Value.ToString();

                if (dgvTrack.Rows[e.RowIndex].Cells["IsDeleted"].Value.ToString() == "True")
                {
                    trackModel.IsDeleted = true;
                }
                else
                {
                    trackModel.IsDeleted = false;
                }
                TracksForm tracksForm = new TracksForm(this, trackModel);
                tracksForm.ShowDialog();
            }
        }

        private void txtTrackSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = "";

            searchQuery = string.Format("Name LIKE '%{0}%'", txtTrackSearch.Text);

            (dgvTrack.DataSource as DataTable).DefaultView.RowFilter = searchQuery;
        }

        private void dgvClientEvent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ClientEventModel clientEventModel = new ClientEventModel();
                clientEventModel.Id = int.Parse(dgvClientEvent.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                clientEventModel.ClientId = int.Parse(dgvClientEvent.Rows[e.RowIndex].Cells["ClientId"].Value.ToString());
                clientEventModel.TrackId = int.Parse(dgvClientEvent.Rows[e.RowIndex].Cells["TrackId"].Value.ToString());
                clientEventModel.Date = dgvClientEvent.Rows[e.RowIndex].Cells["Date"].Value.ToString();
                clientEventModel.WorkersRequested = int.Parse(dgvClientEvent.Rows[e.RowIndex].Cells["WorkersRequested"].Value.ToString());

                if (dgvClientEvent.Rows[e.RowIndex].Cells["IsLunchProvided"].Value.ToString() == "True")
                {
                    clientEventModel.IsLunchProvided = true;
                }
                else
                {
                    clientEventModel.IsLunchProvided = false;
                }

                if (dgvClientEvent.Rows[e.RowIndex].Cells["IsUsingUpperPaddock"].Value.ToString() == "True")
                {
                    clientEventModel.IsUsingUpperPaddock = true;
                }
                else
                {
                    clientEventModel.IsUsingUpperPaddock = false;
                }

                if (dgvClientEvent.Rows[e.RowIndex].Cells["IsUsingMiddlePaddock"].Value.ToString() == "True")
                {
                    clientEventModel.IsUsingMiddlePaddock = true;
                }
                else
                {
                    clientEventModel.IsUsingMiddlePaddock = false;
                }

                if (dgvClientEvent.Rows[e.RowIndex].Cells["IsUsingLowerPaddock"].Value.ToString() == "True")
                {
                    clientEventModel.IsUsingLowerPaddock = true;
                }
                else
                {
                    clientEventModel.IsUsingLowerPaddock = false;
                }

                if (dgvClientEvent.Rows[e.RowIndex].Cells["WorkerCalloutSent"].Value.ToString() == "True")
                {
                    clientEventModel.WorkerCalloutSent = true;
                }
                else
                {
                    clientEventModel.WorkerCalloutSent = false;
                }

                if (dgvClientEvent.Rows[e.RowIndex].Cells["RequireSafetyDemo"].Value.ToString() == "True")
                {
                    clientEventModel.RequireSafetyDemo = true;
                }
                else
                {
                    clientEventModel.RequireSafetyDemo = false;
                }

                if (dgvClientEvent.Rows[e.RowIndex].Cells["IsDeleted"].Value.ToString() == "True")
                {
                    clientEventModel.IsDeleted = true;
                }
                else
                {
                    clientEventModel.IsDeleted = false;
                }
                ClientEventForm tracksForm = new ClientEventForm(this, clientEventModel);
                tracksForm.ShowDialog();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {

                case 0:
                    {
                        RefreshDataGridViewClient();
                        break;
                    }
                case 1:
                    {
                        RefreshDataGridViewTrackWorker();
                        break;
                    }
                case 2:
                    {
                        RefreshDataGridViewTrack();
                        break;
                    }
                case 3:
                    {
                        RefreshDataGridViewClientEvent();
                        break;
                    }
            }

        }
    }
}
