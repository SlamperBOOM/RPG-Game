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
    public partial class Form3 : Form
    {
        public Form3(Inventory invent, Char char1, int i)
        {
            InitializeComponent();
            this.invent = invent;
            this.char1 = char1;
            this.t = i; //0-инвентарь предмета/персонажа 1-характеристики хранилища/персонажа 
        }
        Inventory invent;
        Char char1;
        int t;

        void shows()
        {
            if (t == 1)//показ характеристик обьекта
            {
                this.Width = 375;
                this.Height = 520;
                lbcn1.Visible = true;
                lbcn2.Visible = true;
                lbcn3.Visible = true;
                lbcn4.Visible = true;
                lbcn5.Visible = true;
                lbcn6.Visible = true;
                lbcn7.Visible = true;
                lbcn8.Visible = true;
                lbcn9.Visible = true;
                lbcn10.Visible = true;
                lbcn11.Visible = true;
                lbcc1.Visible = true;
                lbcc2.Visible = true;
                lbcc3.Visible = true;
                lbcc4.Visible = true;
                lbcc5.Visible = true;
                lbcc6.Visible = true;
                lbcc7.Visible = true;
                lbcc8.Visible = true;
                lbcc9.Visible = true;
                lbcc10.Visible = true;
                lbcc11.Visible = true;
                lbcc1.Text = char1.name;
                lbcc2.Text = char1.HP.ToString();
                lbcc3.Text = char1.MP.ToString();
                lbcc4.Text = char1.power.ToString();
                lbcc5.Text = char1.strength.ToString();
                lbcc6.Text = char1.magic.ToString();
                lbcc7.Text = char1.IQ.ToString();
                lbcc8.Text = char1.armor.ToString();
                lbcc9.Text = char1.agility.ToString();
                lbcc10.Text = char1.level.ToString();
                lbcc11.Text = char1.deathexp.ToString();
            }
            else //показ инвентаря обьекта
            {
                this.Width = 650;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (t == 0) this.Text = "Инвентарь";
            else this.Text = "Характеристики";
            shows();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
