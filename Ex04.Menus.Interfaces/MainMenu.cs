﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu : Menu
    {
        public MainMenu(string i_Title) : base(i_Title)
        {
            
        }

        protected override void printQuitMenu()
        {
            Console.WriteLine("0 -> Exit");
        }

    }
}
