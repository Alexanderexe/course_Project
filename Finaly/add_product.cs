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
    public partial class add_product : Form
    {
        Product_worker product_worker = new Product_worker();


        public add_product()
        {
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text;
            int price = Convert.ToInt32(tb_price.Text);
            
            product_worker.add_new_product(name, price);

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
