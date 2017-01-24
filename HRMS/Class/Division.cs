using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;


namespace HRMS.Class
{
    class Division
    {
        private string _AudtDate;
        private string _AudtTime;
        private string _AudtUser;
        private string _divId;
        private string _divName;
        private string _swactv;


        public string AudtDate
        {

            get { return _AudtDate; }
            set { _AudtDate = value; }

        }

        public string AudtTime
        {

            get { return _AudtTime; }
            set { _AudtTime = value; }

        }

        public string AudtUser
        {

            get { return _AudtUser; }
            set { _AudtUser = value; }

        }


        public string divID
        {

            get { return _divId; }
            set { _divId = value; }

        }


        public string divName
        {

            get { return _divName; }
            set { _divName = value; }

        }


        public string swactv
        {

            get { return swactv; }
            set { swactv = value; }

        }


        public void Add()
        {
            DBController oDBController = new DBController();
            string sqlConn = oDBController.GetConnectionString();
            OleDbConnection myConnection = new OleDbConnection(sqlConn);
            OleDbCommand myCmd;
            string sSql = "";

            try
            {
                myConnection.Open();

                sSql = "INSERT INTO DIVISION VALUES(?,?,?,?,?,?)";
                myCmd = new OleDbCommand(sSql, myConnection);
                myCmd.CommandType = CommandType.Text;
                myCmd.Parameters.AddWithValue("AUDTDATE", _AudtDate);
                myCmd.Parameters.AddWithValue("AUDTTIME", _AudtTime);
                myCmd.Parameters.AddWithValue("AUDTUSER", _AudtUser);
                myCmd.Parameters.AddWithValue("DIVID", _divId);
                myCmd.Parameters.AddWithValue("DIVNAME", _divName);
                myCmd.Parameters.AddWithValue("SWACTV", _swactv);
                

                myCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public void Edit()
        {
            DBController oDBController = new DBController();
            string sqlConn = oDBController.GetConnectionString();
            OleDbConnection myConnection = new OleDbConnection(sqlConn);
            OleDbCommand myCmd;
            string sSql = "";

            try
            {
                myConnection.Open();
                sSql = "UPDATE DIVISION SET AUDTDATE=?, AUDTTIME=?, AUDTUSER=?, DIVID=?, DIVNAME=?, SWACTV=?";

                myCmd = new OleDbCommand(sSql, myConnection);
                myCmd.CommandType = CommandType.Text;
                myCmd.Parameters.AddWithValue("AUDTDATE", _AudtDate);
                myCmd.Parameters.AddWithValue("AUDTTIME", _AudtTime);
                myCmd.Parameters.AddWithValue("AUDTUSER", _AudtUser);
                myCmd.Parameters.AddWithValue("DIVID", _divId);
                myCmd.Parameters.AddWithValue("DIVNAME", _divName);
                myCmd.Parameters.AddWithValue("SWACTV", _swactv);
                


                myCmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public void Refresh()
        {
            DBController oDBController = new DBController();
            string sqlConn = oDBController.GetConnectionString();
            OleDbConnection myConnection = new OleDbConnection(sqlConn);

            string sSql = "SELECT * FROM DIVISION";

            try
            {
                myConnection.Open();
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                myCmd.CommandType = CommandType.Text;
                IDataReader reader = myCmd.ExecuteReader();
                while (reader.Read())
                {

                    _AudtDate = Convert.ToString((decimal)reader["AUDTDATE"]);
                    _AudtTime = Convert.ToString((decimal)reader["AUDTTIME"]);
                    _AudtUser = (string)reader["AUDTUSER"];
                    _divId = (string)reader["DIVID"];
                    _divName = (string)reader["DIVNAME"];
                    _swactv = (string)reader["SWACTV"];
                    


                }
                reader.Close();
                //                InnerList.TrimToSize();

            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }


    }
}
