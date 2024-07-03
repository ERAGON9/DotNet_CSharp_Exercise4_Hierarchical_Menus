﻿using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    internal class VersionCapitalsMenuInterfaces
    {
        SubMenu m_VersionCapitalsMenu;

        public SubMenu VersionsCapitalsMenu
        {
            get 
            {
                return m_VersionCapitalsMenu;
            }
        }

        public VersionCapitalsMenuInterfaces()
        {
            m_VersionCapitalsMenu = new SubMenu("Version and Capitals");
            fillShowVersion(m_VersionCapitalsMenu);
            fillCountCapitals(m_VersionCapitalsMenu);
        }

        private void fillShowVersion(SubMenu i_VersionAndCapitalsMenu)
        {
            ExecuteItem versionExecute = new ExecuteItem("Show Version");
            TestVersion testVersion = new TestVersion();

            versionExecute.AddPickOptionListener(testVersion);
            i_VersionAndCapitalsMenu.AddItemToMenu(versionExecute);
        }

        private void fillCountCapitals(SubMenu i_VersionAndCapitalsMenu)
        {
            ExecuteItem capitalsExecute = new ExecuteItem("Count Capitals");
            TestCapitals testCapitals = new TestCapitals();

            capitalsExecute.AddPickOptionListener(testCapitals);
            i_VersionAndCapitalsMenu.AddItemToMenu(capitalsExecute);
        }

        private class TestVersion : IPickOptionListener
        {
            void IPickOptionListener.PickOption()
            {
                Console.WriteLine("App Version: 24.2.4.9504");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        private class TestCapitals : IPickOptionListener
        {
            void IPickOptionListener.PickOption()
            {
                Console.WriteLine("Please write a sentence:");
                string sentence = Console.ReadLine();
                int countCapitals = 0;

                foreach (char character in sentence)
                {
                    if (char.IsUpper(character))
                    {
                        countCapitals++;
                    }
                }

                Console.WriteLine($"There is: {countCapitals} upper case letters at your sentence.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
