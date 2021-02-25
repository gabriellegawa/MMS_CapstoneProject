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
    public partial class ClientEventForm : Form
    {
        private readonly MainForm _mainForm;
        private static ClientEventModel _clientEvent = new ClientEventModel();
        public ClientEventForm(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();

            btnEnter.Click += btnClientEventAdd_Click;
        }

        private void btnClientAdd_Click(object sender, EventArgs e)
        {
            DataGridViewForm dataGridViewForm = new DataGridViewForm(this, ClientDataAccess.LoadClient());
            dataGridViewForm.ShowDialog();
        }

        public void SetClientEventClientId(int clientId)
        {
            _clientEvent.ClientId = clientId;
            txtClientEventClientId.Text = clientId.ToString();
        }

        private void btnTrackAdd_Click(object sender, EventArgs e)
        {
            DataGridViewForm dataGridViewForm = new DataGridViewForm(this, TrackDataAccess.LoadTrack());
            dataGridViewForm.ShowDialog();
        }
        public void SetClientEventTrackId(int trackId)
        {
            _clientEvent.ClientEventTrack = trackId;
            txtTrackID.Text = trackId.ToString();
        }

        private void btnManageTrackWorker_Click(object sender, EventArgs e)
        {
            DataGridViewForm dataGridViewForm = new DataGridViewForm(this, TrackWorkerDataAccess.LoadTrackWorker(), _clientEvent.TrackWorkersId);
            dataGridViewForm.ShowDialog();
        }
        public void SetClientEventTrackWorkerId(List<int> trackWorkerIdList)
        {
            _clientEvent.TrackWorkersId = trackWorkerIdList;
        }

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

        private void btnClientEventAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                bool isValid = true;
                _clientEvent.ClientEventWorkerRequested = int.Parse(txtWorkerRequested.Text.Trim());
                _clientEvent.IsLunchProvided = rdoClientEventIsLunchProvided_True.Checked ? true : false;
                _clientEvent.WorkerCalloutSent = rdoClientEventWorkerCalloutSent_True.Checked ? true : false;
                _clientEvent.RequiresSafetyDemo = rdoClientEventRequireSafetyDemo_True.Checked ? true : false;

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

                if(_clientEvent.ClientId == 0)
                {
                    isValid = false;
                    btnClientAdd.Focus();
                    errorProviderApp.SetError(btnClientAdd, "You havent select a client");
                }

                if (_clientEvent.ClientEventTrack == 0)
                {
                    isValid = false;
                    btnTrackAdd.Focus();
                    errorProviderApp.SetError(btnTrackAdd, "You havent select a track");
                }

                if (_clientEvent.TrackWorkersId == null)
                {
                    isValid = false;
                    btnManageTrackWorker.Focus();
                    errorProviderApp.SetError(btnManageTrackWorker, "You havent select any Track Worker");
                }


                if (isValid)
                {
                    try
                    {
                        Console.WriteLine(_clientEvent);
                        ClientEventDataAccess.SaveClientEvent(_clientEvent);
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
    }
}
