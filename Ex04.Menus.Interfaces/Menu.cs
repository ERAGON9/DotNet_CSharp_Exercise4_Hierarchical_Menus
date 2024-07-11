using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public abstract class Menu : MenuItem
    {
        private readonly List<MenuItem> r_MenuItems;
        private readonly string r_QuitWord;

        public Menu(string i_Title, string i_QuitWord) : base(i_Title)
        {
            r_MenuItems = new List<MenuItem>();
            r_QuitWord = i_QuitWord;
        }

        public void AddItemToMenu(MenuItem item)
        {
            r_MenuItems.Add(item);
        }

        //public void RemoveItemFromMenu(MenuItem item)
        //{
        //    r_MenuItems.Remove(item);
        //}

        public override void Show()
        {
            bool stillRunning = true;

            while (stillRunning)
            {
                Console.Clear();
                printMenu();
                int userPick = getUserPick();

                if (userPick == 0)
                {
                    stillRunning = false;
                }
                else
                {
                    r_MenuItems[userPick - 1].Show();
                }
            }
        }

        private void printMenu()
        {
            Console.WriteLine($"**{Title}**");
            Console.WriteLine("-------------------------");
            int index = 1;

            foreach (MenuItem optionItem in r_MenuItems)
            {
                Console.WriteLine($"{index} -> {optionItem.Title}");
                index++;
            }

            Console.WriteLine($"0 -> {r_QuitWord}");
            Console.WriteLine("-------------------------");
        }

        private int getUserPick()
        {
            printRequest();
            string userPick = Console.ReadLine();
            bool isCastSucceed = int.TryParse(userPick, out int userPickAsNumber);

            while (!isCastSucceed || userPickAsNumber < 0 || userPickAsNumber > r_MenuItems.Count)
            {
                Console.WriteLine($"Incorrect option, must be integer between 0 to {r_MenuItems.Count}");
                userPick = Console.ReadLine();
                isCastSucceed = int.TryParse(userPick, out userPickAsNumber);
            }

            return userPickAsNumber;
        }

        private void printRequest()
        {
            int itemsNumber = r_MenuItems.Count;

            if (itemsNumber > 1)
            {
                Console.WriteLine($"Please enter request: (1 to {itemsNumber} or press '0' to {r_QuitWord})");
            }
            else if (itemsNumber == 1)
            {
                Console.WriteLine($"Please enter request: (1 or press '0' to {r_QuitWord})");
            }
            else
            {
                Console.WriteLine($"Please enter request: (press '0' to {r_QuitWord})");
            }
        }
    }
}
