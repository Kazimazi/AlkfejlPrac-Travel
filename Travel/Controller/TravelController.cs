using TravelCore.DAO;
using TravelCore.Model;

namespace TravelCore.Controller
{
    internal class TravelController
    {
        private readonly ITravelDao dao;
        public TravelController(ITravelDao dao)
        {
            this.dao = dao;
        }

        public bool AddTravel(Travel travel)
        {
            // int id = dao.TravelsCount();
            // travel.Id = id;

            return dao.AddTravel(travel);
        }

        public Travel GetTravel(int id)
        {
            return dao.GetTravel(id);
        }

        public IEnumerable<Travel> GetTravels()
        {
            return dao.GetTravels();
        }

        public IEnumerable<Travel> GetTravelsOfCategory(string category)
        {
            return dao.GetTravelsOfCategory(category);
        }

        public IEnumerable<string> GetCategories()
        {
            return dao.GetCategories();
        }
    }
}
