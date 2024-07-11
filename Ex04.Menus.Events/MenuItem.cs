using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Events
{
    public abstract class MenuItem
    {
        private readonly string r_Title;

        public string Title 
        { 
            get 
            { 
                return r_Title;
            }
        }

        public MenuItem(string i_Title)
        {
            r_Title = i_Title;
        }

        public abstract void Show();
    }
}
