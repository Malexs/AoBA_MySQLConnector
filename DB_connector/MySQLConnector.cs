using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using MySql;
using MySql.Data.MySqlClient;

using Bank_Assistant.Commands;

namespace Bank_Assistant
{
    class MySQLConnector:IDisposable
    {
        MySqlCommand myCommand;

        //Connection String
        static String connString = @"server=127.0.0.1;userid=root;password=admin;database=adb_1";


        /*args: ...  - TODO  */
        public void AddInformation(params String[] args)
        {
            using (MySqlConnection myCon = new MySqlConnection(connString))
            {                
                 myCommand = new MySqlCommand();
                 myCommand.Connection = myCon;
                 myCommand.Connection.Open();
                 using (AddingCommand addCmd = new AddingCommand())
                 {
                     addCmd.Execute(myCommand, args);
                     //addCmd.AddUserInfo(myCommand, args[0], args[1], args[2]);
                     //addCmd.AddUserBirth(args[3], args[4], args[5]);
                 }
            myCommand.Connection.Close();               
            }
        }

        /*args: field sorted by - TODO */
        public DataTable GetInformation()
        {

            String selecting = @"SELECT * FROM user_info
                                INNER JOIN user_birth_info USING (user_id)
                                INNER JOIN user_passport_info USING (user_id)
                                INNER JOIN user_addresses USING (user_id)
                                INNER JOIN user_contacts USING (user_id)
                                INNER JOIN user_work_info USING (user_id)
                                INNER JOIN user_social USING (user_id)
                                ORDER BY user_info.user_sname;";
            DataTable dataTable = null;

            using (MySqlConnection myCon = new MySqlConnection(connString))
            {
                try
                {
                    dataTable = new DataTable();
                    myCommand = new MySqlCommand(selecting, myCon);
                    myCommand.Connection.Open();
                    using (MySqlDataReader dataReader = myCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            dataTable.Load(dataReader);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return dataTable;
        }

        public String UpdateInfo()
        {
            String updater = @"UPDATE user_info SET user_fname='Alexander' WHERE user_info.user_id = 1;";
            using (MySqlConnection myCon = new MySqlConnection(connString))
            {
                try
                {
                    myCommand = new MySqlCommand(updater, myCon);
                    myCommand.Connection.Open();
                    myCommand.ExecuteReader();
                    myCommand.Connection.Close();
                    return "Okay";
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            }
        }

        public String DeleteInfo()
        {
            String deleteString = @"DELETE FROM user_info WHERE user_info.user_id=6;";

            using (MySqlConnection myCon = new MySqlConnection(connString))
            {
                try
                {
                    myCommand = new MySqlCommand(deleteString, myCon);
                    myCommand.Connection.Open();
                    myCommand.ExecuteReader();
                    myCommand.Connection.Close();
                    return "Okay";
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            }
        }

        public void Dispose()
        {

        }
    }
}
