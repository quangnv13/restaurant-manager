using Restaurant_Manager.DAL;
using Restaurant_Manager.DTO;
using Restaurant_Manager.GUI.User_control;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Manager.BLL
{
    public class TableBLL
    {
        private static TableBLL _instance;

        public static TableBLL Instance
        {
            get
            {
                if(_instance==null)
                    _instance = new TableBLL();
                return TableBLL._instance;
            }
            private set { TableBLL._instance = value; }
        }
        private TableBLL()
        {

        }
        public static int _tableWidth = 100;
        public static int _tableHeight = 100;
        #region methods
        public void LoadTierComboBox(ComboBox cbx)
        {
            cbx.DataSource = TableDAL.Instance.LoadListTier();
            cbx.DisplayMember = "tier";
        }
        public void LoadPeoplesComboBox(ComboBox cbxTier,ComboBox cbxPeoples)
        {
            cbxPeoples.DataSource = TableTier(cbxTier);
            cbxPeoples.DisplayMember = "peoples";
        }

        public List<TableDTO> TableTier(ComboBox cbx)
        {
            if (cbx.SelectedIndex == -1)
                return TableDAL.Instance.LoadTableList();
            else
            {
                TableDTO transfer = new TableDTO(cbx.SelectedIndex + 1);
                return TableDAL.Instance.LoadTableListTier(transfer);
            }
        }
        public string TextButton(ComboBox cbx)
        {
            return (cbx.SelectedIndex + 1).ToString();
        }
        public void LoadTableList(FlowLayoutPanel flp, ComboBox cbxTier,ComboBox cbxPeoples=null)
        {
            foreach (TableDTO table in TableTier(cbxTier))
            {
                Button btn = new Button()
                {
                    Width = _tableWidth,
                    Height = _tableHeight,
                    Text = table.TableID + Environment.NewLine + Environment.NewLine + " Số người " + table.Peoples,
                };
                btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                switch (table.Status)
                {
                    case "Rảnh":
                        btn.ForeColor = Color.Black;
                        break;
                    case "Bận":
                        btn.ForeColor = Color.Red;
                        break;
                    case "Chờ dọn":
                        btn.ForeColor = Color.Yellow;
                        break;
                }
                if (cbxPeoples == null)
                {
                    btn.Click += Btn_Click;
                    flp.Controls.Add(btn);
                }
                else
                {
                    if(btn.Text==TextButton(cbxPeoples))
                    {
                        btn.Click += Btn_Click;
                        flp.Controls.Add(btn);
                    }
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show(btn.Text);
        }
        #endregion
    }
}
