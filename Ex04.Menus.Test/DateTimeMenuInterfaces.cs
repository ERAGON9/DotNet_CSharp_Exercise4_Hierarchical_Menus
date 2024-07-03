using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    internal class DateTimeMenuInterfaces
    {
        SubMenu m_DateTimeMenu;

        public SubMenu DateTimeMenu
        {
            get
            {
                return m_DateTimeMenu;
            }
        }

        public DateTimeMenuInterfaces()
        {
            m_DateTimeMenu = new SubMenu("Show Date/Time");
            fillShowTime(m_DateTimeMenu);
            fillSowDate(m_DateTimeMenu);
        }

        private void fillShowTime(SubMenu i_DateTimeMenu)
        {
            ExecuteItem timeExecute = new ExecuteItem("Show Time");
            TestTime testTime = new TestTime();

            timeExecute.AddPickOptionListener(testTime);
            i_DateTimeMenu.AddItemToMenu(timeExecute);
        }
        private void fillSowDate(SubMenu i_DateTimeMenu)
        {
            ExecuteItem dateExecute = new ExecuteItem("Show Date");
            TestDate testdate = new TestDate();

            dateExecute.AddPickOptionListener(testdate);
            i_DateTimeMenu.AddItemToMenu(dateExecute);
        }

        private class TestTime : IPickOptionListener
        {
            void IPickOptionListener.PickOption()
            {
                DateTime currentDateTime = DateTime.Now;
                Console.WriteLine("The current time is: {0}", currentDateTime.ToString("HH:mm:ss"));
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        private class TestDate : IPickOptionListener
        {
            void IPickOptionListener.PickOption()
            {
                DateTime currentDateTime = DateTime.Now;
                Console.WriteLine("The current date is: {0}", currentDateTime.ToString("dd-MM-yyyy"));
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
