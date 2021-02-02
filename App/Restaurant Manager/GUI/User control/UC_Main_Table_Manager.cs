using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Manager.GUI.User_control
{
    public partial class UC_Main_Table_Manager : UserControl
    {
        private static UC_Main_Table_Manager _instance;

        public static UC_Main_Table_Manager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Main_Table_Manager();
                return UC_Main_Table_Manager._instance;
            }
            private set { UC_Main_Table_Manager._instance = value; }
        }

        public UC_Main_Table_Manager()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
