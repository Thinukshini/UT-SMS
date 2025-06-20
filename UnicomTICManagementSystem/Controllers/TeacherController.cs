using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Repositories;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UnicomTICManagementSystem.Controllers
{
    internal class TeacherController
    {
        public void AddTeacher(Teacher teacher)
        {

           using (var conn = Database.GetConnection())
            {
               var cmd = conn.CreateCommand();
               cmd.CommandText = "INSERT INTO Teachers (Name , Id , NIC_Number) VALUES (@name , @id ,@nic_number)";
               cmd.Parameters.AddWithValue("@name", teacher.Name);
               cmd.Parameters.AddWithValue("@id", teacher.Id);
               cmd.Parameters.AddWithValue("@nic_number", teacher.NIC_Number);
               cmd.ExecuteNonQuery();
            }


        }

        public List<Teacher> GetAllTeacher()
        {
            List<Teacher> teachers = new List<Teacher>();

            try
            {
                using (var conn = Database.GetConnection())
                {
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT * FROM Teachers";

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            teachers.Add(new Teacher
                            {
                                Id = reader.GetString(0),
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

            return teachers;

        }

        public void UpdateTeacher(Teacher teacher)
        {
            using (var conn = Database.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE Staffs SET Name = @name, ID = @id WHERE NIC_Number = @nic_number";
                cmd.Parameters.AddWithValue("@name", teacher.Name);
                cmd.Parameters.AddWithValue("@nic_number", teacher.NIC_Number);
                cmd.Parameters.AddWithValue("@id", teacher.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteTeacher(int id)
        {
            using (var conn = Database.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Teachers WHERE Id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }


        }





















    }
}
