using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Design_Patterns_Project.Music_Sequencer;

namespace Design_Patterns_Project
{
    public partial class ChannelChoice : Form
    {
        public ChannelChoice()
        {
            InitializeComponent();
        }

        private void button_Automation_Click(object sender, EventArgs e)
        {
            this.Tag = ChannelType.Automation;
            this.DialogResult = DialogResult.OK;
        }

        private void button_Drum_Click(object sender, EventArgs e)
        {
            this.Tag = ChannelType.Drum;
            this.DialogResult = DialogResult.OK;
        }

        private void button_Instrument_Click(object sender, EventArgs e)
        {
            this.Tag = ChannelType.Instrument;
            this.DialogResult = DialogResult.OK;
        }

        private void button_GoBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
