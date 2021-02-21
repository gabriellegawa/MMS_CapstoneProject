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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClientAddNew_Click(object sender, EventArgs e)
        {

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
            dataGridView.DataSource = list;
            dataGridView.AutoResizeColumns();

            int dgv_width = dataGridView.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            this.Width = 365 + dgv_width;

            dataGridView.ClearSelection();
        }

        private void dgvTrackWorker_CellClick(object sender, DataGridViewCellEventArgs e)
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
            Console.WriteLine();
            TrackWorkerForm trackWorkerForm = new TrackWorkerForm(this, trackWorker);
            trackWorkerForm.ShowDialog();
        }
    }
}
