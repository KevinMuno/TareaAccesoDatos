using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONET
{
    public class MakesRepository : IRepositoryMakes<Makes>
    {
        private readonly string _connectionString;

        public MakesRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void Add(Makes entity)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Makes (Name) VALUES (@Name)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", entity.Name);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM Makes WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<Makes> GetAll()
        {
            var makes = new List<Makes>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Makes";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        makes.Add(new Makes
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            TimeStamp = (byte[])reader["TimeStamp"]
                        });
                    }
                }
            }
            return makes;
        }

        public Makes GetById(int id)
        {
            Makes makes = null;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Makes WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        makes = new Makes
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            TimeStamp = (byte[])reader["TimeStamp"]
                        };
                    }
                }
            }
            return makes;
        }

        public void Update(Makes entity)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Makes SET Name = @Name WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", entity.Name);
                cmd.Parameters.AddWithValue("@Id", entity.Id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
