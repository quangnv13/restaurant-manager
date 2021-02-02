using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Manager.DTO
{
    public class TableDTO
    {
        private string _tableID;
        private int _tier;
        private int peoples;
        private string status;
        public string TableID { get => _tableID; set => _tableID = value; }
        public int Tier { get => _tier; set => _tier = value; }
        public int Peoples { get => peoples; set => peoples = value; }
        public string Status { get => status; set => status = value; }

        public TableDTO(DataRow row)
        {
            this.TableID = row["tableID"].ToString();
            this.Status = row["status"].ToString();
            this.Tier = (int)row["tier"];
            this.Peoples = (int)row["peoples"];
        }
        public TableDTO(int tier)
        {
            this.Tier=tier;
        }
    }
}
