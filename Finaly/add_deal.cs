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
    public partial class add_deal : Form
    {
        Deal_worker deal_worker = new Deal_worker();

        public add_deal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            

            int cardid = Convert.ToInt32(tb_cardid.Text);
            int productid = Convert.ToInt32(tb_productid.Text);
            int stationid = Convert.ToInt32(tb_stationid.Text);
            int quantity = Convert.ToInt32(tb_quantity.Text);

            deal_worker.add_new_deal(cardid, productid, stationid, quantity);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
