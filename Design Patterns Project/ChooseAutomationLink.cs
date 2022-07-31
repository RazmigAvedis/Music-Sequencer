using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Patterns_Project
{
    public partial class ChooseAutomationLink : Form
    {
        public ChooseAutomationLink()
        {
            InitializeComponent();
        }

        private void button_GoBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel ;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ChooseAutomationLink_Load(object sender, EventArgs e)
        {

        }

        private void button_Choose_Click(object sender, EventArgs e)
        {
            if(dataGridView_Controls.Rows.Count==0)
            {
                MessageBox.Show("No Available Controls To Automate", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button_Choose.Enabled = false;
            }
            else
            {
                this.Tag = dataGridView_Controls.SelectedRows[0];
                DialogResult = DialogResult.OK;
            }
        }
    }
}
