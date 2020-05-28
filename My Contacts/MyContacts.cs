using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using My_Contacts.MyContactsClasses;

namespace My_Contacts
{
    public partial class MyContacts : Form
    {
        Contact c = new Contact();
        static string myConnection = ConfigurationManager.ConnectionStrings["My_Contacts.Properties.Settings.MyContactsConnectionString"].ConnectionString;
public static object ConfigurationManaer { get; private set; }

        public MyContacts()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void MyContacts_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'myContactsDataSet.Contacts' . Możesz go przenieść lub usunąć.
            this.contactsTableAdapter.Fill(this.myContactsDataSet.Contacts);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            c.FirstName = txtBoxFirstName.Text;
            c.LastName = txtBoxLastName.Text;
            c.Address = txtBoxAddress.Text;
            c.Email = txtBoxEmail.Text;
            c.Phone = txtBoxPhone.Text;
            c.Company = txtBoxCompany.Text;

            this.buttonClickEvent("add", sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            c.ContactID = int.Parse(txtBoxContactId.Text);
            c.FirstName = txtBoxFirstName.Text;
            c.LastName = txtBoxLastName.Text;
            c.Address = txtBoxAddress.Text;
            c.Email = txtBoxEmail.Text;
            c.Phone = txtBoxPhone.Text;
            c.Company = txtBoxCompany.Text;

            this.buttonClickEvent("update", sender, e);
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            txtBoxContactId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtBoxFirstName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtBoxLastName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtBoxAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtBoxEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtBoxPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtBoxCompany.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            c.ContactID = int.Parse(txtBoxContactId.Text);
            c.FirstName = txtBoxFirstName.Text;
            c.LastName = txtBoxLastName.Text;
            c.Address = txtBoxAddress.Text;
            c.Email = txtBoxEmail.Text;
            c.Phone = txtBoxPhone.Text;
            c.Company = txtBoxCompany.Text;

            this.buttonClickEvent("delete", sender, e);
        }

        private void buttonClickEvent (string type, object sender, EventArgs e)
        {
            bool con = false;
            bool success = false;
            string successMessage = "";
            switch(type)
            {
                case "add":
                    success = c.Insert(c);
                    successMessage = "New Contact successfully added.";
                    con = true;
                    break;
                case "update":
                    success = c.Update(c);
                    successMessage = "Contact successfully updated.";
                    con = true;
                    break;
                case "delete":
                    success = c.Delete(c);
                    successMessage = "Contact successfully removed.";
                    con = true;
                    break;
                default:
                    MessageBox.Show("Wrong operation.");
                    break;
            }

            if (true == con)
            {
                if (success == true)
                {
                    MessageBox.Show(successMessage);
                    this.MyContacts_Load(sender, e);
                    this.ClearForm();
                }
                else
                {
                    MessageBox.Show("Something went wrong.");
                }
            }
            else
            {
                this.ClearForm();
            }
        }

        private void ClearForm()
        {
            txtBoxContactId.Text = "";
            txtBoxFirstName.Text = "";
            txtBoxLastName.Text = "";
            txtBoxAddress.Text = "";
            txtBoxEmail.Text = "";
            txtBoxPhone.Text = "";
            txtBoxCompany.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string keyWord = txtBoxSearch.Text;
            SqlConnection conn = new SqlConnection(myConnection);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Contacts WHERE [FirstName] LIKE '%"+ keyWord + "%' OR [LastName] LIKE '%" + keyWord + "%'", conn);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
