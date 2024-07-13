using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class ExecuteItem : MenuItem
    {
        private List<IPickOptionListener> m_PickOptionListeners;

        public ExecuteItem(string i_Title) : base(i_Title)
        {
            m_PickOptionListeners = new List<IPickOptionListener>();
        }

        public void AddPickOptionListener(IPickOptionListener i_listener)
        {
            m_PickOptionListeners.Add(i_listener);
        }

        public void RemovePickOptionListener(IPickOptionListener i_listener)
        {
            m_PickOptionListeners.Remove(i_listener);
        }

        public override void Show()
        {
            Console.Clear();
            onPickOptionListeners();
        }

        private void onPickOptionListeners()
        {
            if (m_PickOptionListeners != null)
            {
                foreach (IPickOptionListener listener in m_PickOptionListeners)
                {
                    listener.PickOption();
                }
            }
        }
    }
}
