using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dolgozat4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Start();
        }
        void Start()
        {
            this.BackColor = Color.Gray;
            this.ForeColor = Color.White;

            Tool shovel = new Tool("shovel", "iron");
            this.Controls.Add(shovel);

            Hammer hammer = new Hammer("hammer", "iron", "wood") { Top = 50 };
            this.Controls.Add(hammer);

            Screwdriver screwdriver = new Screwdriver("screwdriver", "iron", "cross") { Top = 100 };
            this.Controls.Add(screwdriver);
        }
    }
}
