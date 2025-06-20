using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Repositories;

namespace UnicomTICManagementSystem.Controllers
{
    internal class StudentController
    {
        public void AddStudent(Student student)
        {

            using (var conn = Database.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Students (Name , Id , NIC_Number) VALUES (@name , @id ,@nic_number)";
                cmd.Parameters.AddWithValue("@name", student.Name);
                cmd.Parameters.AddWithValue("@id", student.Id);
                cmd.Parameters.AddWithValue("@nic_number", student.NIC_Number);
                cmd.ExecuteNonQuery();
            }

        }  

        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();

            try
            {
                using (var conn = Database.GetConnection())
                {
                  // conn.Open(); 
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT * FROM Students";

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            students.Add(new Student
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

            return students;

        }

        public void UpdateStudent(Student student)
        {
            using (var conn = Database.GetConnection())

            {
               // conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE Students SET Name = @name, NIC_Number = @nic_number WHERE Id = @id";
                cmd.Parameters.AddWithValue("@name", student.Name);
                cmd.Parameters.AddWithValue("@nic_number", student.NIC_Number);
                cmd.Parameters.AddWithValue("@id", student.Id);

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteStudent(string id)
        {
            using (var conn = Database.GetConnection()) 

            {
               
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Students WHERE Id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }


        }




    }



        
    

    
}
