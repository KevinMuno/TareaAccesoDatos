using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONET_Inventory
{
    public class InventoryRepository : IRepositoryInventory<Inventory>
    {
        private readonly string _connectionString;

        public InventoryRepository (string connectionString)
        {
            _connectionString = connectionString;
        }
        public void Add(Inventory entity)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("INSERT INTO Inventory (MakeID, Color, PetName) VALUES( @MakeID, @Color, @PetName)", connection);
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
                var command = new SqlCommand("DELETE FROM Inventory Where ID = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Inventory> GetAll()
        {
            var inventory = new List<Inventory>();
            using ( var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand ("SELECT * FROM Inventory", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        inventory.Add(new Inventory
                        {
                            ID = (int)reader["ID"],
                            MakeId = (int)reader["MAKEID"],
                            Color = reader["COLOR"].ToString(),
                            PetName = reader["PETNAME"].ToString(),
                            TimeStamp = (byte[])reader["TIMESTAMP"]
                        });
                    }
                }
            }
            return inventory;
        }

        public Inventory GetById(int id)
        {
            Inventory inventory = null;
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand ("SELECT * FROM Inventory WHERE ID = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                using (var reader = command.ExecuteReader() )
                {
                    if (reader.Read())
                    {
                        inventory = new Inventory
                        {
                            ID = (int)reader["ID"],
                            MakeId = (int)reader["MAKEID"],
                            Color = reader["COLOR"].ToString(),
                            PetName = reader["PETNAME"].ToString(),
                            TimeStamp = (byte[])reader["TIMESTAMP"]
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
                var command = new SqlCommand("UPDATE Inventory SET MakeId = @MakeId, Color = @Color, PetName  = @PetName WHERE ID = @Id", connection);

               command.Parameters.AddWithValue("@Id", entity.ID);
               command.Parameters.AddWithValue("@MakeId", entity.MakeId);
               command.Parameters.AddWithValue("@Color", entity.Color);
               command.Parameters.AddWithValue("@PetName", entity.PetName);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
