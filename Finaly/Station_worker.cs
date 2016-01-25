using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finaly
{
    class Station_worker
    {
        GAS_context context = new GAS_context();

        public List<Deals> get_deals_of_station(int id)
        {

            var query = context.Deals.Where(c => c.idofstation == id);

            return query.ToList();
            
        }

        public List<Stations> filter_station_location(string filter)
        {
            IQueryable<Stations> query = context.Stations.Where(c => c.location == filter);

            return query.ToList();
        }

        public void add_new_station(string name, string location)
        {

            Stations station = new Stations();

            station.name = name;
            station.location = location;
            context.Stations.Add(station);
            context.SaveChanges();
            
        }

        public void edit_station(string name, string locate, int id)
        {

            Stations station = context.Stations.SingleOrDefault(c => c.StationID == id);

            station.name = name;
            station.location = locate;
            context.SaveChanges();

        }


        public void delete_station(int id)
        {

            Stations station = context.Stations.SingleOrDefault(c => c.StationID == id);

            context.Stations.Remove(station);
            context.SaveChanges();
            

        }

    }
}
