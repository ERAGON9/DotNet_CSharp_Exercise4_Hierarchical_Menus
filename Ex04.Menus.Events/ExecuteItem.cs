using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Events
{
    public class ExecuteItem : MenuItem
    {
        public event Action PickOptions;

        public ExecuteItem(string i_Title) : base(i_Title)
        {
        }

        public override void Show()
        {
            Console.Clear();
            onPickOptions();
        }

        private void onPickOptions()
        {
            PickOptions?.Invoke();
        }
    }
}
