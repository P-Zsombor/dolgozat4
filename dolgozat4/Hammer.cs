using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dolgozat4
{
    public class Hammer : Tool
    {
        public string handle { get; set; }
        public Hammer(string type, string material, string handle) : base(type, material)
        {
            this.handle = handle;
        }
        public override void message(object s, EventArgs e)
        {
            MessageBox.Show($"Material: {material}, handle: {handle}");
        }
    }
}
