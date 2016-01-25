using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finaly
{
    public partial class edit_station : Form
    {
        Station_worker station_worker = new Station_worker();
        int sid;
        public edit_station(int id)
        {
            InitializeComponent();
            sid = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text;
            string location = tb_location.Text;

            station_worker.edit_station(name, location, sid);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
