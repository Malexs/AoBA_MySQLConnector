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

        //public DataTable Execute()
        //{
        //    try
        //    {

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return null;
        //}

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
                                INNER JOIN user_birth_info USING (user_id)
                                INNER JOIN user_passport_info USING (user_id)
                                INNER JOIN user_addresses USING (user_id)
                                INNER JOIN user_contacts USING (user_id)
                                INNER JOIN user_work_info USING (user_id)
                                INNER JOIN user_social USING (user_id)
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
                                INNER JOIN user_birth_info USING (user_id)
                                INNER JOIN user_passport_info USING (user_id)
                                INNER JOIN user_addresses USING (user_id)
                                INNER JOIN user_contacts USING (user_id)
                                INNER JOIN user_work_info USING (user_id)
                                INNER JOIN user_social USING (user_id)
                                WHERE ";
            if (args[0].Length > 0) selecting += "user_info.First_name='" + args[0] + "'";
            if (args[1].Length > 0)
            {
                if (args[0].Length > 0) selecting += ",user_info.Second_name='" + args[1] + "'";
                else selecting += "user_info.Second_name='" + args[1] + "'";
            }
            if (args[2].Length > 0)
            {
                if (args[0].Length > 0 || args[1].Length > 0) selecting += ",user_info.Fathers_name=" + args[2] + "'";
                else selecting += "user_info.Fathers_name='" + args[2] + "'";
            }
            selecting += "ORDER BY user_info.Second_name;";
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

        public void Dispose()
        {

        }
    }
}
