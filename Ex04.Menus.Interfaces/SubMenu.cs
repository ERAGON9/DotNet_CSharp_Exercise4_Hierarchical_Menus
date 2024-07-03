using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class SubMenu : Menu
    {
        public SubMenu(string i_Title) : base(i_Title, "Back")
        {
        }
    }
}
