using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

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
            lbname.Text = "Введите имя персонажа";
            btload.Visible = false;
            btstart.Visible = false;
            btexit.Visible = false;
            btback.Visible = true;
            btstart1.Visible = true;
            tbname.Visible = true;
            lbname.Visible = true;
            //вход в меню нового персонажа 
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            (this).Close();
            //выйти из игры
        }

        private void btstart1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("saves/" + tbname.Text))
            {
                DialogResult dial = MessageBox.Show("Такое имя уже существует. Перезаписать?", "", MessageBoxButtons.YesNo);
                if (dial == DialogResult.Yes)
                {
                    Form2 f = new Form2(tbname.Text, false);
                    f.ShowDialog();
                    btback_Click(sender, e);
                }
            }
            else
            {
                Form2 f = new Form2(tbname.Text, false);
                f.ShowDialog();
                btback_Click(sender, e);
            }
            //начать новую игру
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
            btstart2.Visible = false;
            tbname1.Visible = false;
            //вернуться в главное меню
        }

        private void btload_Click(object sender, EventArgs e)
        {
            lbname.Text = "Имя вашего персонажа";
            btload.Visible = false;
            btstart.Visible = false;
            btexit.Visible = false;
            btstart2.Visible = true;
            tbname1.Visible = true;
            btback.Visible = true;
            lbname.Visible = true;
            //вход в меню загрузки
        }

        private void btstart2_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("saves/" + tbname1.Text))
            {
                Form2 f = new Form2(tbname1.Text, true);
                f.ShowDialog();
                btback_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Нет такого сохранения");
            }
            //начать игру из сохранения
        }
    }
}
