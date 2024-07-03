﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    internal class Menu : MenuItem
    {
        private List<MenuItem> m_MenuItems;

        public Menu(string i_Title) : base(i_Title)
        {
        }

        public override void Show()
        {
            bool stillRunning = true;

            while (stillRunning)
            {
                printMenu();
                int userPick = getUserPick();

                if (userPick == 0)
                {
                    stillRunning = false;
                }
                else
                {
                    m_MenuItems[userPick].Show();
                }


            }
        }

        private void printMenu()
        {
            Console.WriteLine($"**{Title}**");
            Console.WriteLine("-------------------------");
            int index = 1;

            foreach (MenuItem optionItem in m_MenuItems)
            {
                Console.WriteLine($"{index} -> {optionItem.Title}");
                index++;
            }

            Console.WriteLine("0 -> Exit");
            Console.WriteLine("-------------------------");
        }

        private int getUserPick()
        {
            printRequest();
            string userPick = Console.ReadLine();
            bool isCastSucceed = int.TryParse(userPick, out int userPickAsNumber);

            while (!isCastSucceed || userPickAsNumber < 0 || userPickAsNumber > m_MenuItems.Count)
            {
                Console.WriteLine($"Incorrect option, must be integer between 0 to {m_MenuItems.Count}");
                userPick = Console.ReadLine();
                isCastSucceed = int.TryParse(userPick, out userPickAsNumber);
            }

            return userPickAsNumber;
        }

        private void printRequest()
        {
            int itemsNumber = m_MenuItems.Count;

            if (itemsNumber > 1)
            {
                Console.WriteLine($"Please enter request: (1 to {itemsNumber} or press '0' to Exit)");
            }
            else if (itemsNumber == 1)
            {
                Console.WriteLine($"Please enter request: (1 or press '0' to Exit)");
            }
            else
            {
                Console.WriteLine($"Please enter request: (press '0' to Exit)");
            }
        }

    }
}
