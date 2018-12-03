using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Capstone
{
    public partial class CourseCapstone : Form
    {
        public CourseCapstone()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            }

        private void txtNumberCourses_TextChanged(object sender, EventArgs e)
        {
            Convert.ToInt32 (txtNumberCourses);
        }

       
        }
    }
