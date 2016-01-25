using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;

namespace Finaly
{
    class Card_worker
    {
        

        GAS_context context = new GAS_context();

        public List<Deals_of_card> show_deals_of_card(int id)
        {
            string query = "select(select name from products where productID = Deals.idofproduct)'product',(select name from Stations where StationID = Deals.idofstation)'station',quantity,totalprice,data,time,bonus from Deals where dealID IN (select idofdeal from deal_to_card where idofcard =" + id + ")";
            var card_deals = context.Database.SqlQuery<Deals_of_card>(query);
            return card_deals.ToList();
        }


        public List<Cards> filter_cards_status(string filter)
        {
            IQueryable<Cards> query = context.Cards.Where(c => c.status == filter);

            return query.ToList();
        }



        public List<Cards> filter_cards_bonus(int min,int max)
        {
            IQueryable<Cards> query = context.Cards.Where(c => c.bonus >= min && c.bonus <= max);

            return query.ToList();
        }

        public void add_new_card(string name, string status)
        {
            
                Cards card = new Cards();
                Clients client = new Clients();
                card.status = status;
                card.bonus = 0;
                context.Cards.Add(card);
                context.SaveChanges();
                client.idofcard = card.CardID;
                client.name = name;
                context.Clients.Add(client);
                context.SaveChanges();
        }


        public void edit_card(string name, string status,int bonus, int id)
        {

            Cards card = context.Cards.SingleOrDefault(c => c.CardID == id);
            Clients client = context.Clients.SingleOrDefault(c => c.idofcard == id);
            card.bonus = bonus;
            card.status = status;
            client.name = name;
            context.Cards.Add(card);
            context.Clients.Add(client);
            context.SaveChanges();

        }

        public void delete_card(int id)
        {

            Cards card = context.Cards.SingleOrDefault(c => c.CardID == id);
            Clients client = context.Clients.SingleOrDefault(c => c.idofcard == id);
            IQueryable<deal_to_card> deals = context.deal_to_card.Where(c => c.idofcard == id);
            foreach (deal_to_card c in deals)
            {
                context.deal_to_card.Remove(c);
            }
            context.Cards.Remove(card);
            context.Clients.Remove(client);
            context.SaveChanges();

        }
        public void random_create_card()

        {
            Random rand = new Random();
            var query = context.Clients;
            List<string> name_list = new List<string>(); 
            foreach (Clients q in query)
            {
                name_list.Add(q.name);
            }
            List<string> status_list = new List<string>();
            status_list.Add("gold");
            status_list.Add("silver");
            status_list.Add("start");
            string n = name_list[rand.Next(0, name_list.Count)];
            string s = status_list[rand.Next(0, status_list.Count)];
            this.add_new_card(n, s);
        }

    }
}
