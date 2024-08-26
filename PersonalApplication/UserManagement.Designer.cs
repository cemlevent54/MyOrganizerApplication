namespace MyOrganizerApplication
{
    partial class UserManagement
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagement));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RegisterNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblUserName = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblUserType = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUsertypes = new System.Windows.Forms.TextBox();
            this.LblRegisterno = new System.Windows.Forms.Label();
            this.TxtRegisterNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnLists = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegisterNo});
            this.dataGridView1.Location = new System.Drawing.Point(50, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(535, 239);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // RegisterNo
            // 
            this.RegisterNo.HeaderText = "RegisterNo";
            this.RegisterNo.MinimumWidth = 6;
            this.RegisterNo.Name = "RegisterNo";
            this.RegisterNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblUserName.Location = new System.Drawing.Point(602, 144);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(84, 18);
            this.LblUserName.TabIndex = 9;
            this.LblUserName.Text = "UserName:";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPassword.Location = new System.Drawing.Point(602, 218);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(79, 18);
            this.LblPassword.TabIndex = 10;
            this.LblPassword.Text = "Password:";
            // 
            // LblUserType
            // 
            this.LblUserType.AutoSize = true;
            this.LblUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblUserType.Location = new System.Drawing.Point(602, 287);
            this.LblUserType.Name = "LblUserType";
            this.LblUserType.Size = new System.Drawing.Size(76, 18);
            this.LblUserType.TabIndex = 11;
            this.LblUserType.Text = "UserType:";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUsername.Location = new System.Drawing.Point(689, 144);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(100, 24);
            this.TxtUsername.TabIndex = 12;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPassword.Location = new System.Drawing.Point(689, 218);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(100, 24);
            this.TxtPassword.TabIndex = 13;
            // 
            // TxtUsertypes
            // 
            this.TxtUsertypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUsertypes.Location = new System.Drawing.Point(689, 284);
            this.TxtUsertypes.Name = "TxtUsertypes";
            this.TxtUsertypes.Size = new System.Drawing.Size(100, 24);
            this.TxtUsertypes.TabIndex = 14;
            // 
            // LblRegisterno
            // 
            this.LblRegisterno.AutoSize = true;
            this.LblRegisterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblRegisterno.Location = new System.Drawing.Point(602, 12);
            this.LblRegisterno.Name = "LblRegisterno";
            this.LblRegisterno.Size = new System.Drawing.Size(87, 18);
            this.LblRegisterno.TabIndex = 15;
            this.LblRegisterno.Text = "RegisterNo:";
            // 
            // TxtRegisterNo
            // 
            this.TxtRegisterNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtRegisterNo.Location = new System.Drawing.Point(689, 12);
            this.TxtRegisterNo.Name = "TxtRegisterNo";
            this.TxtRegisterNo.Size = new System.Drawing.Size(100, 24);
            this.TxtRegisterNo.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Update";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Delete";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 58;
            this.label8.Text = "List";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(647, 424);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(179, 23);
            this.progressBar.TabIndex = 63;
            this.progressBar.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(637, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 71);
            this.label2.TabIndex = 66;
            this.label2.Text = "enter admin for Admin Type, user for Normal User, part-time-user for Part Time Us" +
    "er ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Download";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.BackgroundImage = global::OOP2_2_PreLab.Properties.Resources.backup;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(465, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 92);
            this.button1.TabIndex = 67;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.Moccasin;
            this.btn_kapat.BackgroundImage = global::OOP2_2_PreLab.Properties.Resources.cross;
            this.btn_kapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kapat.Location = new System.Drawing.Point(810, 11);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(55, 53);
            this.btn_kapat.TabIndex = 65;
            this.btn_kapat.UseVisualStyleBackColor = false;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.Orange;
            this.BtnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnUpdate.BackgroundImage")));
            this.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnUpdate.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUpdate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnUpdate.Location = new System.Drawing.Point(329, 312);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(89, 93);
            this.BtnUpdate.TabIndex = 57;
            this.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Orange;
            this.BtnDelete.BackgroundImage = global::OOP2_2_PreLab.Properties.Resources.delete;
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDelete.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnDelete.Location = new System.Drawing.Point(180, 312);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(92, 93);
            this.BtnDelete.TabIndex = 56;
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnLists
            // 
            this.BtnLists.BackColor = System.Drawing.Color.Orange;
            this.BtnLists.BackgroundImage = global::OOP2_2_PreLab.Properties.Resources.customer;
            this.BtnLists.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLists.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnLists.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnLists.Location = new System.Drawing.Point(30, 311);
            this.BtnLists.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnLists.Name = "BtnLists";
            this.BtnLists.Size = new System.Drawing.Size(91, 93);
            this.BtnLists.TabIndex = 54;
            this.BtnLists.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnLists.UseVisualStyleBackColor = false;
            this.BtnLists.Click += new System.EventHandler(this.BtnLists_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(41, 38);
            this.btnBack.TabIndex = 4;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(MyOrganizerApplication.Kullanici);
            // 
            // loginFormBindingSource
            // 
            this.loginFormBindingSource.DataSource = typeof(MyOrganizerApplication.LoginForm);
            // 
            // TxtSalary
            // 
            this.TxtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSalary.Location = new System.Drawing.Point(689, 79);
            this.TxtSalary.Name = "TxtSalary";
            this.TxtSalary.Size = new System.Drawing.Size(100, 24);
            this.TxtSalary.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(602, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 69;
            this.label4.Text = "Salary:";
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(871, 459);
            this.ControlBox = false;
            this.Controls.Add(this.TxtSalary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnLists);
            this.Controls.Add(this.TxtRegisterNo);
            this.Controls.Add(this.LblRegisterno);
            this.Controls.Add(this.TxtUsertypes);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.LblUserType);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblUserName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.Enabled = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management";
            this.Load += new System.EventHandler(this.Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginFormBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource loginFormBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblUserType;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUsertypes;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegisterNo;
        private System.Windows.Forms.Label LblRegisterno;
        private System.Windows.Forms.TextBox TxtRegisterNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnLists;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSalary;
        private System.Windows.Forms.Label label4;
    }
}