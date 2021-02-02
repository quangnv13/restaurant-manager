using Restaurant_Manager.DAL;
using Restaurant_Manager.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Manager.BLL
{
    public class AccountBLL
    {
        private static AccountBLL _instance;
        //public static string _employeeID;
        //public static string _pass;

        public static AccountBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AccountBLL();
                return AccountBLL._instance;
            }
            private set { AccountBLL._instance = value; }
        }
        private AccountBLL() { }

        #region methods
        public bool Login(AccountDTO transfer)
        {
            if (AccountDAL.Instance.Login(transfer) > 0)
            {
                //_employeeID = transfer.EmployeeID;
                //_pass = transfer.Password;
                return true;
            }
            else
                return false;
        }

        public string GetNameEmployee(AccountDTO transfer)
        {
            return AccountDAL.Instance.GetAllInfoEmployee(transfer).Rows[0]["name"].ToString();
        }

        public string GetRole(AccountDTO transfer)
        {
            return AccountDAL.Instance.GetAllInfoEmployee(transfer).Rows[0]["role"].ToString();
        }

        public string GetOffice(AccountDTO transfer)
        {
            return AccountDAL.Instance.GetAllInfoEmployee(transfer).Rows[0]["office"].ToString();
        }
        #endregion
    }
}
