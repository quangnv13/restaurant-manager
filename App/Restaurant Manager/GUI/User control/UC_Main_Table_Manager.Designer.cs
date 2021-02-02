namespace Restaurant_Manager.GUI.User_control
{
    partial class UC_Main_Table_Manager
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTableManager = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvTableList = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.txtTableID = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.dgvSelectTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.pnlTableManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTableManager
            // 
            this.pnlTableManager.Controls.Add(this.button7);
            this.pnlTableManager.Controls.Add(this.label1);
            this.pnlTableManager.Controls.Add(this.dgvSelectTable);
            this.pnlTableManager.Controls.Add(this.button6);
            this.pnlTableManager.Controls.Add(this.txtTableID);
            this.pnlTableManager.Controls.Add(this.button5);
            this.pnlTableManager.Controls.Add(this.dgvTableList);
            this.pnlTableManager.Controls.Add(this.button4);
            this.pnlTableManager.Controls.Add(this.button3);
            this.pnlTableManager.Controls.Add(this.button2);
            this.pnlTableManager.Location = new System.Drawing.Point(30, 43);
            this.pnlTableManager.Name = "pnlTableManager";
            this.pnlTableManager.Size = new System.Drawing.Size(1088, 550);
            this.pnlTableManager.TabIndex = 28;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.Location = new System.Drawing.Point(147, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 29);
            this.button2.TabIndex = 0;
            this.button2.Text = "Thêm Bàn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.Location = new System.Drawing.Point(241, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 48);
            this.button3.TabIndex = 1;
            this.button3.Text = "Sửa thông tin bàn";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button4.Location = new System.Drawing.Point(325, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 48);
            this.button4.TabIndex = 2;
            this.button4.Text = "Xóa bàn";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dgvTableList
            // 
            this.dgvTableList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableList.Location = new System.Drawing.Point(27, 73);
            this.dgvTableList.Name = "dgvTableList";
            this.dgvTableList.Size = new System.Drawing.Size(464, 458);
            this.dgvTableList.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button5.Location = new System.Drawing.Point(147, 38);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 29);
            this.button5.TabIndex = 4;
            this.button5.Text = "Tìm bàn";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // txtTableID
            // 
            this.txtTableID.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTableID.Location = new System.Drawing.Point(27, 38);
            this.txtTableID.Name = "txtTableID";
            this.txtTableID.Size = new System.Drawing.Size(100, 27);
            this.txtTableID.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button6.Location = new System.Drawing.Point(409, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 48);
            this.button6.TabIndex = 7;
            this.button6.Text = "Sửa trạng thái";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // dgvSelectTable
            // 
            this.dgvSelectTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectTable.Location = new System.Drawing.Point(618, 73);
            this.dgvSelectTable.Name = "dgvSelectTable";
            this.dgvSelectTable.Size = new System.Drawing.Size(370, 458);
            this.dgvSelectTable.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(709, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Danh sách chọn bàn";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button7.Location = new System.Drawing.Point(994, 117);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 53);
            this.button7.TabIndex = 10;
            this.button7.Text = "Hủy Chọn";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // UC_Main_Table_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.pnlTableManager);
            this.Name = "UC_Main_Table_Manager";
            this.Size = new System.Drawing.Size(1143, 615);
            this.pnlTableManager.ResumeLayout(false);
            this.pnlTableManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTableManager;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSelectTable;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtTableID;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dgvTableList;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}
