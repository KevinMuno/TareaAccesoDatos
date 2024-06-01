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
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Inventory (MakeId) VALUES (@MakeId)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MakeId", entity.MakeId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

        }

        public void Delete(int id)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM Inventory WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<Inventory> GetAll()
        {
            var inventory = new List<Inventory>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Inventory";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        inventory.Add(new Inventory
                        {
                            ID = reader.GetInt32(0),
                            MakeId = reader.GetInt32(0),
                            PetName = reader.GetString(1),
                            Color = reader.GetString(2),
                            TimeStamp = (byte[])reader["TimeStamp"]
                        });
                    }
                }
            }
            return inventory;
        }

        public Inventory GetById(int id)
        {
            Inventory inventory = null;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Inventory WHERE Id = @Id Where Color = @Color Where MakeID = @MakeId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        inventory = new Inventory
                        {
                            ID = reader.GetInt32(0),
                            PetName = reader.GetString(1),
                            MakeId = reader.GetInt32(0),
                            Color = reader.GetString(2),
                            TimeStamp = (byte[])reader["TimeStamp"]
                        };
                    }
                }
            }
            return inventory;
        }

        public void Update(Inventory entity)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Inventory SET PetName = @PetName WHERE Id = @Id Where Color = @Color Where MakeID = @MakeId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PetName", entity.PetName);
                cmd.Parameters.AddWithValue("@Id", entity.ID);
                cmd.Parameters.AddWithValue("@Color", entity.Color);
                cmd.Parameters.AddWithValue("@MakeId", entity.MakeId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
