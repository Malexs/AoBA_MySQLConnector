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
             "user_birth_info.Birthday=","user_birth_info.Sex=","user_birth_info.Birth_place=",
             "user_passport_info.Passport_serie=","user_passport_info.Passport_number=","user_passport_info.Passport_ID=","user_passport_info.passport_authority=","user_passport_info.passport_issue=",
             "user_addresses.Actual_town=","user_addresses.Actual_address=","user_addresses.Official_town=","user_addresses.Official_address=",
             "user_contacts.Homephone=","user_contacts.Mobilephone=","user_contacts.Email=",
             "user_work_info.Workplace=","user_work_info.Position=","user_work_info.Salary",
             "user_social.Family=","user_social.Citizen=","user_social.Invalid=","user_social.Oldie=","user_social.Army="
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
            myCommand.CommandText = updater;
            myCommand.Parameters.Clear();

            myCommand.ExecuteNonQuery();
        }

        private Boolean AddTablesList(List<Int32> pos)
        {
            if (pos.Count == 0) return false;
            foreach (int i in pos)
            {
                switch (i)
                {
                    case 0:
                    case 1:
                    case 2:
                        if (!updTableString.Contains("user_info")) updTableString += "user_info";
                        break;
                    case 3:
                    case 4:
                    case 5:
                        if (!updTableString.Contains("user_birth_info"))
                        {
                            if (updTableString.Length > 7) updTableString += ",";
                            updTableString += "user_birth_info";
                        }
                        break;
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        if (!updTableString.Contains("user_passport_info"))
                        {
                            if (updTableString.Length > 7) updTableString += ",";
                            updTableString += "user_passport_info,";
                        }
                        break;
                    case 11:
                    case 12:
                    case 13:
                    case 14:
                        if (!updTableString.Contains("user_addresses"))
                        {
                            if (updTableString.Length > 7) updTableString += ",";
                            updTableString += "user_addresses";
                        }
                        break;
                    case 15:
                    case 16:
                    case 17:
                        if (!updTableString.Contains("user_contacts"))
                        {
                            if (updTableString.Length > 7) updTableString += ",";
                            updTableString += "user_contacts,";
                        }
                        break;
                    case 18:
                    case 19:
                    case 20:
                        if (!updTableString.Contains("user_work_info"))
                        {
                            if (updTableString.Length > 7) updTableString += ",";
                            updTableString += "user_work_info,";
                        }
                        break;
                    case 21:
                    case 22:
                    case 23:
                    case 24:
                    case 25:
                        if (!updTableString.Contains("user_social"))
                        {
                            if (updTableString.Length > 7) updTableString += ",";
                            updTableString += "user_social";
                        }
                        break;
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
