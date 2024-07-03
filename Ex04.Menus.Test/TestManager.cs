using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    internal class TestManager
    {
        private MenuInterfaces m_TestMenuInterfaces;
        private MenuEvents m_TestMenuEvents;

        public TestManager()
        {
            m_TestMenuInterfaces = new MenuInterfaces();
            m_TestMenuEvents = new MenuEvents();
        }

        public void Run()
        {
            m_TestMenuInterfaces.MainMenu.Show();
            m_TestMenuEvents.MainMenu.Show();
        }
    }
}
