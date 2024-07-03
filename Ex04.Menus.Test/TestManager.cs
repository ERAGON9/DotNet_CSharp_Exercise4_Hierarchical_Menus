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

        public TestManager()
        {
            m_TestMenuInterfaces = new MenuInterfaces();
        }

        public void Run()
        {
            m_TestMenuInterfaces.MainMenu.Show();

        }
    }
}
