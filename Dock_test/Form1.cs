using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dock_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            panelMenuSubmenu.Visible = false;
            panelplaylistsubmenu.Visible = false;
            panelEquallsubMenu.Visible = false;
        }
        private void hidesunmenu()
        {
            if (panelEquallsubMenu.Visible==true)
                panelEquallsubMenu.Visible = false;
            if (panelplaylistsubmenu.Visible==true)
                panelplaylistsubmenu.Visible = false;
            if(panelMenuSubmenu.Visible==true)
                panelMenuSubmenu.Visible = false;

        }
        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesunmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = true;
            }
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubmenu(panelMenuSubmenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hidesunmenu();
            openchildForm(new Form2());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hidesunmenu();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            hidesunmenu();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            hidesunmenu();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubmenu(panelplaylistsubmenu);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            hidesunmenu();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            hidesunmenu();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            hidesunmenu();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            hidesunmenu();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            showSubmenu(panelEquallsubMenu);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            hidesunmenu();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            hidesunmenu();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            hidesunmenu();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            hidesunmenu();

        }
        private Form activeForm = null;
        private void openchildForm(Form childform)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelchildform.Controls.Add(childform);
            panelchildform.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
    }
}
