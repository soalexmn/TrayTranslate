using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrayTranslate
{
    public class KeyboardProvider
    {
        Action _callback;
        Keys _key;


        public void SencControlC()
        {
            SendKeys.SendWait(@"^c");
        }

        public void SetHook(Keys key, Action callback)
        {
            IKeyboardEvents keyboardEvents = Hook.GlobalEvents();
            _callback = callback;
            keyboardEvents.KeyDown += keyboardEvents_KeyDown;
        }

        public void StopHooking()
        {

        }

        void keyboardEvents_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == _key)
            {
                if (_callback != null)
                {
                    _callback();
                }
            }
        }

        
    }
}
