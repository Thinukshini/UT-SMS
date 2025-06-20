using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Repositories;
namespace UnicomTICManagementSystem.Controllers
{
    internal class StaffController
    {
        public void AddStaff(Staff staff)
        {

            using (var conn = Database.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Staffs (Name , Id , NIC_Number) VALUES (@name , @id ,@nic_number)";
                cmd.Parameters.AddWithValue("@name", staff.Name);
                cmd.Parameters.AddWithValue("@id", staff.ID);
                cmd.Parameters.AddWithValue("@nic_number", staff.NIC_Number);
                cmd.ExecuteNonQuery();
            }
        }


        public List<Staff> GetAllStaff()
        {
            List<Staff> staffs = new List<Staff>();

            try
            {
                using (var conn = Database.GetConnection())
                {
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT * FROM Staffs";

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            staffs.Add(new Staff
                            {
                                ID = reader.GetString(0),
                                Name = reader.GetString(1),
                                NIC_Number = reader.GetString(2)
                            });
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return staffs;

            
        }
        public void UpdateStaff(Staff staff)
        {
            using (var conn = Database.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE Staffs SET Name = @name, ID = @id WHERE NIC_Number = @nic_number";
                cmd.Parameters.AddWithValue("@name", staff.Name);
                cmd.Parameters.AddWithValue("@nic_number", staff.NIC_Number);
                cmd.Parameters.AddWithValue("@id", staff.ID);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteStaff(int id)
        {
            using (var conn = Database.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Staffs WHERE Id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }


        }
    }
}
