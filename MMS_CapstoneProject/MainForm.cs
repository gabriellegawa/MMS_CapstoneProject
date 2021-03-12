using MMSLibrary;
using MMSLibrary.Data_Access;
using MMSLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Windows.Forms;

namespace MMS_CapstoneProject
{
    public partial class MainForm : Form
    {
        // main form variable
        private static List<int> _clientEventIdList = new List<int>();
        private static string stringBodyHTML;
        List<int> allClientEventTrackWorkerIdList = new List<int>();
        /// <summary>
        /// MainForm - display initial main form
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// btnClientAddNew_Click - add new client record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClientAddNew_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm(this);
            clientForm.ShowDialog();
        }

        /// <summary>
        /// btnTrackWorkerAddNew_Click - add new track worker record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTrackWorkerAddNew_Click(object sender, EventArgs e)
        {
            TrackWorkerForm trackWorkerForm = new TrackWorkerForm(this);
            trackWorkerForm.ShowDialog();
        }

        /// <summary>
        /// btnTrackAddNew_Click - add new track record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTrackAddNew_Click(object sender, EventArgs e)
        {
            TracksForm tracksForm = new TracksForm(this);
            tracksForm.ShowDialog();
        }

        /// <summary>
        /// btnClientEventAddNew_Click - add new client event record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClientEventAddNew_Click(object sender, EventArgs e)
        {
            ClientEventForm clientEventForm = new ClientEventForm(this);
            clientEventForm.ShowDialog();
        }

        /// <summary>
        /// MainForm_Load - load event to initial every datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshAllDataGridView();
        }

        /// <summary>
        /// RefreshAllDataGridView - refresh every datagridview
        /// </summary>
        public void RefreshAllDataGridView()
        {
            RefreshDataGridViewClientEvent();
            RefreshDataGridViewTrackWorker();
            RefreshDataGridViewTrack();
            RefreshDataGridViewClient();
        }

        /// <summary>
        /// OBSOLETE
        /// RefreshDataGridViewData - refresh datagridview
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataGridView"></param>
        /// <param name="list"></param>
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

        /// <summary>
        /// RefreshDataGridViewClient - refresh client data grid view
        /// </summary>
        public void RefreshDataGridViewClient()
        {
            List<ClientModel> list = ClientDataAccess.LoadAllClient();
            DataGridView dataGridView = dgvClient;
            DataTable dataTable = ToDataTable(list);

            dataGridView.DataSource = dataTable;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            //dataGridView.Columns["ClientID"].HeaderText = "Client ID";
            dataGridView.Columns["Name"].HeaderText = "Client Name";
            dataGridView.Columns["IsDeleted"].Visible = false;

            int dgv_width = dataGridView.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            this.Width = 365 + dgv_width;

            dataGridView.ClearSelection();
        }

        /// <summary>
        /// RefreshDataGridViewTrackWorker - refresh track worker data grid view
        /// </summary>
        public void RefreshDataGridViewTrackWorker()
        {
            List<TrackWorkerModel> list = TrackWorkerDataAccess.LoadAllTrackWorker();
            DataGridView dataGridView = dgvTrackWorker;
            DataTable dataTable = ToDataTable(list);

            //dataTable.Columns["TrackWorkerID"].ColumnName = "Track Worker ID";

            dataGridView.DataSource = dataTable;
            //dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView.AutoResizeColumns();
            dataGridView.AutoResizeRows();

            //dataGridView.Columns["Id"].HeaderText = "Track Worker ID";
            //dataGridView.Columns["IsDeleted"].Visible = false;

            int dgv_width = dataGridView.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);

            this.Width = 365 + dgv_width;

            dataGridView.ClearSelection();
            txtTrackWorkerSearch.Clear();
        }

        /// <summary>
        /// RefreshDataGridViewTrack - refresh track data grid view
        /// </summary>
        public void RefreshDataGridViewTrack()
        {
            List<TrackModel> list = TrackDataAccess.LoadAllTrack();
            DataGridView dataGridView = dgvTrack;
            DataTable dataTable = ToDataTable(list);

            dataGridView.DataSource = dataTable;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            //dataGridView.Columns["TrackID"].HeaderText = "Track ID";
            //dataGridView.Columns["IsDeleted"].Visible = false;

            int dgv_width = dataGridView.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            this.Width = 365 + dgv_width;

            dataGridView.ClearSelection();
        }

        /// <summary>
        /// RefreshDataGridViewClientEvent - refresh client event data grid view
        /// </summary>
        public void RefreshDataGridViewClientEvent()
        {
            List<ClientEventModel> list = ClientEventDataAccess.LoadAllClientEvent();
            DataGridView dataGridView = dgvClientEvent;
            DataTable dataTable = ToDataTable(list);

            foreach (DataRow row in dataTable.Rows)
            {
                if (row["ClientID"] != null)
                {
                    ClientModel clientModel = ClientDataAccess.LoadClient((int)row["ClientID"]);
                    row["ClientName"] = clientModel.Name;
                }
                if (row["TrackID"] != null)
                {

                    TrackModel trackModel = TrackDataAccess.LoadTrack((int)row["TrackID"]);
                    row["TrackName"] = trackModel.Name;
                }
            }
            dataTable.Columns["ClientEventID"].SetOrdinal(0);
            dataTable.Columns["ClientName"].SetOrdinal(1);
            dataTable.Columns["TrackName"].SetOrdinal(2);

            dataGridView.DataSource = dataTable;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            dataGridView.Columns["IsDeleted"].Visible = false;
            dataGridView.Columns["ClientId"].Visible = false;
            dataGridView.Columns["TrackId"].Visible = false;

            int dgv_width = dataGridView.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            this.Width = 250 + dgv_width;

            dataGridView.ClearSelection();
        }

        /// <summary>
        /// dgvTrackWorker_CellClick - track worker data grid view cell click to update record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvTrackWorker_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TrackWorkerModel trackWorker = new TrackWorkerModel();

                trackWorker.TrackWorkerID = int.Parse(dgvTrackWorker.Rows[e.RowIndex].Cells["TrackWorkerID"].Value.ToString());
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

        /// <summary>
        /// txtTrackWorkerSearch_TextChanged - for filtering track worker data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTrackWorkerSearch_TextChanged(object sender, EventArgs e)
        {
            // START with
            //(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name LIKE '{0}%'", searchTextBox.Text);
            // CONTAIN

            string searchQuery = "";
            int rowCount = (dgvTrackWorker.DataSource as DataTable).Columns.Count;

            // 1 is because we are not filtering by id
            for (int count = 1; count < rowCount - 3; count++)
            {
                searchQuery += string.Format(dgvTrackWorker.Columns[count].HeaderText.ToString() + " LIKE '%{0}%'", txtTrackWorkerSearch.Text.Trim());
                if (count != rowCount - 4)
                {
                    searchQuery += " OR ";
                }
            }
            (dgvTrackWorker.DataSource as DataTable).DefaultView.RowFilter = searchQuery;
            dgvTrackWorker.AutoResizeColumns();
            dgvTrackWorker.AutoResizeRows();
        }

        /// <summary>
        /// ToDataTable - convert list into datatable
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

        /// <summary>
        /// dgvClient_CellClick - client datagridview cell click event for updating client record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ClientModel clientModel = new ClientModel();

                clientModel.ClientID = int.Parse(dgvClient.Rows[e.RowIndex].Cells["ClientID"].Value.ToString());
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

        /// <summary>
        /// txtClientSearch_TextChanged - for filtering client data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtClientSearch_TextChanged(object sender, EventArgs e)
        {
            // START with
            //(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name LIKE '{0}%'", searchTextBox.Text);
            // CONTAIN

            string searchQuery = "";
            int rowCount = (dgvClient.DataSource as DataTable).Columns.Count;

            for (int count = 1; count < rowCount - 1; count++)
            {
                searchQuery += string.Format(dgvClient.Columns[count].HeaderCell.ToString() + " LIKE '%{0}%'", txtClientSearch.Text.Trim());
                if (count != rowCount - 2)
                {
                    searchQuery += " OR ";
                }
            }
            (dgvClient.DataSource as DataTable).DefaultView.RowFilter = searchQuery;

        }

        /// <summary>
        /// dgvTrack_CellClick - cell click event for updating track record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvTrack_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TrackModel trackModel = new TrackModel();

                trackModel.TrackID = int.Parse(dgvTrack.Rows[e.RowIndex].Cells["TrackID"].Value.ToString());
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

        /// <summary>
        /// txtTrackSearch_TextChanged - for filtering track data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTrackSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = "";

            searchQuery = string.Format("Name LIKE '%{0}%'", txtTrackSearch.Text);

            (dgvTrack.DataSource as DataTable).DefaultView.RowFilter = searchQuery;
        }

        /// <summary>
        /// dgvClientEvent_CellClick - client event cell click event for updating
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvClientEvent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ClientEventModel clientEventModel = new ClientEventModel();
                clientEventModel.ClientEventID = int.Parse(dgvClientEvent.Rows[e.RowIndex].Cells["ClientEventID"].Value.ToString());
                clientEventModel.ClientID = int.Parse(dgvClientEvent.Rows[e.RowIndex].Cells["ClientID"].Value.ToString());
                clientEventModel.TrackID = int.Parse(dgvClientEvent.Rows[e.RowIndex].Cells["TrackID"].Value.ToString());
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

        /// <summary>
        /// tabControl_SelectedIndexChanged - tab control index change to change the form width
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
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
                case 4:
                    {
                        this.Width = 800;
                        break;
                    }
            }

        }

        /// <summary>
        /// btnSelectEvent_Click - for adding client event for mailing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectEvent_Click(object sender, EventArgs e)
        {
            DataGridViewForm dataGridViewForm = new DataGridViewForm(this, ClientEventDataAccess.LoadClientEvent());
            dataGridViewForm.ShowDialog();
        }

        /// <summary>
        /// SetClientEventIdList - for passing client event from datagridview form into mainform
        /// </summary>
        /// <param name="clientEventIdList"> client Event Id List</param>
        public void SetClientEventIdList(List<int> clientEventIdList)
        {
            _clientEventIdList = clientEventIdList;
            stringBodyHTML = "";
        }

        /// <summary>
        /// SetWebBrowserTable - for creating html mail
        /// </summary>
        public void SetWebBrowserTable()
        {
            List<ClientEventModel> clientEventModelsList = new List<ClientEventModel>();
            allClientEventTrackWorkerIdList = new List<int>();
            foreach (int clientEventId in _clientEventIdList)
            {
                ClientEventModel clientEvent = ClientEventDataAccess.LoadClientEvent(clientEventId);
                clientEvent.TrackWorkersId = ClientEvents_TrackWorkersDataAccess.LoadClientEventTrackWorkerIDList(clientEventId);
                allClientEventTrackWorkerIdList = allClientEventTrackWorkerIdList.Union(clientEvent.TrackWorkersId).ToList();
                clientEventModelsList.Add(clientEvent);
            }

            stringBodyHTML += "<table style=\"border: 1px solid black;\">";
            stringBodyHTML += "<tr>";
            stringBodyHTML += "<td></td>";
            foreach (ClientEventModel clientEvent in clientEventModelsList)
            {
                ClientModel client = ClientDataAccess.LoadClient(clientEvent.ClientID);
                stringBodyHTML += "<td style=\"border: 1px solid black;\">" + client.Name + "</td>";
            }
            stringBodyHTML += "</tr>";
            stringBodyHTML += "<tr>";
            stringBodyHTML += "<td></td>";
            foreach (ClientEventModel clientEvent in clientEventModelsList)
            {
                stringBodyHTML += "<td style=\"border: 1px solid black;\">" + clientEvent.Date + "</td>";
            }
            stringBodyHTML += "</tr>";
            stringBodyHTML += "<tr>";
            stringBodyHTML += "<td style=\"border: 1px solid black;\"># Workers Needed</td>";
            foreach (ClientEventModel clientEvent in clientEventModelsList)
            {
                stringBodyHTML += "<td style=\"border: 1px solid black;\">" + clientEvent.WorkersRequested + "</td>";
            }
            stringBodyHTML += "</tr>";
            stringBodyHTML += "<tr>";
            stringBodyHTML += "<td style=\"border: 1px solid black;\">Track</td>";
            foreach (ClientEventModel clientEvent in clientEventModelsList)
            {
                TrackModel track = TrackDataAccess.LoadTrack(clientEvent.TrackID);
                stringBodyHTML += "<td style=\"border: 1px solid black;\">" + track.Name + "</td>";
            }
            stringBodyHTML += "</tr>";

            stringBodyHTML += "<tr><td><b>Worker Name</b></td></tr>";
            foreach (int trackWorkerId in allClientEventTrackWorkerIdList)
            {
                stringBodyHTML += "<tr>";
                TrackWorkerModel trackWorker = TrackWorkerDataAccess.LoadTrackWorker(trackWorkerId);
                stringBodyHTML += "<td style=\"border: 1px solid black;\">" + trackWorker.FullName() + "</td>";
                foreach (ClientEventModel clientEvent in clientEventModelsList)
                {
                    if (clientEvent.TrackWorkersId.Contains(trackWorkerId))
                    {
                        stringBodyHTML += "<td style=\"border: 1px solid black;\">X</td>";
                    }
                    else
                    {
                        stringBodyHTML += "<td style=\"border: 1px solid black;\">&nbsp;</td>";
                    }
                }
                stringBodyHTML += "</tr>";
            }
            stringBodyHTML += "</table>";

            //webBrowser.DocumentText += stringTableHTML;
        }

        /// <summary>
        /// btnSend_Click - for sending email
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            stringBodyHTML = "<p>" + txtEmailBody.Text.ToString() + "</p>" + stringBodyHTML;
            webBrowser.DocumentText += stringBodyHTML;

            MailAddress from = new MailAddress("ben@contoso.com", "Ben Miller");
            string fromPassword = "password";
            MailMessage message = new MailMessage();
            message.From = from;
            message.IsBodyHtml = true;

            message.Subject = txtEmailSubject.Text.ToString();
            message.Body = stringBodyHTML;

            foreach (int trackWorkerId in allClientEventTrackWorkerIdList)
            {
                TrackWorkerModel trackWorker = TrackWorkerDataAccess.LoadTrackWorker(trackWorkerId);
                //BCC
                message.Bcc.Add(trackWorker.Email);
                //To - regular
                //message.To.Add(trackWorker.Email);
            }

            //SmtpClient client = new SmtpClient
            //{
            //    Host = "smtp.gmail.com",
            //    Port = 587,
            //    EnableSsl = true,
            //    DeliveryMethod = SmtpDeliveryMethod.Network,
            //    UseDefaultCredentials = false,
            //    Credentials = new NetworkCredential(from.Address, fromPassword)
            //};

            var client = new SmtpClient("smtp.mailtrap.io", 2525)
            {
                Credentials = new NetworkCredential("e105e0282339a3", "ac1ce2513bda52"),
                EnableSsl = true
            };


            Console.WriteLine("Sending an email message to {0} and {1}.",
                from.DisplayName, message.Bcc.ToString());
            try
            {
                client.Send(message);
            }
            catch (SmtpException ex)
            {
                MessageBox.Show("Some text", "Some title", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //using (var message = new MailMessage(fromAddress, toAddress)
            //{
            //    Subject = subject,
            //    Body = body
            //})
            //{
            //    smtp.Send(message);
            //}

        }
    }
}
