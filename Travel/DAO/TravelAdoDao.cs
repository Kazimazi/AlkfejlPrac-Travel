using System.Data.SQLite;
using TravelCore.Model;

namespace TravelCore.DAO
{
    internal class TravelAdoDao : ITravelDao
    {
        private const string CONNECTION_STRING = @"Data Source=../../../../DB/utazasok.db;";

        public bool AddTravel(Travel travel)
        {
            using SQLiteConnection conn = new SQLiteConnection(CONNECTION_STRING);
            conn.Open();
            SQLiteCommand command = conn.CreateCommand();
            command.CommandText =
                "insert into Items " +
                "(Name, Category, Country, Description, Priority) values " +
                "(@name, @category, @country, @description, @priority);";

            command.Parameters.Add("name", System.Data.DbType.String).Value = travel.Name;
            command.Parameters.Add("category", System.Data.DbType.String).Value = travel.Category;
            command.Parameters.Add("country", System.Data.DbType.String).Value = travel.Country;
            command.Parameters.Add("description", System.Data.DbType.String).Value = travel.Description;
            command.Parameters.Add("priority", System.Data.DbType.Int32).Value = travel.Priority;

            bool isSuccess;
            try
            {
                command.ExecuteNonQuery();
                isSuccess = true;
            }
            catch (Exception e)
            {
                isSuccess = false;
            }
            return isSuccess;
        }

        public IEnumerable<string> GetCategories()
        {
            List<string> categories = new List<string>();

            using SQLiteConnection conn = new SQLiteConnection(CONNECTION_STRING);
            conn.Open();
            SQLiteCommand command = conn.CreateCommand();
            command.CommandText =
                "select * from Items " +
                "group by Category";

            using SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                categories.Add(reader.GetString(reader.GetOrdinal("Category")));
            }

            return categories;
        }

        public Travel GetTravel(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Travel> GetTravels()
        {
            List<Travel> travels = new List<Travel>();

            using SQLiteConnection conn = new SQLiteConnection(CONNECTION_STRING);
            conn.Open();
            SQLiteCommand command = conn.CreateCommand();
            command.CommandText = "select * from Items";

            using SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                travels.Add(
                    new Travel
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("ID")),
                        Name = reader.GetString(reader.GetOrdinal("Name")),
                        Category = reader.GetString(reader.GetOrdinal("Category")),
                        Country = reader.GetString(reader.GetOrdinal("Country")),
                        Description = reader.GetString(reader.GetOrdinal("Description")),
                        Priority = reader.GetInt32(reader.GetOrdinal("Priority")),
                    }
                );
            }

            return travels;
        }

        public IEnumerable<Travel> GetTravelsOfCategory(string category)
        {
            List<Travel> travels = new List<Travel>();

            using SQLiteConnection conn = new SQLiteConnection(CONNECTION_STRING);
            conn.Open();
            SQLiteCommand command = conn.CreateCommand();
            command.CommandText =
                "select * from Items " +
                "where Category=@category";
            command.Parameters.Add("category", System.Data.DbType.String).Value = category;

            using SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                travels.Add(
                    new Travel
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("ID")),
                        Name = reader.GetString(reader.GetOrdinal("Name")),
                        Category = reader.GetString(reader.GetOrdinal("Category")),
                        Country = reader.GetString(reader.GetOrdinal("Country")),
                        Description = reader.GetString(reader.GetOrdinal("Description")),
                        Priority = reader.GetInt32(reader.GetOrdinal("Priority")),
                    }
                );
            }

            return travels;
        }

        public int TravelsCount()
        {
            throw new NotImplementedException();
        }
    }
}
