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
    public partial class studentForm : Form
    {
        public studentForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void takesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.takesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fSUSystemDataSet);

        }

        private void studentForm_Load(object sender, EventArgs e)
        {
            divider.Hide();
            btnReset.Hide();
            btnMain.Hide();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            divider.Show();
            btnReset.Show();
            btnMain.Show();

            if (int.TryParse(SIDField.Text, out int sid))
            {
                FSUSystemDataSet dataSet = new FSUSystemDataSet();

                using (SqlConnection connection = new SqlConnection(/* DB Connection */))
                {
                    string query = @"SELECT S.SID, S.LName, S.FName, C.CID, C.Title AS Course_Title, C.Units, C.Semester, C.Location, I.IID
                     FROM Student S
                     JOIN Takes T ON S.SID = T.SID
                     JOIN Courses C ON T.CID = C.CID
                     JOIN Instructor I ON C.IID = I.IID
                     WHERE S.SID = @sid";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@sid", sid);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataSet, "ResultTable");
                    }
                }

                studentGrid.DataSource = dataSet.Tables["ResultTable"];

                studentGrid.Columns["FName"].Visible = false;
                studentGrid.Columns["LName"].Visible = false;
                studentGrid.Columns["SID"].Visible = false;

                if (dataSet.Tables["ResultTable"].Rows.Count > 0)
                {
                    DataRow row = dataSet.Tables["ResultTable"].Rows[0];
                    string firstName = row["FName"].ToString();
                    string lastName = row["LName"].ToString();

                    nameLabel.Text = lastName + ", " + firstName + ":";

                }
                else
                {
                    nameLabel.Text = "Student Not Found";
                    
                }
            }
            else
            {
                MessageBox.Show("Invalid SID. Please enter a valid integer value.");
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            SIDField.Clear();
            nameLabel.Text = "";

            studentGrid.DataSource = null;

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
