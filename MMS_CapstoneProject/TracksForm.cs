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
    public partial class TracksForm : Form
    {
        public TracksForm()
        {
            InitializeComponent();
        }

        private void TracksForm_Load(object sender, EventArgs e)
        {
            RefreshDataGridViewData(dataGridViewTrack);
        }

        /// <summary>
        /// RefreshDataGridViewData -  refresh data grid data
        /// </summary>
        public void RefreshDataGridViewData(DataGridView dataGridView)
        {
            var source = new BindingSource();

            if (dataGridView == dataGridViewTrack)
            {
                source = new BindingSource(SqliteDataAccess.LoadTrack(), null);
            }

            dataGridView.DataSource = source;
            dataGridView.AutoResizeColumns();

            int dgv_width = dataGridView.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            this.Width = 500 + dgv_width;

            dataGridViewTrack.ClearSelection();
        }
    }
}
