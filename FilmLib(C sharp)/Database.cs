using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmLib_C_sharp_
{
     public class Database : IDisposable                        //database queries handling class
    {
        private SqlConnection sqlcon;
        private SqlCommand cmd;
        private SqlDataReader reader;
        
        public Database()
        {
            //sqlcon = new SqlConnection("Server=DESKTOP-HCQ603N;Database=FilmLib;Integrated Security=SSPI");
            sqlcon = new SqlConnection(@"Data Source=192.168.0.110\SQLEXPRESS,1433;Initial Catalog=FilmLib;User ID=sa;Password=Thachotao96@");
           
            try
            {
                if (sqlcon.State != ConnectionState.Open)
                {
                    sqlcon.Open();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        
        public List<object> getData(string tbl, string col, string cond)       //get data from one column with condition specified
        {
            List<object> data = new List<object>();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "SELECT " + col + " FROM " + tbl + " WHERE " + cond;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = sqlcon;
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        data.Add(reader.GetValue(0));
                        
                    }
                }
                reader.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return data;
            
        }

        public List<object> getDataFromJoin(string tbl1, string tbl2, string key, string col, string cond)      //get data from one column with 2 joined tables and condition specified
        {
            List<object> data = new List<object>();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "SELECT " + col + " FROM " + tbl1 + " a Join " + tbl2 + " b On a." + key + "=b." + key + " WHERE " + cond;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = sqlcon;
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        data.Add(reader.GetValue(0));
                        
                    }
                }
                reader.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return data;

        }
        public void storeData(string tbl, string cols, string vals)                     //insert new row to the table
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO " + tbl + " (" + cols + ") VALUES (" + vals + ")";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = sqlcon;
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void rmRow(string tbl, string conds)                                     //delete a row from the table
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "DELETE FROM " + tbl + " WHERE " + conds;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = sqlcon;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)                                  //let the GC know that the instance of this class won't be used anymore, so the GC can release the memory whenever it's available
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    cmd.Dispose();
                    
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.
                
                if(sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
                sqlcon.Dispose();
                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
         ~Database() {
           // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
           Dispose(false);
         }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            GC.SuppressFinalize(this);
        }
        #endregion
        

    }
}
