using MMSLibrary;
using MMSLibrary.Class_Model;
using MMSLibrary.Data_Access;
using MMSLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace MMS_CapstoneProject
{
    public partial class ClientEventForm : Form
    {
        // client event form variable
        private readonly MainForm _mainForm;
        private static ClientEventModel _clientEvent = new ClientEventModel();
        private static List<ClientEvents_TrackWorkersModel> _clientsEvents_TrackWorkers = new List<ClientEvents_TrackWorkersModel>();

        /// <summary>
        /// ClientEventForm - for creating new client event record
        /// </summary>
        /// <param name="mainForm">main form</param>
        public ClientEventForm(MainForm mainForm)
        {
            _clientEvent = new ClientEventModel();
            _clientsEvents_TrackWorkers = new List<ClientEvents_TrackWorkersModel>();
            _mainForm = mainForm;
            InitializeComponent();

            btnEnter.Click += btnClientEventAdd_Click;
        }

        /// <summary>
        /// ClientEventForm - for updating client event record
        /// </summary>
        /// <param name="mainForm">main form</param>
        /// <param name="clientEventModel">client event record</param>
        public ClientEventForm(MainForm mainForm, ClientEventModel clientEventModel)
        {
            _mainForm = mainForm;
            InitializeComponent();
            btnEnter.Click += btnClientEventUpdate_Click;

            btnEnter.Text = "&Update";

            // load client event data to the form
            _clientEvent = clientEventModel;
            ClientModel clientModel = ClientDataAccess.LoadClient(_clientEvent.ClientID);
            TrackModel trackModel = TrackDataAccess.LoadTrack(_clientEvent.TrackID);
            _clientsEvents_TrackWorkers = ClientEvents_TrackWorkersDataAccess.LoadClientEventTrackWorker(clientEventModel.ClientEventID);

            txtClientEventId.Text = clientEventModel.ClientEventID.ToString();
            txtClientId.Text = clientModel.Name.ToString();
            txtTrackID.Text = trackModel.Name.ToString();

            txtClientEventDate.Text = _clientEvent.Date.ToString();
            txtWorkerRequested.Text = _clientEvent.WorkersRequested.ToString();
            if (_clientEvent.IsLunchProvided)
            {
                rdoClientEventIsLunchProvided_True.Checked = true;
            }
            else
            {
                rdoClientEventIsLunchProvided_False.Checked = true;
            }

            if (_clientEvent.IsUsingUpperPaddock)
            {
                cbClientEventIsUsingUpperPaddock.Checked = true;
            }
            else
            {
                cbClientEventIsUsingUpperPaddock.Checked = false;
            }

            if (_clientEvent.IsUsingMiddlePaddock)
            {
                cbClientEventIsUsingMiddlePaddock.Checked = true;
            }
            else
            {
                cbClientEventIsUsingMiddlePaddock.Checked = false;
            }

            if (_clientEvent.IsUsingLowerPaddock)
            {
                cbClientEventIsUsingLowerPaddock.Checked = true;
            }
            else
            {
                cbClientEventIsUsingLowerPaddock.Checked = false;
            }

            if (_clientEvent.WorkerCalloutSent)
            {
                rdoClientEventWorkerCalloutSent_True.Checked = true;
            }
            else
            {
                rdoClientEventWorkerCalloutSent_False.Checked = true;
            }

            if (_clientEvent.RequireSafetyDemo)
            {
                rdoClientEventRequireSafetyDemo_True.Checked = true;
            }
            else
            {
                rdoClientEventRequireSafetyDemo_False.Checked = true;
            }

            if (_clientEvent.IsDeleted)
            {
                rdoClientEventIsDeleted_Disabled.Checked = true;
            }
            else
            {
                rdoClientEventIsDeleted_Enabled.Checked = true;
            }
        }

        /// <summary>
        /// btnClientAdd_Click - for adding client for client event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClientAdd_Click(object sender, EventArgs e)
        {
            DataGridViewForm dataGridViewForm = new DataGridViewForm(this, ClientDataAccess.LoadClient());
            dataGridViewForm.ShowDialog();
        }

        /// <summary>
        /// SetClientEventClientId - use to passing client id and name from datagridviewform to clienteventform
        /// </summary>
        /// <param name="clientId">client id</param>
        /// <param name="clientName">client name</param>
        public void SetClientEventClientId(int clientId, string clientName)
        {
            _clientEvent.ClientID = clientId;
            txtClientId.Text = clientName;
        }

        /// <summary>
        /// btnClientAdd_Click - for adding track for client event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTrackAdd_Click(object sender, EventArgs e)
        {
            DataGridViewForm dataGridViewForm = new DataGridViewForm(this, TrackDataAccess.LoadTrack());
            dataGridViewForm.ShowDialog();
        }

        /// <summary>
        /// SetClientEventTrackId - use to passing track id and name from datagridviewform to clienteventform
        /// </summary>
        /// <param name="clientId">client id</param>
        /// <param name="clientName">client name</param>
        public void SetClientEventTrackId(int trackId, string trackName)
        {
            _clientEvent.TrackID = trackId;
            txtTrackID.Text = trackName;
        }

        /// <summary>
        /// btnManageTrackWorker_Click - for adding track worker for client event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnManageTrackWorker_Click(object sender, EventArgs e)
        {
            DataGridViewForm dataGridViewForm = new DataGridViewForm(this, TrackWorkerDataAccess.LoadTrackWorker(), _clientsEvents_TrackWorkers);
            dataGridViewForm.ShowDialog();
        }

        /// <summary>
        /// SetClientEventTrackWorkerId - use to passing track worker id from datagridviewform to clienteventform
        /// </summary>
        /// <param name="trackWorkerIdList">track worker id list</param>
        public void SetClientEventTrackWorkerId(List<int> trackWorkerIdList)
        {
            _clientEvent.TrackWorkersId = trackWorkerIdList;
        }

        /// <summary>
        /// txtClientEventDate_Validating - validating event for client event date textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtClientEventDate_Validating(object sender, CancelEventArgs e)
        {
            if (!txtClientEventDate.MaskFull)
            {
                e.Cancel = true;
                txtClientEventDate.Focus();
                errorProviderApp.SetError(txtClientEventDate, "Client Event Dare should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtClientEventDate, "");
            }
        }

        /// <summary>
        /// txtWorkerRequested_Validating - validating event for client event worker request textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtWorkerRequested_Validating(object sender, CancelEventArgs e)
        {
            int test;
            if (string.IsNullOrWhiteSpace(txtWorkerRequested.Text))
            {
                e.Cancel = true;
                txtWorkerRequested.Focus();
                errorProviderApp.SetError(txtWorkerRequested, "Worker Requested should not be left blank!");
            }
            else if (!int.TryParse(txtWorkerRequested.Text, out test))
            {
                e.Cancel = true;
                txtWorkerRequested.Focus();
                errorProviderApp.SetError(txtWorkerRequested, "Worker Requested should be numeric!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtWorkerRequested, "");
            }
        }

        /// <summary>
        /// btnClientEventAdd_Click - click event to insert new client event record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClientEventAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                bool isValid = true;
                _clientEvent.WorkersRequested = int.Parse(txtWorkerRequested.Text.Trim());
                _clientEvent.Date = txtClientEventDate.Text.Trim();
                _clientEvent.IsLunchProvided = rdoClientEventIsLunchProvided_True.Checked ? true : false;
                _clientEvent.WorkerCalloutSent = rdoClientEventWorkerCalloutSent_True.Checked ? true : false;
                _clientEvent.RequireSafetyDemo = rdoClientEventRequireSafetyDemo_True.Checked ? true : false;

                if (cbClientEventIsUsingUpperPaddock.Checked != true && cbClientEventIsUsingMiddlePaddock.Checked != true && cbClientEventIsUsingLowerPaddock.Checked != true)
                {
                    isValid = false;
                    gbClientEventIsUsingPaddock.Focus();
                    errorProviderApp.SetError(gbClientEventIsUsingPaddock, "At least one paddock should be selected!");
                }
                else
                {
                    if (cbClientEventIsUsingUpperPaddock.Checked)
                        _clientEvent.IsUsingUpperPaddock = true;
                    else
                        _clientEvent.IsUsingUpperPaddock = false;

                    if (cbClientEventIsUsingMiddlePaddock.Checked)
                        _clientEvent.IsUsingMiddlePaddock = true;
                    else
                        _clientEvent.IsUsingMiddlePaddock = false;

                    if (cbClientEventIsUsingLowerPaddock.Checked)
                        _clientEvent.IsUsingLowerPaddock = true;
                    else
                        _clientEvent.IsUsingLowerPaddock = false;
                }

                if (_clientEvent.ClientID == 0)
                {
                    isValid = false;
                    btnClientAdd.Focus();
                    errorProviderApp.SetError(btnClientAdd, "You havent select a client");
                }

                if (_clientEvent.TrackID == 0)
                {
                    isValid = false;
                    btnTrackAdd.Focus();
                    errorProviderApp.SetError(btnTrackAdd, "You havent select a track");
                }

                if (_clientsEvents_TrackWorkers.Count == 0)
                {
                    isValid = false;
                    btnManageTrackWorker.Focus();
                    errorProviderApp.SetError(btnManageTrackWorker, "You havent select any Track Worker");
                }


                if (isValid)
                {
                    try
                    {
                        ClientEventDataAccess.SaveClientEvent(_clientEvent, _clientsEvents_TrackWorkers);
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

        }

        /// <summary>
        /// btnClientEventUpdate_Click - click event for update client event record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClientEventUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                bool isValid = true;
                _clientEvent.ClientEventID = int.Parse(txtClientEventId.Text.Trim());
                _clientEvent.WorkersRequested = int.Parse(txtWorkerRequested.Text.Trim());
                _clientEvent.Date = txtClientEventDate.Text.Trim();
                _clientEvent.IsLunchProvided = rdoClientEventIsLunchProvided_True.Checked ? true : false;
                _clientEvent.WorkerCalloutSent = rdoClientEventWorkerCalloutSent_True.Checked ? true : false;
                _clientEvent.RequireSafetyDemo = rdoClientEventRequireSafetyDemo_True.Checked ? true : false;

                if (cbClientEventIsUsingUpperPaddock.Checked != true && cbClientEventIsUsingMiddlePaddock.Checked != true && cbClientEventIsUsingLowerPaddock.Checked != true)
                {
                    isValid = false;
                    gbClientEventIsUsingPaddock.Focus();
                    errorProviderApp.SetError(gbClientEventIsUsingPaddock, "At least one paddock should be selected!");
                }
                else
                {
                    if (cbClientEventIsUsingUpperPaddock.Checked)
                        _clientEvent.IsUsingUpperPaddock = true;
                    else
                        _clientEvent.IsUsingUpperPaddock = false;

                    if (cbClientEventIsUsingMiddlePaddock.Checked)
                        _clientEvent.IsUsingMiddlePaddock = true;
                    else
                        _clientEvent.IsUsingMiddlePaddock = false;

                    if (cbClientEventIsUsingLowerPaddock.Checked)
                        _clientEvent.IsUsingLowerPaddock = true;
                    else
                        _clientEvent.IsUsingLowerPaddock = false;
                }

                if (_clientEvent.ClientID == 0)
                {
                    isValid = false;
                    btnClientAdd.Focus();
                    errorProviderApp.SetError(btnClientAdd, "You havent select a client");
                }

                if (_clientEvent.TrackID == 0)
                {
                    isValid = false;
                    btnTrackAdd.Focus();
                    errorProviderApp.SetError(btnTrackAdd, "You havent select a track");
                }

                if (_clientsEvents_TrackWorkers.Count == 0)
                {
                    isValid = false;
                    btnManageTrackWorker.Focus();
                    errorProviderApp.SetError(btnManageTrackWorker, "You havent select any Track Worker");
                }


                if (isValid)
                {
                    try
                    {
                        // database insert statement
                        ClientEventDataAccess.UpdateClientEvent(_clientEvent, _clientEvent.ClientEventID);
                        ClientEvents_TrackWorkersDataAccess.RemoveAllClientEventTrackWorker(_clientEvent.ClientEventID);
                        ClientEvents_TrackWorkersDataAccess.SaveClientEventTrackWorker(_clientsEvents_TrackWorkers, _clientEvent.ClientEventID);

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
        }

        /// <summary>
        /// ClientEventForm_FormClosing - closing event to update mainform datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientEventForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            _mainForm.RefreshDataGridViewClientEvent();
        }

        /// <summary>
        /// btnEscape_Click - to close form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEscape_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// btnManageAttendance_Click - manage track worker status(isApplied, isSelected, isPresent)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnManageAttendance_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(string.Join("\n", _clientEvent.TrackWorkersId));
            DataGridViewForm dataGridViewForm = new DataGridViewForm(this, _clientsEvents_TrackWorkers);
            dataGridViewForm.ShowDialog();
        }

        /// <summary>
        /// SetClientsEvents_TrackWorkers - pass track worker model for client event from datagridviewform to clienteventform
        /// </summary>
        /// <param name="clientsEvents_TrackWorkers"></param>
        public void SetClientsEvents_TrackWorkers(List<ClientEvents_TrackWorkersModel> clientsEvents_TrackWorkers)
        {
            //_clientsEvents_TrackWorkers = clientsEvents_TrackWorkers;
            // TODO ONLY ADD IF NEW TRACK WORKER ID
            // FIND A BETTER WAY TO DO THIS
            // MAY CAUSE FUTURE PROBLEM
            List<ClientEvents_TrackWorkersModel> listDifference = _clientsEvents_TrackWorkers.Where(x => !clientsEvents_TrackWorkers.Any(z => z.TrackWorkerID == x.TrackWorkerID)).ToList();

            foreach (ClientEvents_TrackWorkersModel model in listDifference)
            {
                _clientsEvents_TrackWorkers.Remove(_clientsEvents_TrackWorkers.Single(s => s.TrackWorkerID == model.TrackWorkerID));
            }

            foreach (ClientEvents_TrackWorkersModel model in clientsEvents_TrackWorkers)
            {
                if (!_clientsEvents_TrackWorkers.Any(item => item.TrackWorkerID == model.TrackWorkerID))
                {
                    _clientsEvents_TrackWorkers.Add(model);
                }
                // if the data is already changed
                else if (model.IsApplied == true && model.IsSelected == true)
                {
                    _clientsEvents_TrackWorkers.Where(w => w.TrackWorkerID == model.TrackWorkerID).ToList().ForEach(s => s.IsApplied = model.IsApplied);
                    _clientsEvents_TrackWorkers.Where(w => w.TrackWorkerID == model.TrackWorkerID).ToList().ForEach(s => s.IsSelected = model.IsSelected);
                    _clientsEvents_TrackWorkers.Where(w => w.TrackWorkerID == model.TrackWorkerID).ToList().ForEach(s => s.IsPresent = model.IsPresent);
                }
            }
        }

        private void gbClientEventIsDeleted_Enter(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
