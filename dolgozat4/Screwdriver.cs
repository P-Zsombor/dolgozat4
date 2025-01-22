using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dolgozat4
{
    public class Screwdriver : Tool
    {
        public string head { get; set; }
        public Screwdriver(string type, string material, string head) : base(type, material)
        {
            this.head = head;
        }
        public override void message(object s, EventArgs e)
        {
            MessageBox.Show($"Material: {material}, head: {head}");
        }
    }
}
