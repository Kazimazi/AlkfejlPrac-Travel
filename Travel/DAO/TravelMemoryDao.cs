using TravelCore.Model;

namespace TravelCore.DAO
{
    internal class TravelMemoryDao : ITravelDao
    {
        private IList<Travel> travels = new List<Travel>();

        public bool AddTravel(Travel travel)
        {
            if (travel == null) return false;
            if (travels.Any(x => x.Name == travel.Name)) return false;
            
            travels.Add(travel);
            return true;
        }

        public Travel GetTravel(int id)
        {
            return travels.FirstOrDefault(x => x.Id == id);
        }

        public int TravelsCount()
        {
            return travels.Count();
        }

        public IEnumerable<Travel> GetTravels()
        {
            return travels;
        }

        public IEnumerable<Travel> GetTravelsOfCategory(string category)
        {
            return travels.Where(x => x.Category == category);
        }

        public IEnumerable<string> GetCategories()
        {
            return travels.Select(x => x.Category).Distinct();
        }
    }
}
