using System.Data.SqlClient;
using System.Data;
using System;
using System.Reflection;

namespace JIIDBFramewor
{
    public class DbSQLServer
    {

        private string _connstring;
        public DbSQLServer(string connstring)
        {
            _connstring = connstring;

        }
        // array,collections,Generic,DataTable

        public DataTable GetDataList(string storedProceName)
         {
         DataTable dtData = new DataTable();
         using(SqlConnection conn = new SqlConnection(_connstring))
         {

                using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
                 {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    dtData.Load(reader);
                 }
         }
            return dtData;
        }



        public void SaveOrUpdateRecord(string storedProceName,object obj)
        {

            using (SqlConnection conn = new SqlConnection(_connstring))
            {

                using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    //parameter.

                    Type type = obj.GetType();

                    BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;
                    PropertyInfo[] properties = type.GetProperties(flags);
                    foreach(var property in properties)
                    {
                        cmd.Parameters.AddWithValue("@" + property.Name,property.GetValue(obj,null));

                    }

                    cmd.ExecuteNonQuery();
                
                 }

            }


        }




        //overloading function


        public DataTable GetDataList(string storedProceName,DbParameter parameter)
        {
            DataTable dtData = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connstring))
            {

                using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue(parameter.parameter, parameter.value);

                    SqlDataReader reader = cmd.ExecuteReader();

                    dtData.Load(reader);
                }
            }
            return dtData;
        }




        public DataTable GetDataList(string storedProceName, DbParameter[] parameters)
        {
            DataTable dtData = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connstring))
            {

                using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    foreach(var Para in parameters) {
                    cmd.Parameters.AddWithValue(Para.parameter, Para.value);
                                                       }
                    SqlDataReader reader = cmd.ExecuteReader();

                    dtData.Load(reader);
                }
            }
            return dtData;
        }


        public object GetScalarValue(string storedProceName)
        {


            object value = null;
            using (SqlConnection Conn = new SqlConnection(_connstring))
            {
                using (SqlCommand cmd = new SqlCommand(storedProceName, Conn))

                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    Conn.Open();


                    value = cmd.ExecuteScalar();

                }
            }
            return value;
        }


        public object GetScalarValue(string storedProceName, DbParameter[] parameter)
        {


            object value = null;
            using (SqlConnection Conn = new SqlConnection(_connstring))
            {
                using (SqlCommand cmd = new SqlCommand(storedProceName, Conn))

                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    Conn.Open();
                    foreach(var para in parameter) { 
                    cmd.Parameters.AddWithValue(para.parameter, para.value);
}


                }
            }
            return value;
        }
    }
}