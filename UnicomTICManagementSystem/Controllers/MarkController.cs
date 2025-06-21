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
    internal class MarkController
    {
        public void AddMarks(Marks marks)
        {
            using (var conn = Database.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Marks (Student_Name ,Marks, Exam_type ,Grade) VALUES (@student_name ,@marks, @exam_type ,@grade)";
                cmd.Parameters.AddWithValue("@student_name", marks.Student_Name);
                cmd.Parameters.AddWithValue("@marks", marks.Mark);
                cmd.Parameters.AddWithValue("@exam_type", marks.Exam_type);
                cmd.Parameters.AddWithValue("@grade", marks.Grade);
                cmd.ExecuteNonQuery();
            }
        }


        public List<Marks> GetAllMarks()
        {
            List<Marks> marks = new List<Marks>();

            try
            {
                using (var conn = Database.GetConnection())
                {
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT * FROM Marks";

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            marks.Add(new Marks
                            {

                                Student_Name = reader.GetString(0),
                                Exam_type = reader.GetString(1),
                                Mark = reader.GetString(2),
                                Grade = reader.GetString(3),
                            });
                        }
                    }
                }
            }

            catch (SQLiteException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return marks;
        }


        public void UpdateMarks(Marks marks)
        {
            using (var conn = Database.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE Marks SET Student_Name = @student_name, Grade = @grade WHERE MarkS = @marks";
                cmd.Parameters.AddWithValue("@student_name", marks.Student_Name);
                cmd.Parameters.AddWithValue("@grade", marks.Grade);
                cmd.Parameters.AddWithValue("@marks",marks.Mark);
                cmd.ExecuteNonQuery();
            }
        }


        public void DeleteMarks(string marks)
        {
            using (var conn = Database.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Marks WHERE Marks = @marks";
                cmd.Parameters.AddWithValue("@marks", marks);
                cmd.ExecuteNonQuery();
            }





        }

    }
}
