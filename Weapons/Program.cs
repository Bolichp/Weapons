﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon weap = new Weapon();

            weap.Input();
            weap.Print();
        }
    }
}
