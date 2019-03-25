using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Char
    {
        public int power; //собственная сила 
        public int armor; //броня 
        public int HP; //очки здоровья
        public int MP; //кол-во маны
        public int level; //уровень
        public int exp; //опыт 
        public int IQ; //параметр интеллекта
        public int agility; //параметр ловкости
        public int strength; //параметр силы
        public int magic; //параметр магической силы
        public Inventory invent; //инвентарь
        public int[] coords = new int[2]; //местоположение
        public string name; //имя персонажа
        public int deathexp; //опыт при смерти
        //14(15) параметров

        public Char(int p, int d, int H, int M, int l, int e, int I,
            int a, int s, int m, Inventory i, int[] c, string n, int de)
        {
            power = p;
            armor = d;
            HP = H;
            MP = M;
            level = l;
            exp = e;
            IQ = I;
            agility = a;
            strength = s;
            magic = m;
            invent = i;
            coords = c;
            name = n;
            deathexp = de;
        }
    }
}
