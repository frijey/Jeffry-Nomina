using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Tarea_3_CRUD
{
    public class operacion
    {

        public string Conectar()
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\sistema\\nomina.db; version=3");
            try
            {
                cnx.Open();
                return "Conecxión Exitosa";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo Un Problema En La Sintaxis Del Comando Sql", "Error");
                return ex.Message;
            }
            finally
            {
                cnx.Close();
            }
            
        }
        
        public string ConsultaSinResultado(string sql)
        {

            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\sistema\\nomina.db;Version=3;");
            try
            {
                cnx.Open();
                SQLiteCommand command = new SQLiteCommand(sql, cnx);
                command.ExecuteNonQuery();
                return "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo Un Problema En La Sintaxis Del Comando Sql","Error");
                return ex.Message;
            }
            finally
            {
                cnx.Close();
            }

        }

        public DataSet ConsultaConResultadods(string sql)
        {

            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\sistema\\nomina.db;Version=3;");
            try
            {
                cnx.Open();
                DataSet ds = new DataSet();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, cnx);
                adapter.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo Un Problema En La Sintaxis Del Comando Sql", "Error");
                return null;
            }
            finally
            {
                cnx.Close();
            }

        }

        public DataTable ConsultaConResultadodt(string sql)
        {

            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\sistema\\nomina.db;Version=3;");
            try
            {
                cnx.Open();
                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, cnx);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo Un Problema En La Sintaxis Del Comando Sql", "Error");
                return null;
            }
            finally
            {
                cnx.Close();
            }

        }

    }
}
