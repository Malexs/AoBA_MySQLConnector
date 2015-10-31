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

        /*
         * Assembly all of INSERTING methods
         * Receive massive of string with info
         * tmp - params
         */
        public void Execute(MySqlCommand myCommand,params String[] args)
        {
            String infoInsertString = "";
                myCom = myCommand;
                try
                {
                    switch (args.Length)
                    {
                        case 26:
                            infoInsertString = @"INSERT INTO user_info(First_name,Second_name,Fathers_name,
                                                        Birthday,Sex,Birth_place,
                                                        Passport_serie,Passport_number,Passport_ID,Passport_authority,Passport_issue,
                                                        Actual_town,Actual_address,Official_town,Official_address,
                                                        Homephone,Mobilephone,Email,
                                                        Workplace,Position,Salary,
                                                        Family,Citizen,Invalid,Oldie,Army) 
                                                        VALUES(@name,@sur,@fath,
                                                                @day,@sex,@place,
                                                                @serie,@num,@id,@auth,@iss,
                                                                @at,@aa,@ot,@oa,
                                                                @hphone,@mphone,@email,
                                                                @wplace,@pos,@sal,
                                                                @fam,@cit,@inv,@old,@arm);";
                            myCom.CommandText = infoInsertString;
                            myCom.Parameters.Clear();
                            #region setArgs
                                myCom.Parameters.AddWithValue("@name", args[0]);
                                myCom.Parameters.AddWithValue("@sur", args[1]);
                                myCom.Parameters.AddWithValue("@fath", args[2]);
                                myCom.Parameters.AddWithValue("@day", args[3]);
                                myCom.Parameters.AddWithValue("@sex", args[4]);
                                myCom.Parameters.AddWithValue("@place", args[5]);
                                myCom.Parameters.AddWithValue("@serie", args[6]);
                                myCom.Parameters.AddWithValue("@num", args[7]);
                                myCom.Parameters.AddWithValue("@id", args[8]);
                                myCom.Parameters.AddWithValue("@auth", args[9]);
                                myCom.Parameters.AddWithValue("@iss", args[10]);
                                myCom.Parameters.AddWithValue("@at", args[11]);
                                myCom.Parameters.AddWithValue("@aa", args[12]);
                                myCom.Parameters.AddWithValue("@ot", args[13]);
                                myCom.Parameters.AddWithValue("@oa", args[14]);
                                myCom.Parameters.AddWithValue("@hphone", args[15]);
                                myCom.Parameters.AddWithValue("@mphone", args[16]);
                                myCom.Parameters.AddWithValue("@email", args[17]);
                                myCom.Parameters.AddWithValue("@wplace", args[18]);
                                myCom.Parameters.AddWithValue("@pos", args[19]);
                                myCom.Parameters.AddWithValue("@sal", args[20]);
                                myCom.Parameters.AddWithValue("@fam", args[21]);
                                myCom.Parameters.AddWithValue("@cit", args[22]);
                                myCom.Parameters.AddWithValue("@inv", args[23]);
                                myCom.Parameters.AddWithValue("@old", args[24]);
                                myCom.Parameters.AddWithValue("@arm", args[25]);
                                #endregion
                            break;
                        case 8:
                            infoInsertString = @"INSERT INTO Agreement(Agree_id,Agree_dep_id,Agree_curr,
                                                                        Agree_start,Agree_depo_end,Agree_summ,Agree_client,Agree_end) 
                                                        VALUES(@id,@dep,@curr,
                                                                @start,@dep_end,@summ,@client,@end);";
                            myCom.CommandText = infoInsertString;
                            myCom.Parameters.Clear();
                            #region setArgs
                                myCom.Parameters.AddWithValue("@id", args[0]);
                                myCom.Parameters.AddWithValue("@dep", args[1]);
                                myCom.Parameters.AddWithValue("@curr", args[2]);
                                myCom.Parameters.AddWithValue("@start", args[3]);
                                myCom.Parameters.AddWithValue("@dep_end", args[4]);
                                myCom.Parameters.AddWithValue("@summ", args[5]);
                                myCom.Parameters.AddWithValue("@client", args[6]);
                                myCom.Parameters.AddWithValue("@end", args[7]);
                                #endregion
                            break;
                    }
                    myCom.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    throw ex;
                }
        }

        public void Dispose()
        {
            myCom.Dispose();
        }
    }
}
