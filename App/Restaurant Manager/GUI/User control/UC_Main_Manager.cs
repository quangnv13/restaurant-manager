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
    public partial class UC_Main_Manager : UserControl
    {
        private static UC_Main_Manager _instance;

        public static UC_Main_Manager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Main_Manager();
                return UC_Main_Manager._instance;
            }
            private set { UC_Main_Manager._instance = value; }
        }
        public UC_Main_Manager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void quảnLíBànĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(UC_Main_Table_Manager.Instance);
        }
    }
}
