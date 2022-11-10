using TravelCore.Model;

namespace TravelCore.DAO
{
    internal interface ITravelDao
    {
        bool AddTravel(Travel travel);
        Travel GetTravel(int id);
        int TravelsCount();
        IEnumerable<Travel> GetTravels();
        IEnumerable<Travel> GetTravelsOfCategory(string category);
        IEnumerable<string> GetCategories();
    }
}
