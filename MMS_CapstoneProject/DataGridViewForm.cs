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
    public partial class DataGridViewForm : Form
    {
        private readonly ClientEventForm _clientEventForm;
        public DataGridViewForm(ClientEventForm clientEventForm, List<ClientModel> list)
        {
            InitializeComponent();
            dataGridView1.DataSource = list;
            dataGridView1.MultiSelect = false;
            btnSelect.Click += btnAddClient_Click;
            _clientEventForm = clientEventForm;
        }
        public DataGridViewForm(ClientEventForm clientEventForm, List<TrackModel> list)
        {
            InitializeComponent();
            dataGridView1.DataSource = list;
            dataGridView1.MultiSelect = false;
            btnSelect.Click += btnAddTrack_Click;
            _clientEventForm = clientEventForm;
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                _clientEventForm.SetClientEventClientId(Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value));
                this.Close();
            }
        }
        private void btnAddTrack_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                _clientEventForm.SetClientEventTrackId(Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value));
                this.Close();
            }
        }
    }
}
