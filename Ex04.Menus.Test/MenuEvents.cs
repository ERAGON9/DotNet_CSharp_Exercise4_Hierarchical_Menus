using Ex04.Menus.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    internal class MenuEvents
    {
        private MainMenu m_MainMenu;

        public MainMenu MainMenu
        {
            get
            {
                return m_MainMenu;
            }
        }
        public MenuEvents()
        {
            m_MainMenu = new MainMenu("Events Main Menu");
            VersionCapitalsMenuEvents versionsAndCapitalsMenu = new VersionCapitalsMenuEvents();
            DateTimeMenuEvents DateTimeMenu = new DateTimeMenuEvents();

            m_MainMenu.AddItemToMenu(versionsAndCapitalsMenu.VersionsCapitalsMenu);
            m_MainMenu.AddItemToMenu(DateTimeMenu.DateTimeMenu);
        }
    }
}
