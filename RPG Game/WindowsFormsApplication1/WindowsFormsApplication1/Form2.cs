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
        public Form2(string name, bool i)
        {
            InitializeComponent();
            this.savename = name;
            this.game = i;
        }
        bool game; //тип загрузки(новая игра или загрузка из сохр.)
        string savename; //имя персонажа
        Inventory invent = new Inventory(1);
        Char hero; //переменная ГГ

        void save(Char[] chars) //сохранение игры
        {
            if(!Directory.Exists("saves/"+savename)) Directory.CreateDirectory("saves/" + savename);
            System.IO.StreamWriter f = new System.IO.StreamWriter("saves/" + savename + "/chars.txt");
            f.WriteLine(1);
            for (int i = 0; i < chars.Length; i++)
            {
                string[] save = new string[14];
                save[0] = chars[i].power.ToString();
                save[1] = chars[i].armor.ToString();
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
                save[12] = chars[i].deathexp.ToString();
                save[13] = chars[i].name;
                f.WriteLine(save[13]);
                for (int j = 0; j < 13; j++)
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
            if (game)
            {
                load();
            }
            else
            {
                int[] coord = new int[2];
                hero = new Char(10, 10, 100, 100, 1, 0, 10, 5, 10, 10, invent, coord, savename, 0);
            }
            //загрузка сохранения или создание персонажа
        }

        public void load() //загрузка сохранения
        {
            System.IO.StreamReader f = new System.IO.StreamReader("saves/" + savename + "/chars.txt");
            int count = Convert.ToInt32(f.ReadLine());
            Char[] players = new Char[count];
            for (int i = 0; i < count; i++)
            {
                string n = f.ReadLine();
                int p = Convert.ToInt32(f.ReadLine());
                int d = Convert.ToInt32(f.ReadLine());
                int H = Convert.ToInt32(f.ReadLine());
                int M = Convert.ToInt32(f.ReadLine());
                int l = Convert.ToInt32(f.ReadLine());
                int e = Convert.ToInt32(f.ReadLine());
                int I = Convert.ToInt32(f.ReadLine());
                int a = Convert.ToInt32(f.ReadLine());
                int s = Convert.ToInt32(f.ReadLine());
                int m = Convert.ToInt32(f.ReadLine());
                int[] coord = new int[2];
                coord[0] = Convert.ToInt32(f.ReadLine());
                coord[1] = Convert.ToInt32(f.ReadLine());
                int de = Convert.ToInt32(f.ReadLine());
                players[i] = new Char(p, d, H, M, l, e, I, a, s, m, invent, coord, n, de);
            }
            hero = players[0];
        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'i')
            {
                Form3 f = new Form3(hero.invent, hero, 0);
                f.ShowDialog();
            }
            if (e.KeyChar == 'p')
            {
                Form3 f = new Form3(hero.invent, hero, 1);
                f.ShowDialog();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void pnMC_MouseClick(object sender, MouseEventArgs e)
        {
            contextMenuStrip1.Show();
        }
    }
}
