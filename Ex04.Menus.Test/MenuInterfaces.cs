using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    internal class MenuInterfaces
    {
        private MainMenu m_MainMenu;

        public MainMenu MainMenu
        {  
            get 
            {
                return m_MainMenu; 
            } 
        }
        public MenuInterfaces() 
        {
            m_MainMenu = new MainMenu("Interfaces Main Menu");
            VersionCapitalsMenuInterfaces versionsAndCapitalsMenu = new VersionCapitalsMenuInterfaces();
            DateTimeMenuInterfaces DateTimeMenu = new DateTimeMenuInterfaces();

            m_MainMenu.AddItemToMenu(versionsAndCapitalsMenu.VersionsCapitalsMenu);
            m_MainMenu.AddItemToMenu(DateTimeMenu.DateTimeMenu);
        }
    }
}
