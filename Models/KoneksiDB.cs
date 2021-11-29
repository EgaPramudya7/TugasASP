using MySql.Data.MySqlClient;

namespace latihan1.Models
{
    public class KoneksiDB
    {
        private static string username="root";
        private static string password="";
        private static string server="localhost";
        private static string db="kampus";
        private MySqlConnection conn;
        string cs = @"server="+server+";userid="+username+";password="+password+";database"+ db;
        public MySqlConnection openConnection(){
            if(conn!=null){
                return conn;
            }else{
                conn = new MySqlConnection(cs);
                return conn;
            }
            }//end openConnection
            public bool checkConnection(){
                bool result = false;
                MySqlConnection connection = openConnection();
                try{
                    connection.Open();
                    result = true;
                    connection.Close();
                }catch(MySqlException ex){
                    string e=ex.ToString();
                    result = false;
                }
                return result;

            }//end checkConnection
        }//end koneksiDB
    }//end models



