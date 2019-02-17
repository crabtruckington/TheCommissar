using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheCommissar
{
    public partial class bpModForm : Form
    {
        public bpModForm()
        {
            InitializeComponent();
        }

        public void changeAddRemove()
        {
            if (this.Text == "Add BP")
            {
                bpModLabel.Text = "Enter the amount of BP to add";
            }
            else
            {
                bpModLabel.Text = "Enter the amount of BP to remove";
            }
        }

        public int returnBPChangeValue()
        {
            return Convert.ToInt32(bpValueBox.Value);
        }

        private void bpModLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
