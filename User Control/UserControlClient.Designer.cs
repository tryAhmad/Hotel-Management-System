
namespace Napier_Lodges.User_Control
{
    partial class UserControlClient
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
            this.tabControlClient = new System.Windows.Forms.TabControl();
            this.tabPageAddClient = new System.Windows.Forms.TabPage();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSearchClient = new System.Windows.Forms.TabPage();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPageUpdateDeleteClient = new System.Windows.Forms.TabPage();
            this.buttonDeleteClient = new System.Windows.Forms.Button();
            this.buttonUpdateClient = new System.Windows.Forms.Button();
            this.textBoxEmail1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxLastName1 = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNo1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxFirstName1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControlClient.SuspendLayout();
            this.tabPageAddClient.SuspendLayout();
            this.tabPageSearchClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.tabPageUpdateDeleteClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlClient
            // 
            this.tabControlClient.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlClient.Controls.Add(this.tabPageAddClient);
            this.tabControlClient.Controls.Add(this.tabPageSearchClient);
            this.tabControlClient.Controls.Add(this.tabPageUpdateDeleteClient);
            this.tabControlClient.Location = new System.Drawing.Point(36, 14);
            this.tabControlClient.Name = "tabControlClient";
            this.tabControlClient.SelectedIndex = 0;
            this.tabControlClient.Size = new System.Drawing.Size(1031, 417);
            this.tabControlClient.TabIndex = 0;
            // 
            // tabPageAddClient
            // 
            this.tabPageAddClient.Controls.Add(this.buttonAdd);
            this.tabPageAddClient.Controls.Add(this.textBoxEmail);
            this.tabPageAddClient.Controls.Add(this.label5);
            this.tabPageAddClient.Controls.Add(this.textBoxLastname);
            this.tabPageAddClient.Controls.Add(this.textBoxPhoneNo);
            this.tabPageAddClient.Controls.Add(this.label3);
            this.tabPageAddClient.Controls.Add(this.label4);
            this.tabPageAddClient.Controls.Add(this.textBoxFirstname);
            this.tabPageAddClient.Controls.Add(this.label2);
            this.tabPageAddClient.Controls.Add(this.label1);
            this.tabPageAddClient.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddClient.Name = "tabPageAddClient";
            this.tabPageAddClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddClient.Size = new System.Drawing.Size(1023, 387);
            this.tabPageAddClient.TabIndex = 0;
            this.tabPageAddClient.Text = "Add Client";
            this.tabPageAddClient.UseVisualStyleBackColor = true;
            this.tabPageAddClient.Leave += new System.EventHandler(this.tabPageAddClient_Leave);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.BackColor = System.Drawing.Color.Gray;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(476, 293);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 38);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEmail.Location = new System.Drawing.Point(630, 194);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(236, 23);
            this.textBoxEmail.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(627, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email :";
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLastname.Location = new System.Drawing.Point(630, 87);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(236, 23);
            this.textBoxLastname.TabIndex = 2;
            // 
            // textBoxPhoneNo
            // 
            this.textBoxPhoneNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPhoneNo.Location = new System.Drawing.Point(186, 194);
            this.textBoxPhoneNo.Name = "textBoxPhoneNo";
            this.textBoxPhoneNo.Size = new System.Drawing.Size(236, 23);
            this.textBoxPhoneNo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(627, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(183, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phone No.:";
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFirstname.Location = new System.Drawing.Point(186, 87);
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(236, 23);
            this.textBoxFirstname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "First name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Client";
            // 
            // tabPageSearchClient
            // 
            this.tabPageSearchClient.Controls.Add(this.dataGridViewClient);
            this.tabPageSearchClient.Controls.Add(this.textBoxSearchName);
            this.tabPageSearchClient.Controls.Add(this.label7);
            this.tabPageSearchClient.Controls.Add(this.label6);
            this.tabPageSearchClient.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchClient.Name = "tabPageSearchClient";
            this.tabPageSearchClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchClient.Size = new System.Drawing.Size(1023, 387);
            this.tabPageSearchClient.TabIndex = 1;
            this.tabPageSearchClient.Text = "Search Client";
            this.tabPageSearchClient.UseVisualStyleBackColor = true;
            this.tabPageSearchClient.Enter += new System.EventHandler(this.tabPageSearchClient_Enter);
            this.tabPageSearchClient.Leave += new System.EventHandler(this.tabPageSearchClient_Leave);
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.AllowUserToAddRows = false;
            this.dataGridViewClient.AllowUserToDeleteRows = false;
            this.dataGridViewClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Position,
            this.Column4});
            this.dataGridViewClient.Location = new System.Drawing.Point(21, 116);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.ReadOnly = true;
            this.dataGridViewClient.Size = new System.Drawing.Size(1024, 259);
            this.dataGridViewClient.TabIndex = 0;
            this.dataGridViewClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClient_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Client_Id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Client_FirstName";
            this.Column2.HeaderText = "First Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Client_LastName";
            this.Column3.HeaderText = "Last Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Client_PhoneNo";
            this.Position.HeaderText = "Phone No.";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Client_Email";
            this.Column4.HeaderText = "Email";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // textBoxSearchName
            // 
            this.textBoxSearchName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearchName.Location = new System.Drawing.Point(218, 67);
            this.textBoxSearchName.Name = "textBoxSearchName";
            this.textBoxSearchName.Size = new System.Drawing.Size(236, 23);
            this.textBoxSearchName.TabIndex = 1;
            this.textBoxSearchName.TextChanged += new System.EventHandler(this.textBoxSearchFirstName_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(215, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label6.Location = new System.Drawing.Point(6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Search Client";
            // 
            // tabPageUpdateDeleteClient
            // 
            this.tabPageUpdateDeleteClient.Controls.Add(this.buttonDeleteClient);
            this.tabPageUpdateDeleteClient.Controls.Add(this.buttonUpdateClient);
            this.tabPageUpdateDeleteClient.Controls.Add(this.textBoxEmail1);
            this.tabPageUpdateDeleteClient.Controls.Add(this.label9);
            this.tabPageUpdateDeleteClient.Controls.Add(this.textBoxLastName1);
            this.tabPageUpdateDeleteClient.Controls.Add(this.textBoxPhoneNo1);
            this.tabPageUpdateDeleteClient.Controls.Add(this.label10);
            this.tabPageUpdateDeleteClient.Controls.Add(this.label11);
            this.tabPageUpdateDeleteClient.Controls.Add(this.textBoxFirstName1);
            this.tabPageUpdateDeleteClient.Controls.Add(this.label12);
            this.tabPageUpdateDeleteClient.Controls.Add(this.label13);
            this.tabPageUpdateDeleteClient.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateDeleteClient.Name = "tabPageUpdateDeleteClient";
            this.tabPageUpdateDeleteClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateDeleteClient.Size = new System.Drawing.Size(1023, 387);
            this.tabPageUpdateDeleteClient.TabIndex = 2;
            this.tabPageUpdateDeleteClient.Text = "Update / Delete Client";
            this.tabPageUpdateDeleteClient.UseVisualStyleBackColor = true;
            this.tabPageUpdateDeleteClient.Leave += new System.EventHandler(this.tabPageUpdateDeleteClient_Leave);
            // 
            // buttonDeleteClient
            // 
            this.buttonDeleteClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteClient.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDeleteClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteClient.FlatAppearance.BorderSize = 0;
            this.buttonDeleteClient.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteClient.Location = new System.Drawing.Point(576, 293);
            this.buttonDeleteClient.Name = "buttonDeleteClient";
            this.buttonDeleteClient.Size = new System.Drawing.Size(100, 38);
            this.buttonDeleteClient.TabIndex = 6;
            this.buttonDeleteClient.Text = "Delete";
            this.buttonDeleteClient.UseVisualStyleBackColor = false;
            this.buttonDeleteClient.Click += new System.EventHandler(this.buttonDeleteClient_Click);
            // 
            // buttonUpdateClient
            // 
            this.buttonUpdateClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdateClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.buttonUpdateClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdateClient.FlatAppearance.BorderSize = 0;
            this.buttonUpdateClient.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateClient.Location = new System.Drawing.Point(381, 293);
            this.buttonUpdateClient.Name = "buttonUpdateClient";
            this.buttonUpdateClient.Size = new System.Drawing.Size(100, 38);
            this.buttonUpdateClient.TabIndex = 5;
            this.buttonUpdateClient.Text = "Update";
            this.buttonUpdateClient.UseVisualStyleBackColor = false;
            this.buttonUpdateClient.Click += new System.EventHandler(this.buttonUpdateClient_Click);
            // 
            // textBoxEmail1
            // 
            this.textBoxEmail1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEmail1.Location = new System.Drawing.Point(627, 194);
            this.textBoxEmail1.Name = "textBoxEmail1";
            this.textBoxEmail1.Size = new System.Drawing.Size(236, 23);
            this.textBoxEmail1.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(624, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Email :";
            // 
            // textBoxLastName1
            // 
            this.textBoxLastName1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLastName1.Location = new System.Drawing.Point(627, 87);
            this.textBoxLastName1.Name = "textBoxLastName1";
            this.textBoxLastName1.Size = new System.Drawing.Size(236, 23);
            this.textBoxLastName1.TabIndex = 2;
            // 
            // textBoxPhoneNo1
            // 
            this.textBoxPhoneNo1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPhoneNo1.Location = new System.Drawing.Point(183, 194);
            this.textBoxPhoneNo1.Name = "textBoxPhoneNo1";
            this.textBoxPhoneNo1.Size = new System.Drawing.Size(236, 23);
            this.textBoxPhoneNo1.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(624, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Last Name:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(180, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Phone No.:";
            // 
            // textBoxFirstName1
            // 
            this.textBoxFirstName1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFirstName1.Location = new System.Drawing.Point(183, 87);
            this.textBoxFirstName1.Name = "textBoxFirstName1";
            this.textBoxFirstName1.Size = new System.Drawing.Size(236, 23);
            this.textBoxFirstName1.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(180, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "First name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label13.Location = new System.Drawing.Point(3, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 18);
            this.label13.TabIndex = 0;
            this.label13.Text = "Update / Delete Client";
            // 
            // UserControlClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlClient);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlClient";
            this.Size = new System.Drawing.Size(1102, 462);
            this.Enter += new System.EventHandler(this.UserControlClient_Enter);
            this.tabControlClient.ResumeLayout(false);
            this.tabPageAddClient.ResumeLayout(false);
            this.tabPageAddClient.PerformLayout();
            this.tabPageSearchClient.ResumeLayout(false);
            this.tabPageSearchClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.tabPageUpdateDeleteClient.ResumeLayout(false);
            this.tabPageUpdateDeleteClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlClient;
        private System.Windows.Forms.TabPage tabPageAddClient;
        private System.Windows.Forms.TabPage tabPageSearchClient;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.TextBox textBoxPhoneNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFirstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageUpdateDeleteClient;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox textBoxSearchName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonDeleteClient;
        private System.Windows.Forms.Button buttonUpdateClient;
        private System.Windows.Forms.TextBox textBoxEmail1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxLastName1;
        private System.Windows.Forms.TextBox textBoxPhoneNo1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxFirstName1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}
