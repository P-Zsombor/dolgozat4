using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dolgozat4
{
    public class Tool : UserControl
    {
        private Label label1;

        public string type { get; set; }
        public string material { get; set; }

        public Tool(string type, string material)
        {
            this.type = type;
            this.material = material;

            InitializeComponent();

            this.BackColor = System.Drawing.Color.Black;

            label1.Text = type;
            label1.Left = (this.Width - label1.Width) / 2;
            label1.Top = (this.Height - label1.Height) / 2;
            this.Click += message;
            label1.Click += message;
        }

        public virtual void message(object s, EventArgs e)
        {
            MessageBox.Show($"Material: {material}");
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Tool
            // 
            this.Controls.Add(this.label1);
            this.Name = "Tool";
            this.Size = new System.Drawing.Size(119, 48);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
