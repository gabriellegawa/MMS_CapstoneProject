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
    }
}
