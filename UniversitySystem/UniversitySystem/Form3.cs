using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversitySystem
{
    public partial class instructorForm : Form
    {
        public instructorForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void instructorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.instructorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fSUSystemDataSet);

        }

        private void instructorForm_Load(object sender, EventArgs e)
        {
            divider.Hide();
            btnReset.Hide();
            btnMain.Hide();
        }

        private void btnInstructor_Click(object sender, EventArgs e)
        {
            divider.Show(); 
            btnReset.Show();
            btnMain.Show();

            if (int.TryParse(IIDField.Text, out int iid))
            {
                FSUSystemDataSet dataSet = new FSUSystemDataSet();

                using (SqlConnection connection = new SqlConnection(/* DB Connection */))
                {
                    string query = @"SELECT I.FName, I.LName, I.Rank, I.Dept, C.CID, C.Title AS Course_Title, C.Units, C.Semester
                             FROM Instructor I
                             JOIN Courses C ON I.IID = C.IID
                             WHERE I.IID = @iid";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@iid", iid);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataSet, "ResultTable");
                    }
                }

                instructorGrid.DataSource = dataSet.Tables["ResultTable"];

                instructorGrid.Columns["FName"].Visible = false;
                instructorGrid.Columns["LName"].Visible = false;

                if (dataSet.Tables["ResultTable"].Rows.Count > 0)
                {
                    DataRow row = dataSet.Tables["ResultTable"].Rows[0];
                    string firstName = row["FName"].ToString();
                    string lastName = row["LName"].ToString();

                    nameLabel.Text = lastName + ", " + firstName + ":";
                }
                else
                {

                    nameLabel.Text = "Instructor Not Found";
                }
            }
            else
            {
                MessageBox.Show("Invalid IID. Please enter a valid integer value.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            IIDField.Clear();
            nameLabel.Text = "";

            instructorGrid.DataSource = null;

            divider.Hide();
            btnReset.Hide();
            btnMain.Hide();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
