using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using MySql;
using MySql.Data.MySqlClient;

namespace Bank_Assistant.Commands
{
    class SelectingCommand:IDisposable
    {
        MySqlCommand myCommand = null;

        public SelectingCommand(MySqlCommand myCom)
        {
            this.myCommand = myCom;
        }

        public DataTable GetReqInfo(Int32 req)
        {
            String selected = "";
            switch (req)
            {
                case 0:
                    selected = @"SELECT town_Name FROM towns ORDER BY town_ID;";
                    break;
                case 1:
                    selected = @"SELECT family.condition FROM family ORDER BY family_ID;";
                    break;
                case 2:
                    selected = @"SELECT invalid_cond FROM invalid ORDER BY invalid_ID;";
                    break;
                case 3:
                    selected = @"SELECT countries FROM citizens ORDER BY citizens_id;";
                    break;
            }
            DataTable dataTable = null;
            try
            {
                dataTable = new DataTable();
                myCommand.CommandText = selected;
                using (MySqlDataReader dataReader = myCommand.ExecuteReader())
                {
                    if (dataReader.HasRows)
                    {
                        dataTable.Load(dataReader);
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            return dataTable;
        }

        public DataTable GetReqInfo()
        {

            String selecting = @"SELECT * FROM user_info
                                ORDER BY user_info.Second_name;";
            DataTable dataTable = null;

            dataTable = new DataTable();
            try
            {
                myCommand.CommandText = selecting;
                using (MySqlDataReader dataReader = myCommand.ExecuteReader())
                {
                    if (dataReader.HasRows)
                    {
                        dataTable.Load(dataReader);
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            return dataTable;
        }

        public DataTable GetReqInfo(params String[] args)
        {
            String selecting = @"SELECT * FROM user_info
                                WHERE ";
            if (args[0].Length > 0) selecting += "user_info.First_name='" + args[0] + "'";
            if (args[1].Length > 0)
            {
                if (args[0].Length > 0) selecting += "and user_info.Second_name='" + args[1] + "'";
                else selecting += "user_info.Second_name='" + args[1] + "'";
            }
            if (args[2].Length > 0)
            {
                if (args[0].Length > 0 || args[1].Length > 0) selecting += "and user_info.Fathers_name='" + args[2] + "'";
                else selecting += "user_info.Fathers_name='" + args[2] + "'";
            }
            selecting += " ORDER BY user_info.Second_name;";
            Console.WriteLine(selecting);
            DataTable dataTable = null;

            dataTable = new DataTable();
            try
            {
                myCommand.CommandText = selecting;
                using (MySqlDataReader dataReader = myCommand.ExecuteReader())
                {
                    if (dataReader.HasRows)
                    {
                        dataTable.Load(dataReader);
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            return dataTable;
        }

        public Boolean GetFIOCheck(params String[] args)
        {
            Boolean result=false;
            String selecting = @"SELECT * FROM user_info
                                WHERE First_name='"+args[0]+"' and "+
                                "Second_name='"+args[1]+"' and "+"Fathers_name='"+args[2]+"';";
            DataTable dataTable = null;
            dataTable = new DataTable();

            try
            {
                myCommand.CommandText = selecting;
                using (MySqlDataReader dataReader = myCommand.ExecuteReader())
                {
                    result = dataReader.HasRows;
                    
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            return result;
        }

        public Boolean GetPassportCheck(params String[] args)
        {
            Boolean result = false;
            String selecting = @"SELECT * FROM user_info
                                WHERE Passport_serie='" + args[0] + "' and " +
                                "Passport_number='" + args[1] + "';";
            DataTable dataTable = null;
            dataTable = new DataTable();

            try
            {
                myCommand.CommandText = selecting;
                using (MySqlDataReader dataReader = myCommand.ExecuteReader())
                {
                    result = dataReader.HasRows;

                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            return result;
        }

        public DataTable GetDepoInfo(params Int32[] i)
        {
            String selecting = "";
            switch (i.Length)
            {
                case 0:
                    selecting = @"SELECT * FROM dep_type ORDER BY dep_type.Type_id;";
                    break;
                case 1:
                    selecting = @"SELECT Deposit_id, typ.Type_name, Deposit_name, cur.Curr_name, Deposit_minimum,
                                            Deposit_days,Deposit_percent 
                                        FROM Deposits as dep
                                  inner join dep_type as typ
	                                on dep.Deposit_type = typ.Type_id
                                  inner join currency as cur
	                                on dep.Deposit_curr = cur.Curr_id
	                                    WHERE Deposit_type=" + i[0];
                    break;

            }

            DataTable dataTable = null;

            dataTable = new DataTable();
            try
            {
                myCommand.CommandText = selecting;
                using (MySqlDataReader dataReader = myCommand.ExecuteReader())
                {
                    if (dataReader.HasRows)
                    {
                        dataTable.Load(dataReader);
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            return dataTable;
        }

        public DataTable GetLastAgreement()
        {
            String selecting = @"Select Max(Agree_id) from Agreement;";
            DataTable dataTable = null;

            dataTable = new DataTable();
            try
            {
                myCommand.CommandText = selecting;
                using (MySqlDataReader dataReader = myCommand.ExecuteReader())
                {
                    if (dataReader.HasRows)
                    {
                        dataTable.Load(dataReader);
                    }
                    else dataTable = null;
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            return dataTable;
        }

        public DataTable GetAgreementInfo(params Int32[] args)
        {
            String selecting = "";
            switch (args.Length)
            {
                case 0:
                    selecting = @"SELECT * FROM Agreement ORDER BY Agree_id;";
                    break;
                case 1:
                    selecting = @"SELECT Agree_id,Agree_start,Agree_depo_end,Agree_end,Agree_summ,usr.First_name,usr.Second_name,usr.Fathers_name
                                        FROM Agreement as agr
                                  inner join user_info as usr
	                                on agr.Agree_client = usr.user_id
	                                    WHERE Agree_id=" + args[0];
                    break;

            }

            DataTable dataTable = null;

            dataTable = new DataTable();
            try
            {
                myCommand.CommandText = selecting;
                using (MySqlDataReader dataReader = myCommand.ExecuteReader())
                {
                    if (dataReader.HasRows)
                    {
                        dataTable.Load(dataReader);
                    }
                    else dataTable = null;
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            return dataTable;
        }

        public void Dispose()
        {

        }
    }
}
