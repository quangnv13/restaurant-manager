using Restaurant_Manager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Manager.DAL
{
    public class AccountDAL
    {
        private static AccountDAL _instance;

        public static AccountDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AccountDAL();  
            return AccountDAL._instance; }
            private set { AccountDAL._instance = value; }
        }
        private AccountDAL() { }
        #region methods
        public int Login(AccountDTO transfer)
        {
            return Data.Instance.ExecuteQuery("Confirm_Login @employeeID , @password", new object[] { transfer.EmployeeID, transfer.Password }).Rows.Count;
        }
        public int ChangePass(AccountDTO transfer)
        {
            return Data.Instance.ExecuteNonQuery("Change_Pass @username , @password", new object[] { transfer.EmployeeID, transfer.Password });
        }
        public DataTable GetAllInfoEmployee(AccountDTO transfer)
        {
            return Data.Instance.ExecuteQuery("GetAllInfoEmployee @employeeID", new object[] { transfer.EmployeeID });
        }
        #endregion
    }
}
