using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;


namespace HRMS.Class
{
    class CompanyProfile
    {
        private string _AudtDate;
        private string _AudtTime;
        private string _AudtUser;
        private string _CoName;
        private string _CoAddr;
        private string _CoEmail;
        private string _CoWeb;

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


        public string CoName
        {

            get { return _CoName; }
            set { _CoName = value; }

        }


        public string CoAddr
        {

            get { return _CoAddr; }
            set { _CoAddr = value; }

        }


        public string CoEmail
        {

            get { return _CoEmail; }
            set { _CoEmail = value; }

        }

        public string CoWeb
        {

            get { return _CoWeb; }
            set { _CoWeb = value; }

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

                sSql = "INSERT INTO CSCOM VALUES(?,?,?,?,?,?,?)";
                myCmd = new OleDbCommand(sSql, myConnection);
                myCmd.CommandType = CommandType.Text;
                myCmd.Parameters.AddWithValue("AUDTDATE", _AudtDate);
                myCmd.Parameters.AddWithValue("AUDTTIME", _AudtTime);
                myCmd.Parameters.AddWithValue("AUDTUSER", _AudtUser);
                myCmd.Parameters.AddWithValue("CONAME", _CoName);
                myCmd.Parameters.AddWithValue("COADDR", _CoAddr);
                myCmd.Parameters.AddWithValue("COEMAIL", _CoEmail);
                myCmd.Parameters.AddWithValue("COWEB", _CoWeb);

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
                sSql = "UPDATE CSCOM SET AUDTDATE=?, AUDTTIME=?, AUDTUSER=?, CONAME=?, COADDR=?, COEMAIL=?, COWEB=?";
                
                myCmd = new OleDbCommand(sSql, myConnection);
                myCmd.CommandType = CommandType.Text;
                myCmd.Parameters.AddWithValue("AUDTDATE", _AudtDate);
                myCmd.Parameters.AddWithValue("AUDTTIME", _AudtTime);
                myCmd.Parameters.AddWithValue("AUDTUSER", _AudtUser);
                myCmd.Parameters.AddWithValue("CONAME", _CoName);
                myCmd.Parameters.AddWithValue("COADDR", _CoAddr);
                myCmd.Parameters.AddWithValue("COEMAIL", _CoEmail);
                myCmd.Parameters.AddWithValue("COWEB", _CoWeb);

                
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

            string sSql = "SELECT * FROM CSCOM";

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
                    _CoName = (string)reader["CONAME"];
                    _CoAddr = (string)reader["COADDR"];
                    _CoEmail = (string)reader["COEMAIL"];
                    _CoWeb = (string)reader["COWEB"];


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
