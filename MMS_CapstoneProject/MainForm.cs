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
    }
}
