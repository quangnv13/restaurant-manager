using Restaurant_Manager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Manager.DAL
{
    public class TableDAL
    {
        private static TableDAL _instance;

        public static TableDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TableDAL();
                return TableDAL._instance;
            }
            private set { TableDAL._instance = value; }
        }
        private TableDAL() {}

        #region methods
        public List<TableDTO> LoadTableList()
        {
            List<TableDTO> tableList = new List<TableDTO>();
            DataTable data = Data.Instance.ExecuteQuery("GetAllInfoTable");
            foreach(DataRow item in data.Rows)
            {
                TableDTO table = new TableDTO(item);
                tableList.Add(table);
            }
            return tableList;
        }

        public List<TableDTO> LoadTableListTier(TableDTO transfer)
        {
            List<TableDTO> tableList = new List<TableDTO>();
            DataTable data = Data.Instance.ExecuteQuery("GetAllInfoTableTier @tier",new object[] { transfer.Tier});
            foreach (DataRow item in data.Rows)
            {
                TableDTO table = new TableDTO(item);
                tableList.Add(table);
            }
            return tableList;
        }

        public DataTable LoadListTier()
        {
            return Data.Instance.ExecuteQuery("GetAllTier");
        }
        #endregion
    }
}
