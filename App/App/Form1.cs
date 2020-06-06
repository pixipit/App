using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            // this.WindowState = FormWindowState.Maximized;
            CreateAPage("HomePage");
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            CreateAPage("Page" + tabControl.TabCount);
        }
        public void CreateAPage(string name)
        {
            //page
            TabPage tabPage = new TabPage(name);
            tabPage.Name = name;
            tabPage.BackColor = Color.DarkGray;
            //Text
            Label header = new Label();
            header.Text = name;
            tabPage.Controls.Add(header);

            tabControl.Controls.Add(tabPage);
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
