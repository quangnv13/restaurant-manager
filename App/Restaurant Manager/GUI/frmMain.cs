using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_Manager.BLL;
using Restaurant_Manager.DAL;
using Restaurant_Manager.DTO;
using Restaurant_Manager.GUI.User_control;

namespace Restaurant_Manager.GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            LoadUCWithOffice();
        }
        public string Office = "Receptionist";
        public void Logout()
        {
            frmLogin fLog = new frmLogin();
            fLog.ShowDialog();
        }
        void LoadUCWithOffice()
        {
            //AccountDTO transfer = new AccountDTO(AccountBLL._employeeID);
            if(/*AccountBLL.Instance.GetOffice(transfer)*/Office == "Admin")
            {
                LoadMainManager();
            }
            else if(/*AccountBLL.Instance.GetOffice(transfer)*/Office == "Receptionist")
            {
                LoadMainReceptionist();
            }
        }
        void LoadMainReceptionist()
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(UC_Main_Receptionist.Instance);    
        }
        void LoadMainManager()
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(UC_Main_Manager.Instance);
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
