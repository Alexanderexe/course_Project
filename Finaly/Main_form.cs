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
    public partial class Main_form : Form
    {

        //блок классов
        GAS_context context = new GAS_context();
        Card_worker cardworker = new Card_worker();
        Station_worker stationworker = new Station_worker();
        Deal_worker dealworker = new Deal_worker();
        Product_worker product_worker = new Product_worker();
        COM_out com_out = new COM_out();

        int choose = 1;
        bool admin = false;


        public Main_form()
        {
            InitializeComponent();
            dgv_cardinfo.DataSource = context.Cards.ToList();
            dgv_stationinfo.DataSource = context.Stations.ToList();

            //параметры dgv
            dgv_cardinfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_deals_of_card.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_stationinfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_deals_of_station.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_cardinfo.Columns[3].Visible = false;
            dgv_cardinfo.Columns[4].Visible = false;


            btn_add.Enabled = false;
            btn_edit.Enabled = false;
            button3.Enabled = false;
            cb_admin.Enabled = false;



        }

        private void dgv_cardinfo_SelectionChanged(object sender, EventArgs e)
        {
            int row_number = dgv_cardinfo.CurrentRow.Index;
            int id = Convert.ToInt32(dgv_cardinfo.Rows[row_number].Cells[0].Value);

            dgv_deals_of_card.DataSource = cardworker.show_deals_of_card(id);
        }

        private void dgv_stationinfo_SelectionChanged(object sender, EventArgs e)
        {

            int row_number = dgv_stationinfo.CurrentRow.Index;
            int id = Convert.ToInt32(dgv_stationinfo.Rows[row_number].Cells[0].Value);

            dgv_deals_of_station.DataSource = stationworker.get_deals_of_station(id);

            dgv_deals_of_station.Columns[8].Visible = false;
            dgv_deals_of_station.Columns[9].Visible = false;
            dgv_deals_of_station.Columns[10].Visible = false;
            dgv_deals_of_station.Columns[1].Visible = false;

        }

        private void btn_sort_status_Click(object sender, EventArgs e)
        {

            string filter = cb_filter.Text;
            if (filter == "ALL")
                dgv_cardinfo.DataSource = context.Cards.ToList();
            else
                dgv_cardinfo.DataSource = cardworker.filter_cards_status(filter);

        }

        private void btn_sort_bonus_Click(object sender, EventArgs e)
        {

            int max, min;
            max = Convert.ToInt32(tb_Fhighvalue.Text);
            min = Convert.ToInt32(tb_Flowvalue.Text);

            dgv_cardinfo.DataSource = cardworker.filter_cards_bonus(min, max);

        }

        private void btn_filter_station_Click(object sender, EventArgs e)
        {
            string filter = tb_filter_location.Text;

            dgv_stationinfo.DataSource = stationworker.filter_station_location(filter);
        }

        private void cb_admin_TextChanged(object sender, EventArgs e)
        {

            if (cb_admin.Text == "cards")
            {
                btn_edit.Enabled = true;
                dgv_admin.DataSource = context.Cards.ToList();
                dgv_admin.Columns[3].Visible = false;
                dgv_admin.Columns[4].Visible = false;
                choose = 1;
            }
            if (cb_admin.Text == "stations")
            {
                btn_edit.Enabled = true;
                dgv_admin.DataSource = context.Stations.ToList();
                dgv_admin.Columns[3].Visible = false;
                choose = 2;
            }
            if (cb_admin.Text == "deals")
            {
                btn_edit.Enabled = false;
                dgv_admin.DataSource = context.Deals.ToList();
                dgv_admin.Columns[8].Visible = false;
                dgv_admin.Columns[9].Visible = false;
                dgv_admin.Columns[10].Visible = false;
                choose = 3;
            }

            if (cb_admin.Text == "product")
            {
                btn_edit.Enabled = true;
                dgv_admin.DataSource = context.Products.ToList();
                dgv_admin.Columns[3].Visible = false;
                choose = 4;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (choose == 1)
            {
                add_card form = new add_card();
                form.Show();
                dgv_admin.DataSource = context.Cards.ToList();
            }
            if (choose == 2)
            {
                add_station form = new add_station();
                form.Show();
                dgv_admin.DataSource = context.Stations.ToList();
            }
            if (choose == 3)
            {
                add_deal form = new add_deal();
                form.Show();
                dgv_admin.DataSource = context.Deals.ToList();
            }
            if (choose == 4)
            {
                add_product form = new add_product();
                form.Show();
                dgv_admin.DataSource = context.Products.ToList();
            }

        }

        private void dgv_cardinfo_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dgv_cardinfo.CurrentRow.Cells[0].Value);
            Clients client = context.Clients.SingleOrDefault(c => c.idofcard == id);
            try
            {
                MessageBox.Show("имя клиента " + client.name);
            }
            catch
            {
                MessageBox.Show("свободная карта");
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

            if (choose == 1)
            {

                edit_card form = new edit_card(Convert.ToInt32(dgv_admin.CurrentRow.Cells[0].Value));
                form.Show();
                dgv_admin.DataSource = context.Cards.ToList();
            }
            if (choose == 2)
            {

                edit_station form = new edit_station(Convert.ToInt32(dgv_admin.CurrentRow.Cells[0].Value));
                form.Show();
                dgv_admin.DataSource = context.Stations.ToList();
            }

            if (choose == 4)
            {

                edit_product form = new edit_product(Convert.ToInt32(dgv_admin.CurrentRow.Cells[0].Value));
                form.Show();
                dgv_admin.DataSource = context.Products.ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (choose == 1)
            {

                cardworker.delete_card(Convert.ToInt32(dgv_admin.CurrentRow.Cells[0].Value));
                dgv_admin.DataSource = context.Cards.ToList();
            }
            if (choose == 2)
            {
                stationworker.delete_station(Convert.ToInt32(dgv_admin.CurrentRow.Cells[0].Value));
                dgv_admin.DataSource = context.Stations.ToList();
            }
            if (choose == 3)
            {
                dealworker.delete_deal(Convert.ToInt32(dgv_admin.CurrentRow.Cells[0].Value));
                dgv_admin.DataSource = context.Deals.ToList();
            }
            if (choose == 4)
            {

                product_worker.delete_product(Convert.ToInt32(dgv_admin.CurrentRow.Cells[0].Value));
                dgv_admin.DataSource = context.Products.ToList();
            }
        }

        private void btn_stat_turnover_Click(object sender, EventArgs e)
        {
            var query = from Deals in context.Deals
                        group Deals by new
                        {
                            Deals.idofstation
                        } into g
                        select new
                        {
                            g.Key.idofstation,
                            turnover = (int?)g.Sum(p => p.totalprice),
                            Station_name =
                            ((from Stations in context.Stations
                              where
        g.Key.idofstation == Stations.StationID
                              select new
                              {
                                  Stations.name
                              }).FirstOrDefault().name)
                        };
            dgv_statistic.DataSource = query.ToList();


           diagram.Series.Clear();

            IEnumerable<Stations> a = context.Stations;
            List<string> namelist = new List<string>();
            List<int> tradelist = new List<int>();

            foreach (Stations i in a)
            {
                diagram.Series.Add(i.name);
            }
            for (int i = 0; i < dgv_statistic.Rows.Count; i++)
            {
                tradelist.Add((int)dgv_statistic.Rows[i].Cells[1].Value);
                diagram.Series[i].Points.AddY(tradelist[i]);

            }
        }

        private void bt_avg_check_Click(object sender, EventArgs e)
        {
            var query = from Deals in context.Deals
                        group Deals by new
                        {
                            Deals.idofstation
                        } into g
                        select new
                        {
                            g.Key.idofstation,
                            avg_check = (double?)g.Average(p => p.totalprice),
                            Station_name =
                            ((from Stations in context.Stations
                              where
        g.Key.idofstation == Stations.StationID
                              select new
                              {
                                  Stations.name
                              }).FirstOrDefault().name)
                        };
            dgv_statistic.DataSource = query.ToList();

            diagram.Series.Clear();
            IEnumerable<Stations> station_list = context.Stations;
            List<int> turnover_list = new List<int>();
            foreach (Stations i in station_list)
            {
                diagram.Series.Add(i.name);
            }
            for (int i = 0; i < dgv_statistic.Rows.Count; i++)
            {
                turnover_list.Add(Convert.ToInt32(dgv_statistic.Rows[i].Cells[1].Value));
                diagram.Series[i].Points.AddY(turnover_list[i]);

            }
        }

        private void btn_best_client_Click(object sender, EventArgs e)
        {
            var query = from Deals in context.Deals
                        join Deal_to_card in context.deal_to_card on new { DealID = Deals.dealID } equals new { DealID = Deal_to_card.idofdeal } into Deal_to_card_join
                        from Deal_to_card in Deal_to_card_join
                        group new { Deal_to_card, Deals } by new
                        {
                            Deal_to_card.idofcard
                        } into g
                        orderby
                          g.Sum(p => p.Deals.totalprice) descending
                        select new
                        {
                            g.Key.idofcard,
                            totaldealcost = (int?)g.Sum(p => p.Deals.totalprice)
                        };
            dgv_statistic.DataSource = query.ToList();

            diagram.Series.Clear();
            List<string> list_name = new List<string>();
            List<int> list_turnover = new List<int>();
            for (int i = 0; i < dgv_statistic.Rows.Count; i++)
            {

                list_name.Add(dgv_statistic.Rows[i].Cells[0].Value.ToString());
                list_turnover.Add(Convert.ToInt32( dgv_statistic.Rows[i].Cells[1].Value));
                diagram.Series.Add(dgv_statistic.Rows[i].Cells[0].Value.ToString());
                diagram.Series[i].Points.AddXY(list_name[i], list_turnover[i]);
                
            }
            

        }

        private void btn_best_product_Click(object sender, EventArgs e)
        {


            dgv_statistic.DataSource = dealworker.show_prod();

            diagram.Series.Clear();
            List<string> list_name = new List<string>();
            List<int> list_turnover = new List<int>();
            for (int i = 0; i < dgv_statistic.Rows.Count; i++)
            {

                list_name.Add(dgv_statistic.Rows[i].Cells[0].Value.ToString());
                list_turnover.Add(Convert.ToInt32(dgv_statistic.Rows[i].Cells[1].Value));
                diagram.Series.Add(dgv_statistic.Rows[i].Cells[0].Value.ToString());
                diagram.Series[i].Points.AddXY(list_name[i], list_turnover[i]);

            }
        }

        private void report_stations_Click(object sender, EventArgs e)
        {
            List<string> station_name_list = new List<string>();
            List<int> station_turnover_list = new List<int>();
            List<int> station_avg_list = new List<int>();

            var query = from Deals in context.Deals
                        group Deals by new
                        {
                            Deals.idofstation
                        } into g
                        select new
                        {
                            g.Key.idofstation,
                            turnover = (int?)g.Sum(p => p.totalprice),
                            Station_name =
                            ((from Stations in context.Stations
                              where
        g.Key.idofstation == Stations.StationID
                              select new
                              {
                                  Stations.name
                              }).FirstOrDefault().name)
                        };
            dgv_statistic.DataSource = query.ToList();

            int index;
            index = dgv_statistic.RowCount;
            for (int i = 0; i < index; i++)
            {
                station_name_list.Add(dgv_statistic.Rows[i].Cells[2].Value.ToString());
                station_turnover_list.Add(Convert.ToInt32(dgv_statistic.Rows[i].Cells[1].Value.ToString()));
            }
            var tquery = from Deals in context.Deals
                         group Deals by new
                         {
                             Deals.idofstation
                         } into g
                         select new
                         {
                             g.Key.idofstation,
                             avg_check = (double?)g.Average(p => p.totalprice),
                             Station_name =
                             ((from Stations in context.Stations
                               where
         g.Key.idofstation == Stations.StationID
                               select new
                               {
                                   Stations.name
                               }).FirstOrDefault().name)
                         };
            dgv_statistic.DataSource = tquery.ToList();
            for (int i = 0; i < index; i++)
            {

                station_avg_list.Add(Convert.ToInt32(dgv_statistic.Rows[i].Cells[1].Value));

            }
            com_out.reporttoexcel_turnover(station_name_list, station_turnover_list, station_avg_list);
        }

        private void report_clients_Click(object sender, EventArgs e)
        {
            List<string> client_name_list = new List<string>();
            List<int> card_id_list = new List<int>();
            List<int> summ_list = new List<int>();


            var query =  from Deals in context.Deals
                                    join Deal_to_card in context.deal_to_card on new { DealID = Deals.dealID } equals new { DealID = Deal_to_card.idofdeal } into Deal_to_card_join
                                    from Deal_to_card in Deal_to_card_join
                                    group new { Deal_to_card, Deals } by new
                                    {
                                        Deal_to_card.idofcard
                                    } into g
                                    orderby
                                      g.Sum(p => p.Deals.totalprice) descending
                                    select new
                                    {
                                        g.Key.idofcard,
                                        totaldealcost = (int?)g.Sum(p => p.Deals.totalprice)
                                    };
            dgv_statistic.DataSource = query.ToList();
            

            int index;
            index = dgv_statistic.RowCount;
            for (int i = 0; i < index; i++)
            {

                card_id_list.Add(Convert.ToInt32(dgv_statistic.Rows[i].Cells[0].Value.ToString()));
                summ_list.Add(Convert.ToInt32(dgv_statistic.Rows[i].Cells[1].Value.ToString()));
            }
            var query1 = from Clients in context.Clients
                         join Cards in context.Cards on new { Idofcard = Clients.idofcard } equals new { Idofcard = Cards.CardID }
                         select new
                         {
                             Clients.name,
                             Cards.CardID
                         };
            dgv_statistic.DataSource = query1.ToList();
            for (int i = 0; i < index; i++)
            {

                client_name_list.Add(dgv_statistic.Rows[i].Cells[0].Value.ToString());

            }
            com_out.reporttoexcel_clients(client_name_list, card_id_list, summ_list);



        }

        private void btn_status_ratio_Click(object sender, EventArgs e)
        {
            diagram.Series.Clear();

            int gold = 0, silver = 0, start = 0;
            IEnumerable<Cards> card_list = context.Cards;
            
            foreach (Cards card in card_list)
            {
                if (card.status == "gold")
                    gold++;
                if (card.status == "silver")
                    silver++;
                if (card.status == "start")
                    start++;
            }
            
            diagram.Series.Add("status");
            
            diagram.Series[0].Points.AddXY("gold", gold);
            diagram.Series[0].Points.AddXY("silver", silver);
            diagram.Series[0].Points.AddXY("start", start);



        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            if (admin == false)
            {
                admin_activate form = new admin_activate();
                DialogResult result = form.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                if (form.tb_password.Text == "123")
                {
                    MessageBox.Show("Done");
                    btn_add.Enabled = true;
                    btn_edit.Enabled = true;
                    button3.Enabled = true;
                    cb_admin.Enabled = true;
                    btn_admin.Text = "complete administration";
                    admin = true;
                }
                else
                {
                    
                    MessageBox.Show("wrong password");
                    return;
                }
            }
            else
            {
                btn_admin.Text = "start administration";
                btn_add.Enabled = false;
                btn_edit.Enabled = false;
                button3.Enabled = false;
                cb_admin.Enabled = false;
                MessageBox.Show("complete administration");
                admin = false;
            }

        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                dealworker.random_deal();
            }
        }
    }

}
