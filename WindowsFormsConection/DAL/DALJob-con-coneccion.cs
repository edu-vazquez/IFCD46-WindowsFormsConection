using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace WindowsFormsConection
{
    internal class DALJobWithConnection
    {
         static public void Insertar(Jobs job, DbConnect connection)
        {
            DbConnect DAlJobConnection = connection;

            string sql = $@"INSERT INTO jobs(job_title, min_salary, max_salary) 
                VALUES(@jobTitle, @min_salary, @max_salary)";

            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection.Connection))
                {
                    command.Parameters.AddWithValue("@jobTitle", job.jobTitle ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@min_salary", job.min_salary ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@max_salary", job.max_salary ?? (object)DBNull.Value);

                    if (connection.GetConnectionState() != ConnectionState.Open)
                        connection.Open();

                    command.ExecuteNonQuery();
                    MessageBox.Show("Registro insertado correctamente ✅");
                }
            }
            catch (SqlException)
            {
                //el throw vuelve a lanzar la excepcion para que sea manejada en un nivel superior
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }


        }

    }
}
