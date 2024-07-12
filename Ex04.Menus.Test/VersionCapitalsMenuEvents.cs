using Ex04.Menus.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    internal class VersionCapitalsMenuEvents
    {
        SubMenu m_VersionCapitalsMenu;

        public SubMenu VersionsCapitalsMenu
        {
            get
            {
                return m_VersionCapitalsMenu;
            }
        }

        public VersionCapitalsMenuEvents()
        {
            m_VersionCapitalsMenu = new SubMenu("Version and Capitals");
            fillShowVersion(m_VersionCapitalsMenu);
            fillCountCapitals(m_VersionCapitalsMenu);
        }

        private void fillShowVersion(SubMenu i_VersionAndCapitalsMenu)
        {
            ExecuteItem versionExecute = new ExecuteItem("Show Version");

            versionExecute.PickOptions += this.executeItem_ShowVersion;
            i_VersionAndCapitalsMenu.AddItemToMenu(versionExecute);
        }

        private void fillCountCapitals(SubMenu i_VersionAndCapitalsMenu)
        {
            ExecuteItem capitalsExecute = new ExecuteItem("Count Capitals");

            capitalsExecute.PickOptions += this.executeItem_CountCapitals;
            i_VersionAndCapitalsMenu.AddItemToMenu(capitalsExecute);
        }

        private void executeItem_ShowVersion()
        {
            Console.WriteLine($@"App Version: 24.2.4.9504
Press any key to continue...");
            Console.ReadKey();
        }

        private void executeItem_CountCapitals()
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

            Console.WriteLine($@"There are: {countCapitals} upper case letters in your sentence.
Press any key to continue...");
            Console.ReadKey();
        }
    }
}
