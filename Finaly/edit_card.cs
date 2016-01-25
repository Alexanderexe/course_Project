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
    public partial class edit_card : Form
    {
        int cid;
        Card_worker card_worker = new Card_worker();

        public edit_card(int id)
        {

            cid = id;
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int id = cid;
            int bonus = Convert.ToInt32(tb_bonus.Text);
            string name = tb_name.Text;
            string status = tb_status.Text;

            card_worker.edit_card(name, status, bonus, id);
        }
    }
}
