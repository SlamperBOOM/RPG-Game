using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Item
    {
        int power; //сила item'а
        string power_type; //тип урона
        string item_name; //имя предмета
        double rarity; //частота выпадения
        int level; //уровень item'а
        string[] item_type=new string[2];
        int m_armor; //прирост сопротивления магии
        int p_armor; //прирост брони
        int move; //прирост скорости

    }
}
