using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public interface IPickOptionListener
    {
        void PickOption();
    }

    internal class ExecuteItem : MenuItem
    {
        private List<IPickOptionListener> PickOptionListeners;

        public ExecuteItem(string i_Title) : base(i_Title)
        {
            PickOptionListeners = new List<IPickOptionListener>();
        }

        public void AddPickOptionListener(IPickOptionListener i_listener)
        {
            PickOptionListeners.Add(i_listener);
        }

        public void RemovePickOptionListener(IPickOptionListener i_listener)
        {
            PickOptionListeners.Remove(i_listener);
        }

        public override void Show()
        {
            Console.Clear();
            OnPickOptionListeners();

        }

        private void OnPickOptionListeners()
        {
            if (PickOptionListeners != null)
            {
                foreach (IPickOptionListener listener in PickOptionListeners)
                {
                    listener.PickOption();
                }
            }
        }

    }
}
