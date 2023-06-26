using RE4_PS2_Toolset.Forms;
using RE4_PS2_Toolset.Forms.AEV;
using RE4_PS2_Toolset.Forms.ETS;
using System;
using System.Windows.Forms;

namespace RE4_PS2_Toolset
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void aevBtn_Click(object sender, EventArgs e)
        {
            AEVForm aev = new AEVForm();

            aev.Show();
            //this.Hide();
        }

        private void etsBtn_Click(object sender, EventArgs e)
        {
            ETSForm ets = new ETSForm();

            ets.Show();
        }
    }
}
