using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Lesson3
{
    public partial class NextForm : Form
    {
        // declare a property that has the shape of the previous form
        public StartForm previousForm { get; set; }
        public NextForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            // show the previous form
            this.previousForm.Show();
            this.Close();
        }

        private void NextForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.previousForm.Show();
        }
    }
}
