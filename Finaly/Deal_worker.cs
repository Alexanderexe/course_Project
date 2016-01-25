using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finaly
{
    class Deal_worker
    {
        GAS_context context = new GAS_context();

        public void add_new_deal(int cardid,int productid,int stationid,int dealquantity)
        {

            Deals deal = new Deals();
            Cards card = context.Cards.SingleOrDefault(c => c.CardID == cardid);
            Products product = context.Products.SingleOrDefault(p => p.productID == productid);
            deal_to_card dealcard = new deal_to_card();
            deal.idofproduct = productid;
            deal.idofstation = stationid;
            deal.quantity = dealquantity;
            deal.totalprice = product.price * dealquantity;
            deal.bonus = Convert.ToInt32(deal.totalprice) / 10;
            deal.data = System.DateTime.Now;
            deal.time = DateTime.Now.TimeOfDay;
            context.Deals.Add(deal);
            context.SaveChanges();
            dealcard.idofcard = cardid;
            dealcard.idofdeal = deal.dealID;
            context.deal_to_card.Add(dealcard);
            card.bonus += Convert.ToInt32(deal.bonus);
            context.SaveChanges();



        }


        public void delete_deal(int id)
        {
            try
            {
                Deals deal = context.Deals.SingleOrDefault(d => d.dealID == id);
                deal_to_card dtc = context.deal_to_card.SingleOrDefault(d => d.idofdeal == deal.dealID);
                context.Deals.Remove(deal);
                context.deal_to_card.Remove(dtc);
                context.SaveChanges();
            }
            catch
            {
                MessageBox.Show("error");
            };
        }

        public List<best_prod> show_prod()
        {
            string query = "select name,sum(quantity) as quantity from products inner join Deals on productID = idofproduct group by  name order by quantity desc;";
            var card_deals = context.Database.SqlQuery<best_prod>(query);
            return card_deals.ToList();
        }

        public void random_deal()
        {
            List<int> cardid_list = new List<int>();
            List<int> products_list = new List<int>();
            List<int> dea_list = new List<int>();
            Random rand = new Random();
            var querycards = context.Cards;
            var querystations = context.Stations;
            var queryproducts = context.Products;
            foreach (Cards q in querycards)
            {
                cardid_list.Add(q.CardID);
            }
            foreach (Products q in queryproducts)
            {
                products_list.Add(q.productID);
            }
            foreach (Stations q in querystations)
            {
                dea_list.Add(q.StationID);
            }

            int c = cardid_list[rand.Next(0, cardid_list.Count)];
            int p = products_list[rand.Next(0, products_list.Count)];
            int s = dea_list[rand.Next(0, dea_list.Count)];
            int qu = rand.Next(1, 101);
            this.add_new_deal(c, p, s, qu);

        }
    }

    }

