using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql;
using MySql.Data.MySqlClient;

namespace Bank_Assistant.Commands
{
    class SelectingCommand:IDisposable
    {
        public void SelectInfo(MySqlCommand myCommand,params String[] args)//String name,String surname,String fathername)
        {
            String addUserInfo = @"INSERT INTO user_info(user_fname,user_sname,user_fatname) 
                                                VALUES" + "(@client_name,@client_surname,@client_fname);";
            //myCommand = new MySqlCommand(addUserInfo, myCon);
            //myCommand.Connection.Open();
            myCommand.CommandText = addUserInfo;
            myCommand.Parameters.AddWithValue("@client_name", args[0]);
            myCommand.Parameters.AddWithValue("@client_surname", args[1]);
            myCommand.Parameters.AddWithValue("@client_fname", args[2]);
        }

        public void Dispose()
        {

        }
    }
}
