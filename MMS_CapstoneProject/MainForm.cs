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
        List<ClientModel> clients1 = new List<ClientModel>();
        public MainForm()
        {
            clients = SqliteDataAccess.LoadAllClient();
            clients1 = SqliteDataAccess.LoadClient(1);

            Console.WriteLine("ASD");

            InitializeComponent();

        }
    }
}
