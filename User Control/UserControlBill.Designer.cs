
namespace Napier_Lodges.User_Control
{
    partial class UserControlBill
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
            this.tabControlBill = new System.Windows.Forms.TabControl();
            this.tabPageSearchBill = new System.Windows.Forms.TabPage();
            this.dataGridViewBill = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bill_Days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControlBill.SuspendLayout();
            this.tabPageSearchBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlBill
            // 
            this.tabControlBill.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlBill.Controls.Add(this.tabPageSearchBill);
            this.tabControlBill.Location = new System.Drawing.Point(36, 14);
            this.tabControlBill.Name = "tabControlBill";
            this.tabControlBill.SelectedIndex = 0;
            this.tabControlBill.Size = new System.Drawing.Size(1031, 417);
            this.tabControlBill.TabIndex = 0;
            // 
            // tabPageSearchBill
            // 
            this.tabPageSearchBill.Controls.Add(this.dataGridViewBill);
            this.tabPageSearchBill.Controls.Add(this.label8);
            this.tabPageSearchBill.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchBill.Name = "tabPageSearchBill";
            this.tabPageSearchBill.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchBill.Size = new System.Drawing.Size(1023, 387);
            this.tabPageSearchBill.TabIndex = 0;
            this.tabPageSearchBill.Text = "Bills";
            this.tabPageSearchBill.UseVisualStyleBackColor = true;
            this.tabPageSearchBill.Enter += new System.EventHandler(this.tabPageSearchBill_Enter);
            // 
            // dataGridViewBill
            // 
            this.dataGridViewBill.AllowUserToAddRows = false;
            this.dataGridViewBill.AllowUserToDeleteRows = false;
            this.dataGridViewBill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Bill_Days,
            this.Column7});
            this.dataGridViewBill.Location = new System.Drawing.Point(18, 59);
            this.dataGridViewBill.Name = "dataGridViewBill";
            this.dataGridViewBill.ReadOnly = true;
            this.dataGridViewBill.Size = new System.Drawing.Size(986, 316);
            this.dataGridViewBill.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Bill_ID";
            this.Column1.HeaderText = "Bill ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Bill_ClientName";
            this.Column4.HeaderText = "Client Name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Bill_RoomType";
            this.Column2.HeaderText = "Room Type";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Bill_RoomNo";
            this.Column3.HeaderText = "Room No.";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Bill_in";
            this.Column5.HeaderText = "Check in";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Bill_out";
            this.Column6.HeaderText = "Check out";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Bill_Days
            // 
            this.Bill_Days.DataPropertyName = "Bill_Days";
            this.Bill_Days.HeaderText = "Days Stayed";
            this.Bill_Days.Name = "Bill_Days";
            this.Bill_Days.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Bill_TotalAmount";
            this.Column7.HeaderText = "Total Amount";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Generate Bill";
            // 
            // UserControlBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlBill);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControlBill";
            this.Size = new System.Drawing.Size(1102, 462);
            this.tabControlBill.ResumeLayout(false);
            this.tabPageSearchBill.ResumeLayout(false);
            this.tabPageSearchBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlBill;
        private System.Windows.Forms.TabPage tabPageSearchBill;
        private System.Windows.Forms.DataGridView dataGridViewBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bill_Days;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label8;
    }
}
