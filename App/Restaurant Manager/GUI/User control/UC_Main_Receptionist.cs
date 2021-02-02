using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_Manager.BLL;
using Restaurant_Manager.DTO;

namespace Restaurant_Manager.GUI.User_control
{
    public partial class UC_Main_Receptionist : UserControl
    {
        private static UC_Main_Receptionist _instance;
        public static UC_Main_Receptionist Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Main_Receptionist();
                return UC_Main_Receptionist._instance;
            }
            private set { UC_Main_Receptionist._instance = value; }
        }

        public UC_Main_Receptionist()
        {
            InitializeComponent();
            LoadTierComboBox();
            LoadPeoplesComboBox();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbxTier_SelectedIndexChanged(object sender, EventArgs e)
        {
            flpTableList.Controls.Clear();
            if (cbxTier.SelectedIndex == -1)
            {
                LoadDefaultTableList();
            }
            else
            {
                TableBLL.Instance.LoadTableList(flpTableList, cbxTier);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            cbxTier.SelectedIndex = -1;
        }
        #region methods
        void LoadTierComboBox()
        {
            TableBLL.Instance.LoadTierComboBox(cbxTier);
            cbxTier.SelectedIndex = -1;
        }
        void LoadPeoplesComboBox()
        {
            TableBLL.Instance.LoadPeoplesComboBox(cbxTier,cbxPeoples);
            cbxPeoples.SelectedIndex = -1;
        }
        void LoadDefaultTableList()
        {
            TableBLL.Instance.LoadTableList(flpTableList, cbxTier);
            cbxPeoples.SelectedIndex = -1;
        }
        #endregion

        private void button3_Click(object sender, EventArgs e)
        {

        }
        
        private void cbxPeoples_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPeoples.SelectedIndex == -1)
            {
                flpTableList.Controls.Clear();
                TableBLL.Instance.LoadTableList(flpTableList, cbxTier);
            }
            else
            {
                TableBLL.Instance.LoadTableList(flpTableList, cbxTier, cbxPeoples);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
