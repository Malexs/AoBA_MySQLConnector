using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql;
using MySql.Data.MySqlClient;

namespace Bank_Assistant.Commands
{
    class UpdatingCommand:IDisposable
    {

        MySqlCommand myCommand = null;
        String updater = @"UPDATE ";
                        //WHERE user_info.user_id = 1;";
        String updTableString = "user_info";
        String updFieldsString = " SET ";

        String[] fields = new String[] {
            "user_info.First_name=", "user_info.Second_name=", "user_info.Fathers_name=",
             "user_info.Birthday=","user_info.Sex=","user_info.Birth_place=",
             "user_info.Passport_serie=","user_info.Passport_number=","user_info.Passport_ID=","user_info.passport_authority=","user_info.passport_issue=",
             "user_info.Actual_town=","user_info.Actual_address=","user_info.Official_town=","user_info.Official_address=",
             "user_info.Homephone=","user_info.Mobilephone=","user_info.Email=",
             "user_info.Workplace=","user_info.Position=","user_info.Salary",
             "user_info.Family=","user_info.Citizen=","user_info.Invalid=","user_info.Oldie=","user_info.Army="
        };

        public UpdatingCommand(MySqlCommand myCom)
        {
            myCommand = myCom;
        }

        public void Execute(String id,List<Int32> positions,params String[] args)
        {
            if (AddTablesList(positions))
            {
                AddParamsList(positions, args);
                updater += updTableString + updFieldsString + " WHERE user_info.user_id="+id+";";
            }
            Console.WriteLine(updater);
            myCommand.CommandText = updater;
            myCommand.Parameters.Clear();

            myCommand.ExecuteNonQuery();
        }

        private Boolean AddTablesList(List<Int32> pos)
        {
            if (pos.Count == 0) return false;
            foreach (int i in pos)
            {
                
                        if (!updTableString.Contains("user_info"))
                        {
                            if (updTableString.Length > 7) updTableString += ",";
                            updTableString += "user_info";
                        }
                
            }
            return true;
        }

        private void AddParamsList(List<Int32> nmb,params String[] args)
        {
            foreach (int i in nmb)
            {
                if (updFieldsString.Length > 5) updFieldsString += ",";
                updFieldsString += fields[i] + "'" +args[i]+"'";
            }
        }

        public void Dispose()
        {

        }
    }
}
