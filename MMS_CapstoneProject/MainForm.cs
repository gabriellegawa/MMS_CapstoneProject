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
    public partial class MainForm : Form
    {
        List<ClientModel> clients = new List<ClientModel>();
        public MainForm()
        {
            clients = SqliteDataAccess.LoadClient();
            clients = SqliteDataAccess.LoadClient();

            InitializeComponent();

        }
    }
}
