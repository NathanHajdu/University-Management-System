using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversitySystem
{
    public partial class FSUSystem : Form
    {
        public FSUSystem()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            studentForm form = new studentForm();
            form.Show();
        }

        private void btnInstructor_Click(object sender, EventArgs e)
        {
            instructorForm form = new instructorForm();
            form.Show();
        }
    }

}
