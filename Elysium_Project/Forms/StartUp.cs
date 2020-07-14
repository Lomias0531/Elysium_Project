using Elysium_Project.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elysium_Project
{
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
        }

        private void start_Btn(object sender, EventArgs e)
        {
            GameScene game = new GameScene();
            this.Hide();
            game.ShowDialog();
            this.Close();
        }

        private void load_Btn(object sender, EventArgs e)
        {

        }

        private void archive_Btn(object sender, EventArgs e)
        {

        }

        private void exit_Btn(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Settings_Btn_Click(object sender, EventArgs e)
        {

        }
    }
}
