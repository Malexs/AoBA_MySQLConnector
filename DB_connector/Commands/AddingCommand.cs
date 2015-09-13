using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql;
using MySql.Data.MySqlClient;

namespace Bank_Assistant.Commands
{
    class AddingCommand:IDisposable
    {

        MySqlCommand myCom;
        Int32 lastID;

        /*
         * Assembly all of INSERTING methods
         * Receive massive of string with info
         * tmp - params
         */
        public void Execute(MySqlCommand myCommand,params String[] args)
        {
                myCom = myCommand;
                try
                {
                    AddUserInfo(args[0], args[1], args[2]);
                    AddUserBirth(args[3], args[4], args[5]);
                    AddUserPassInfo(args[6], args[7], args[8], args[9], args[10]);
                    AddUserAddresses(args[11], args[12], args[13], args[14]);
                    AddUserContacts(args[15], args[16], args[17]);
                    AddUserWork(args[18], args[19], args[20]);
                    AddUserSocial(args[21], args[22], args[23], args[24], args[25]);
                }
            catch (MySqlException)
            {
                CancelLastInsert();
            }
        }

        /*
         * Add standart user information.
         * args:
         * 0 - first name
         * 1 - second name
         * 2 - father's name
         */
        private void AddUserInfo(params String[] args)
        {
            String infoInsertString = @"INSERT INTO user_info(user_fname,user_sname,user_fatname) 
                                                VALUES" + "(@client_name,@client_surname,@client_fname);";
            myCom.CommandText = infoInsertString;
            myCom.Parameters.Clear();
            myCom.Parameters.AddWithValue("@client_name", args[0]);
            myCom.Parameters.AddWithValue("@client_surname", args[1]);
            myCom.Parameters.AddWithValue("@client_fname", args[2]);

            myCom.ExecuteNonQuery();
            lastID = (Int32)myCom.LastInsertedId;
        }

        /*
         * Add information about user's birthday
         * args:
         * 0 - birthday
         * 1 - sex
         * 2 - birth place
         */
        private void AddUserBirth(params String[] args)
        {
            String birthInsertString = @"INSERT INTO user_birth_info(user_id,user_birthday,user_sex,user_birth_place) 
                                                VALUES" + "(@id,@birthday,@sex,@place);";
            myCom.CommandText = birthInsertString;
            myCom.Parameters.Clear();
            myCom.Parameters.AddWithValue("@id", lastID);
            myCom.Parameters.AddWithValue("@birthday", args[0]);
            myCom.Parameters.AddWithValue("@sex", args[1]);
            myCom.Parameters.AddWithValue("@place", args[2]);

            myCom.ExecuteNonQuery();
        }

        /*
         * Add passport information about user
         * args:
         * 0 - passport serie
         * 1 - passport number
         * 2 - identification number
         */
        private void AddUserPassInfo(params String[] args)
        {
            String userPassportString = @"INSERT INTO user_passport_info(user_id,user_passport_serie,user_passport_number,
                                                user_passport_ID,user_passport_authority,user_passport_issue) 
                                                VALUES" + "(@id,@serie,@number,@ppID,@auth,@issue);";
            myCom.CommandText = userPassportString;
            myCom.Parameters.Clear();
            myCom.Parameters.AddWithValue("@id", lastID);
            myCom.Parameters.AddWithValue("@serie", args[0]);
            myCom.Parameters.AddWithValue("@number", args[1]);
            myCom.Parameters.AddWithValue("@ppID", args[2]);
            myCom.Parameters.AddWithValue("@auth", args[3]);
            myCom.Parameters.AddWithValue("@issue", args[4]);

            myCom.ExecuteNonQuery();
        }

        /*
         * Add addresses user lives in fact and used in documents
         * args:
         * 0 - actual town
         * 1 - actual address
         * 2 - official town
         * 3 - officical address
         */
        private void AddUserAddresses(params String[] args)
        {
            String userAddressesString = @"INSERT INTO user_addresses(user_id,user_actual_town,user_actual_address,
                                                user_official_town,user_official_address) VALUES" + 
                                                "(@id,@act_town,@act_addr,@off_town,@off_addr);";
            myCom.CommandText = userAddressesString;
            myCom.Parameters.Clear();
            myCom.Parameters.AddWithValue("@id", lastID);
            myCom.Parameters.AddWithValue("@act_town", args[0]);
            myCom.Parameters.AddWithValue("@act_addr", args[1]);
            myCom.Parameters.AddWithValue("@off_town", args[2]);
            myCom.Parameters.AddWithValue("@off_addr", args[3]);

            myCom.ExecuteNonQuery();
        }

        /*
         * Add user's contacts (phones, e-mail)
         * args:
         * 0 - homephone
         * 1 - mobile phone
         * 2 - e-mail
         */
        private void AddUserContacts(params String[] args)
        {
            String userContactString = @"INSERT INTO user_contacts(user_id,user_homephone,user_mobilephone,
                                                user_email) VALUES" + "(@id,@home,@mobile,@email);";
            myCom.CommandText = userContactString;
            myCom.Parameters.Clear();
            myCom.Parameters.AddWithValue("@id", lastID);
            myCom.Parameters.AddWithValue("@home", args[0]);
            myCom.Parameters.AddWithValue("@mobile", args[1]);
            myCom.Parameters.AddWithValue("@email", args[2]);
            
            myCom.ExecuteNonQuery();
        }

        /*
         * Add information about user's workplace
         * args:
         * 0 - workplace
         * 1 - position
         * 2 - salary
         */
        private void AddUserWork(params String[] args)
        {
            String userWorkString = @"INSERT INTO user_work_info(user_id,user_workplace,user_position,
                                                user_month_profit) VALUES" + "(@id,@place,@pos,@salary);";
            myCom.CommandText = userWorkString;
            myCom.Parameters.Clear();
            myCom.Parameters.AddWithValue("@id", lastID);
            myCom.Parameters.AddWithValue("@place", args[0]);
            myCom.Parameters.AddWithValue("@pos", args[1]);
            myCom.Parameters.AddWithValue("@salary", args[2]);

            myCom.ExecuteNonQuery();
        }

        /*
         * Add user's social information
         * args:
         * 0 - family
         * 1 - citizen of
         * 2 - if invalid
         * 3 - oldman (bool)
         * 4 - army (bool)
         */
        private void AddUserSocial(params String[] args)
        {
            String userAddressesString = @"INSERT INTO user_social(user_id,user_family,user_citizen,
                                                user_invalid,user_oldman,user_army) VALUES" +
                                                "(@id,@family,@citizen,@invalid,@old,@army);";
            myCom.CommandText = userAddressesString;
            myCom.Parameters.Clear();
            myCom.Parameters.AddWithValue("@id", lastID);
            myCom.Parameters.AddWithValue("@family", args[0]);
            myCom.Parameters.AddWithValue("@citizen", args[1]);
            myCom.Parameters.AddWithValue("@invalid", args[2]);
            myCom.Parameters.AddWithValue("@old", args[3]);
            myCom.Parameters.AddWithValue("@army", args[4]);

            myCom.ExecuteNonQuery();
        }

        private void CancelLastInsert()
        {
            String deleteString = @"DELETE FROM user_info WHERE user_info.user_id=@id;";

            myCom.CommandText = deleteString;
            myCom.Parameters.Clear();
            myCom.Parameters.AddWithValue("@id", lastID);
            myCom.ExecuteNonQuery();
        }

        public void Dispose()
        {
            myCom.Dispose();
        }
    }
}
