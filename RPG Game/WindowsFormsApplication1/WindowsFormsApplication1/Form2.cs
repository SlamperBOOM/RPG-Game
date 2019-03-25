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
    public partial class Form2 : Form
    {
        public Form2(string name)
        {
            InitializeComponent();
            this.savename = name;
        }

        string savename;
        int[] coord=new int[2];
        Inventory invent = new Inventory();
        Char hero; //переменная ГГ

        void save(Char[] chars) //сохранение игры
        {
            System.IO.StreamWriter f =new System.IO.StreamWriter("saves/save1.txt");
            for (int i = 0; i < chars.Length; i++)
            {
                string[] save = new string[13];
                save[0] = chars[i].power.ToString();
                save[1] = chars[i].defend.ToString();
                save[2] = chars[i].HP.ToString();
                save[3] = chars[i].MP.ToString();
                save[4] = chars[i].level.ToString();
                save[5] = chars[i].exp.ToString();
                save[6] = chars[i].IQ.ToString();
                save[7] = chars[i].agility.ToString();
                save[8] = chars[i].strength.ToString();
                save[9] = chars[i].magic.ToString();
                save[10] = chars[i].coords[0].ToString();
                save[11] = chars[i].coords[1].ToString();
                save[12] = chars[i].name;
                f.WriteLine(save[12]);
                for (int j = 0; j < 12; j++)
                {
                     f.WriteLine(save[j]);
                }
            }
            f.Close();
        }

     
        //System.IO.StreamReader gamesave1 = new System.IO.StreamReader("save1");

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (this).Close();
            //выход в главное меню
        }

        private void сохранитьИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Char[] c=new Char[1];
            c[0] = hero;
            save(c);
            //запуск процесса сохранения
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            hero = load();
            //загрузка персонажа (временно)
        }

        public Char load()
        {
            Char hero = new Char(10, 10, 100, 100, 1, 0, 10, 5, 10, 10, invent, coord, savename);
            return hero;
            //создание персонажа
        }
    }
}
