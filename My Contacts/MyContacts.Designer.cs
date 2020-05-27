namespace My_Contacts
{
    partial class MyContacts
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtBoxContactId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtBoxPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBoxCompany = new System.Windows.Forms.TextBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.myContactsDataSet = new My_Contacts.MyContactsDataSet();
            this.contactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactsTableAdapter = new My_Contacts.MyContactsDataSetTableAdapters.ContactsTableAdapter();
            this.contactIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myContactsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(393, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Contacts";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(68, 189);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(106, 25);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFirstName.Location = new System.Drawing.Point(280, 186);
            this.txtBoxFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(224, 30);
            this.txtBoxFirstName.TabIndex = 2;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLastName.Location = new System.Drawing.Point(280, 240);
            this.txtBoxLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(224, 30);
            this.txtBoxLastName.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(68, 243);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(106, 25);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name";
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAddress.Location = new System.Drawing.Point(280, 297);
            this.txtBoxAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxAddress.Multiline = true;
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(224, 125);
            this.txtBoxAddress.TabIndex = 8;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(68, 300);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(85, 25);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Address";
            // 
            // txtBoxContactId
            // 
            this.txtBoxContactId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxContactId.Location = new System.Drawing.Point(280, 129);
            this.txtBoxContactId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxContactId.Name = "txtBoxContactId";
            this.txtBoxContactId.ReadOnly = true;
            this.txtBoxContactId.Size = new System.Drawing.Size(224, 30);
            this.txtBoxContactId.TabIndex = 6;
            this.txtBoxContactId.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(68, 132);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(104, 25);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "Contact ID";
            this.lblId.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPhone.Location = new System.Drawing.Point(280, 503);
            this.txtBoxPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.Size = new System.Drawing.Size(224, 30);
            this.txtBoxPhone.TabIndex = 12;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(68, 506);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(69, 25);
            this.lblPhone.TabIndex = 11;
            this.lblPhone.Text = "Phone";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(280, 449);
            this.txtBoxEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(224, 30);
            this.txtBoxEmail.TabIndex = 10;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(68, 452);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(67, 25);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "E-mail";
            // 
            // txtBoxCompany
            // 
            this.txtBoxCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCompany.Location = new System.Drawing.Point(280, 560);
            this.txtBoxCompany.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxCompany.Name = "txtBoxCompany";
            this.txtBoxCompany.Size = new System.Drawing.Size(224, 30);
            this.txtBoxCompany.TabIndex = 15;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(68, 563);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(97, 25);
            this.lblCompany.TabIndex = 14;
            this.lblCompany.Text = "Company";
            this.lblCompany.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(88, 666);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(227, 69);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add Contact";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(423, 666);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(227, 69);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit Contact";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(755, 666);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(227, 69);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete Contact";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(601, 132);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(75, 25);
            this.lblSearch.TabIndex = 19;
            this.lblSearch.Text = "Search";
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearch.Location = new System.Drawing.Point(699, 129);
            this.txtBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(283, 30);
            this.txtBoxSearch.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contactIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.contactsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(592, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(423, 401);
            this.dataGridView1.TabIndex = 21;
            // 
            // myContactsDataSet
            // 
            this.myContactsDataSet.DataSetName = "MyContactsDataSet";
            this.myContactsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactsBindingSource
            // 
            this.contactsBindingSource.DataMember = "Contacts";
            this.contactsBindingSource.DataSource = this.myContactsDataSet;
            // 
            // contactsTableAdapter
            // 
            this.contactsTableAdapter.ClearBeforeFill = true;
            // 
            // contactIDDataGridViewTextBoxColumn
            // 
            this.contactIDDataGridViewTextBoxColumn.DataPropertyName = "ContactID";
            this.contactIDDataGridViewTextBoxColumn.HeaderText = "ContactID";
            this.contactIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactIDDataGridViewTextBoxColumn.Name = "contactIDDataGridViewTextBoxColumn";
            this.contactIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "E-mail";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "Company";
            this.companyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            this.companyDataGridViewTextBoxColumn.Width = 125;
            // 
            // MyContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 768);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBoxCompany);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.txtBoxPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtBoxAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtBoxContactId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MyContacts";
            this.Text = "My Contacts";
            this.Load += new System.EventHandler(this.MyContacts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myContactsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtBoxAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtBoxContactId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtBoxPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBoxCompany;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MyContactsDataSet myContactsDataSet;
        private System.Windows.Forms.BindingSource contactsBindingSource;
        private MyContactsDataSetTableAdapters.ContactsTableAdapter contactsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
    }
}

