using Elysium_Project.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elysium_Project.Forms
{
    public partial class GameScene : Form
    {
        public GameScene()
        {
            InitializeComponent();
        }

        private void GameScene_Load(object sender, EventArgs e)
        {
            Init_Data();
        }
        private void Init_Data()
        {
            DataManager.instance().galaxy = new Galaxy_Map();
        }
    }
}
