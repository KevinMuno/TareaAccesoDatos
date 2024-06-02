using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONETInventory
{
    public class InventoryRepository : IRepositoryInventory<Inventory>
    {
        private readonly string _connectionString;

        public InventoryRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void Add(Inventory entity)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("INSERT INTO Inventory (MakeId, Color, PetName) VALUES (@MakeId, @Color, @PetName)", connection);
                command.Parameters.AddWithValue("@MakeId", entity.MakeId);
                command.Parameters.AddWithValue("@Color", entity.Color);
                command.Parameters.AddWithValue("@PetName", entity.PetName);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("DELETE FROM Inventory WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Inventory> GetAll()
        {
            var inventories = new List<Inventory>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Inventory";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        inventories.Add(new Inventory
                        {
                            Id = (int)reader["Id"],
                            MakeId = (int)reader["MakeId"],
                            Color = reader["Color"].ToString(),
                            PetName = reader["PetName"].ToString(),
                            TimeStamp = (byte[])reader["TimeStamp"]
                        });
                    }
                }
            }
            return inventories;
        }

        public Inventory GetById(int id)
        {
            Inventory inventory = null;
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("SELECT * FROM Inventory WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        inventory = new Inventory
                        {
                            Id = (int)reader["Id"],
                            MakeId = (int)reader["MakeId"],
                            Color = reader["Color"].ToString(),
                            PetName = reader["PetName"].ToString(),
                            TimeStamp = (byte[])reader["TimeStamp"]
                        };
                    }
                }
            }
            return inventory;
        }

        public void Update(Inventory entity)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("UPDATE Inventory SET MakeId = @MakeId, Color = @Color, PetName = @PetName WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", entity.Id);
                command.Parameters.AddWithValue("@MakeId", entity.MakeId);
                command.Parameters.AddWithValue("@Color", entity.Color);
                command.Parameters.AddWithValue("@PetName", entity.PetName);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
