using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbMain_Click(object sender, EventArgs e)
        {

        }

        private void btstart_Click(object sender, EventArgs e)
        {

            btload.Visible = false;
            btstart.Visible = false;
            btexit.Visible = false;
            btback.Visible = true;
            btstart1.Visible = true;
            tbname.Visible = true;
            lbname.Visible = true;
            //открытие меню нового персонажа 
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            (this).Close();
            //выйти из игры
        }

        private void btstart1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(tbname.Text);
            f.ShowDialog();
            //открыть игру
        }

        private void btback_Click(object sender, EventArgs e)
        {
            btload.Visible = true;
            btstart.Visible = true;
            btexit.Visible = true;
            btback.Visible = false;
            btstart1.Visible = false;
            tbname.Visible = false;
            lbname.Visible = false;
            //вернуться в главное меню
        }
    }
}
