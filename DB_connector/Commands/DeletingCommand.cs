using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql;
using MySql.Data.MySqlClient;

namespace Bank_Assistant.Commands
{
    class DeletingCommand:IDisposable
    {
        MySqlCommand myCom = null;

        public DeletingCommand(MySqlCommand myCom)
        {
            this.myCom = myCom;
        }

        /*
         * Delete info from database
         * arg:
         *  number of String to delete
         */
        public void Execute(String arg)
        {
            String deleteString = @"DELETE FROM user_info WHERE user_info.user_id=@id;";
            myCom.CommandText = deleteString;
            myCom.Parameters.AddWithValue("@id", arg);

            myCom.ExecuteReader();
        }

        public void Dispose()
        {

        }
    }
}
