using Restaurant_Manager.BLL;
using Restaurant_Manager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Manager.GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        int countdown = 31;
        int error = 3;
        #region
        void Reset()
        {
            txtEmployeeID.ResetText();
            txtPassword.ResetText();
        }

        void DisableEdit()
        {
            txtEmployeeID.Enabled = false;
            txtPassword.Enabled = false;
            button1.Enabled = false;
        }

        void EnableEdit()
        {
            txtEmployeeID.Enabled = true;
            txtPassword.Enabled = true;
            button1.Enabled = true;
        }
        #endregion
        #region events
        private void button1_Click(object sender, EventArgs e)
        {
            frmMain fMain = new frmMain();
            AccountDTO transfer = new AccountDTO(txtEmployeeID.Text, txtPassword.Text);
            if (AccountBLL.Instance.Login(transfer) == true)
            {
                MessageBox.Show("Xin chào " + AccountBLL.Instance.GetNameEmployee(transfer));
                fMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
                error--;
                if (error == 0)
                {
                    DisableEdit();
                    tmCountDown.Enabled = true;
                    tmCountDown.Start();
                }
            }
        }
        private void tmCountDown_Tick(object sender, EventArgs e)
        {
            countdown--;
            lblCountDown.Text = "Bạn đã nhập sai  3 lần vui lòng chờ " + countdown + " để nhập lại";
            if (countdown == 0)
            {
                EnableEdit();
                countdown = 31;
                error = 3;
                tmCountDown.Stop();
                tmCountDown.Enabled = false;
                lblCountDown.ResetText();
            }
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
