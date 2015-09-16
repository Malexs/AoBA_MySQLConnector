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
        static MySQLConnector instance = null;

        //Connection String
        static String connString = @"server=127.0.0.1;userid=root;password=admin;database=adb_1";


        public static MySQLConnector GetInstance()
        {
            if (instance == null) instance = new MySQLConnector();
            return instance;
        }

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

        public String UpdateInfo(String ID,List<Int32> diffs,params String[] args)
        {
            using (MySqlConnection myCon = new MySqlConnection(connString))
            {
                myCommand = new MySqlCommand();
                myCommand.Connection = myCon;
                myCommand.Connection.Open();
                using (UpdatingCommand updCmd = new UpdatingCommand(myCommand))
                {
                    updCmd.Execute(ID,diffs,args);
                }
                myCommand.Connection.Close();
            }
            return null;
        }

        public String DeleteInfo(String idString)
        {
            using (MySqlConnection myCon = new MySqlConnection(connString))
            {
                try
                {
                    myCommand = new MySqlCommand();
                    myCommand.Connection = myCon;
                    myCommand.Connection.Open();
                    using (DeletingCommand delCmd = new DeletingCommand(myCommand))
                    {
                        delCmd.Execute(idString);
                    }
                    myCommand.Connection.Close();
                    return "Okay";
                }
                catch (MySqlException ex)
                {
                    return ex.ToString();
                }
            }
        }

        public Boolean IfExists(params String[] args)
        {
            Boolean result = false;
            using (MySqlConnection myCon = new MySqlConnection(connString))
            {
                myCommand = new MySqlCommand();
                myCommand.Connection = myCon;
                myCommand.Connection.Open();
                using (SelectingCommand SelCmd = new SelectingCommand(myCommand))
                {
                    result = SelCmd.GetFIOCheck(args[0], args[1], args[2]);
                }
                myCommand.Connection.Close();
                return result;
            }
        }

        public Boolean IfExistsPassport(params String[] args)
        {
            Boolean result = false;
            using (MySqlConnection myCon = new MySqlConnection(connString))
            {
                myCommand = new MySqlCommand();
                myCommand.Connection = myCon;
                myCommand.Connection.Open();
                using (SelectingCommand SelCmd = new SelectingCommand(myCommand))
                {
                    result = SelCmd.GetPassportCheck(args[0], args[1]);
                }
                myCommand.Connection.Close();
                return result;
            }
        }

        public void Dispose()
        {

        }
    }
}
