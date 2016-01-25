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
    public partial class add_card : Form
    {
        Card_worker cardworker = new Card_worker();
        public add_card()
        {
            
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cardworker.add_new_card(tb_name.Text, tb_status.Text);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
