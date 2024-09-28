
namespace Napier_Lodges.User_Control
{
    partial class UserControlSetting
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
            this.components = new System.ComponentModel.Container();
            this.tabControlUser = new System.Windows.Forms.TabControl();
            this.tabPageAddEmp = new System.Windows.Forms.TabPage();
            this.tabPageSearchEmp = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSearchUser = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.tabPageUpdateDeleteEmployee = new System.Windows.Forms.TabPage();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxUserContact1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxUserPassword1 = new System.Windows.Forms.TextBox();
            this.textBoxUserposition1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxUsername1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlUser.SuspendLayout();
            this.tabPageAddEmp.SuspendLayout();
            this.tabPageSearchEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.tabPageUpdateDeleteEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlUser
            // 
            this.tabControlUser.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlUser.Controls.Add(this.tabPageAddEmp);
            this.tabControlUser.Controls.Add(this.tabPageSearchEmp);
            this.tabControlUser.Controls.Add(this.tabPageUpdateDeleteEmployee);
            this.tabControlUser.Location = new System.Drawing.Point(14, 14);
            this.tabControlUser.Name = "tabControlUser";
            this.tabControlUser.SelectedIndex = 0;
            this.tabControlUser.Size = new System.Drawing.Size(1070, 431);
            this.tabControlUser.TabIndex = 0;
            // 
            // tabPageAddEmp
            // 
            this.tabPageAddEmp.Controls.Add(this.buttonAdd);
            this.tabPageAddEmp.Controls.Add(this.textBoxContact);
            this.tabPageAddEmp.Controls.Add(this.label5);
            this.tabPageAddEmp.Controls.Add(this.textBoxPassword);
            this.tabPageAddEmp.Controls.Add(this.textBoxPosition);
            this.tabPageAddEmp.Controls.Add(this.label3);
            this.tabPageAddEmp.Controls.Add(this.label4);
            this.tabPageAddEmp.Controls.Add(this.textBoxUsername);
            this.tabPageAddEmp.Controls.Add(this.label2);
            this.tabPageAddEmp.Controls.Add(this.label1);
            this.tabPageAddEmp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAddEmp.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddEmp.Name = "tabPageAddEmp";
            this.tabPageAddEmp.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddEmp.Size = new System.Drawing.Size(1062, 401);
            this.tabPageAddEmp.TabIndex = 0;
            this.tabPageAddEmp.Text = "Add Employee";
            this.tabPageAddEmp.UseVisualStyleBackColor = true;
            this.tabPageAddEmp.Leave += new System.EventHandler(this.tabPageAddEmp_Leave);
            // 
            // tabPageSearchEmp
            // 
            this.tabPageSearchEmp.Controls.Add(this.dataGridViewUser);
            this.tabPageSearchEmp.Controls.Add(this.textBoxSearchUser);
            this.tabPageSearchEmp.Controls.Add(this.label7);
            this.tabPageSearchEmp.Controls.Add(this.label6);
            this.tabPageSearchEmp.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchEmp.Name = "tabPageSearchEmp";
            this.tabPageSearchEmp.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchEmp.Size = new System.Drawing.Size(1062, 401);
            this.tabPageSearchEmp.TabIndex = 1;
            this.tabPageSearchEmp.Text = "Search Employee";
            this.tabPageSearchEmp.UseVisualStyleBackColor = true;
            this.tabPageSearchEmp.Enter += new System.EventHandler(this.tabPageSearchEmp_Enter);
            this.tabPageSearchEmp.Leave += new System.EventHandler(this.tabPageSearchEmp_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Employee";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUsername.Location = new System.Drawing.Point(187, 91);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(236, 23);
            this.textBoxUsername.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(628, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPassword.Location = new System.Drawing.Point(631, 91);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(236, 23);
            this.textBoxPassword.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.BackColor = System.Drawing.Color.Gray;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(477, 297);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 38);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(184, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Position:";
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPosition.Location = new System.Drawing.Point(187, 198);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(236, 23);
            this.textBoxPosition.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(628, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Contact Info (Email)";
            // 
            // textBoxContact
            // 
            this.textBoxContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxContact.Location = new System.Drawing.Point(631, 198);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(236, 23);
            this.textBoxContact.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label6.Location = new System.Drawing.Point(4, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Search Employee";
            // 
            // textBoxSearchUser
            // 
            this.textBoxSearchUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearchUser.Location = new System.Drawing.Point(216, 71);
            this.textBoxSearchUser.Name = "textBoxSearchUser";
            this.textBoxSearchUser.Size = new System.Drawing.Size(236, 23);
            this.textBoxSearchUser.TabIndex = 1;
            this.textBoxSearchUser.TextChanged += new System.EventHandler(this.textBoxSearchUser_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(213, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Username:";
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.AllowUserToAddRows = false;
            this.dataGridViewUser.AllowUserToDeleteRows = false;
            this.dataGridViewUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Position,
            this.Column4});
            this.dataGridViewUser.Location = new System.Drawing.Point(19, 120);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.ReadOnly = true;
            this.dataGridViewUser.Size = new System.Drawing.Size(1024, 259);
            this.dataGridViewUser.TabIndex = 0;
            this.dataGridViewUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUser_CellClick);
            this.dataGridViewUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUser_CellContentClick);
            // 
            // tabPageUpdateDeleteEmployee
            // 
            this.tabPageUpdateDeleteEmployee.Controls.Add(this.buttonDelete);
            this.tabPageUpdateDeleteEmployee.Controls.Add(this.buttonUpdate);
            this.tabPageUpdateDeleteEmployee.Controls.Add(this.textBoxUserContact1);
            this.tabPageUpdateDeleteEmployee.Controls.Add(this.label8);
            this.tabPageUpdateDeleteEmployee.Controls.Add(this.textBoxUserPassword1);
            this.tabPageUpdateDeleteEmployee.Controls.Add(this.textBoxUserposition1);
            this.tabPageUpdateDeleteEmployee.Controls.Add(this.label9);
            this.tabPageUpdateDeleteEmployee.Controls.Add(this.label10);
            this.tabPageUpdateDeleteEmployee.Controls.Add(this.textBoxUsername1);
            this.tabPageUpdateDeleteEmployee.Controls.Add(this.label11);
            this.tabPageUpdateDeleteEmployee.Controls.Add(this.label12);
            this.tabPageUpdateDeleteEmployee.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateDeleteEmployee.Name = "tabPageUpdateDeleteEmployee";
            this.tabPageUpdateDeleteEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateDeleteEmployee.Size = new System.Drawing.Size(1062, 401);
            this.tabPageUpdateDeleteEmployee.TabIndex = 2;
            this.tabPageUpdateDeleteEmployee.Text = "Update / Delete Employee";
            this.tabPageUpdateDeleteEmployee.UseVisualStyleBackColor = true;
            this.tabPageUpdateDeleteEmployee.Leave += new System.EventHandler(this.tabPageUpdateDeleteEmployee_Leave);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(382, 294);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(122, 38);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxUserContact1
            // 
            this.textBoxUserContact1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUserContact1.Location = new System.Drawing.Point(627, 194);
            this.textBoxUserContact1.Name = "textBoxUserContact1";
            this.textBoxUserContact1.Size = new System.Drawing.Size(236, 23);
            this.textBoxUserContact1.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(624, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Contact Info (Email)";
            // 
            // textBoxUserPassword1
            // 
            this.textBoxUserPassword1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUserPassword1.Location = new System.Drawing.Point(627, 87);
            this.textBoxUserPassword1.Name = "textBoxUserPassword1";
            this.textBoxUserPassword1.Size = new System.Drawing.Size(236, 23);
            this.textBoxUserPassword1.TabIndex = 2;
            // 
            // textBoxUserposition1
            // 
            this.textBoxUserposition1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUserposition1.Location = new System.Drawing.Point(183, 194);
            this.textBoxUserposition1.Name = "textBoxUserposition1";
            this.textBoxUserposition1.Size = new System.Drawing.Size(236, 23);
            this.textBoxUserposition1.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(624, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Password:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(180, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Position:";
            // 
            // textBoxUsername1
            // 
            this.textBoxUsername1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUsername1.Location = new System.Drawing.Point(183, 87);
            this.textBoxUsername1.Name = "textBoxUsername1";
            this.textBoxUsername1.Size = new System.Drawing.Size(236, 23);
            this.textBoxUsername1.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(180, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Username:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label12.Location = new System.Drawing.Point(3, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(205, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "Update / Delete Employee";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDelete.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(542, 294);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(122, 38);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Emp_Id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Emp_Name";
            this.Column2.HeaderText = "Username";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Emp_Password";
            this.Column3.HeaderText = "Password";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Emp_Password";
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Emp_Contact";
            this.Column4.HeaderText = "Contact";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // UserControlSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlUser);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControlSetting";
            this.Size = new System.Drawing.Size(1102, 462);
            this.tabControlUser.ResumeLayout(false);
            this.tabPageAddEmp.ResumeLayout(false);
            this.tabPageAddEmp.PerformLayout();
            this.tabPageSearchEmp.ResumeLayout(false);
            this.tabPageSearchEmp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.tabPageUpdateDeleteEmployee.ResumeLayout(false);
            this.tabPageUpdateDeleteEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlUser;
        private System.Windows.Forms.TabPage tabPageAddEmp;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageSearchEmp;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.TextBox textBoxSearchUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPageUpdateDeleteEmployee;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxUserContact1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxUserPassword1;
        private System.Windows.Forms.TextBox textBoxUserposition1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxUsername1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
