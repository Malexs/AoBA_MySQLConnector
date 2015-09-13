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


        /*args: the whole user information  */
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
                 }
            myCommand.Connection.Close();               
            }
        }

        /* */
        public DataTable SelectInformation(params Object[] args)
        {
            DataTable result = null;
            using (MySqlConnection myCon = new MySqlConnection(connString))
            {
                myCommand = new MySqlCommand();
                myCommand.Connection = myCon;
                myCommand.Connection.Open();
                using (SelectingCommand SelCmd = new SelectingCommand(myCommand))
                {
                    switch (args.Length)
                    {
                        case 0:
                            result = SelCmd.GetReqInfo();
                            break;
                        case 1:
                            result = SelCmd.GetReqInfo((int)args[0]);
                            break;
                        case 2:
                        case 3:
                            result = SelCmd.GetReqInfo((String)args[0], (String)args[1], (String)args[2]);
                            break;
                    }
                }
                myCommand.Connection.Close();
            }
            return result;
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

        public String DeleteInfo(String idString)
        {
            String deleteString = @"DELETE FROM user_info WHERE user_info.user_id=@id;";

            using (MySqlConnection myCon = new MySqlConnection(connString))
            {
                try
                {
                    myCommand = new MySqlCommand(deleteString, myCon);
                    myCommand.Parameters.AddWithValue("@id", idString);
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
