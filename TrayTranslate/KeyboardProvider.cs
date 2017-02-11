using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrayTranslate
{
    public class KeyboardProvider
    {


        public void SencControlC()
        {
            SendKeys.SendWait(@"^c");
        }

        public void SetHook(KeyEventHandler callback)
        {
            IKeyboardEvents keyboardEvents = Hook.GlobalEvents();
            keyboardEvents.KeyDown += callback;
        }

        public void RemoveAllKeyDownHooks()
        {
            StopHooking("KeyDown");
        }

        public void StopHooking(string eventName)
        {
            var globalEvents = Hook.GlobalEvents();
            FieldInfo eventField = typeof(IKeyboardEvents).GetField(eventName, BindingFlags.Static | BindingFlags.NonPublic);
            object eventFieldValue = eventField.GetValue(globalEvents);

            PropertyInfo pi = globalEvents.GetType().GetProperty("Events",BindingFlags.NonPublic | BindingFlags.Instance);
            EventHandlerList list = (EventHandlerList)pi.GetValue(globalEvents, null);

            list.RemoveHandler(eventFieldValue, list[eventFieldValue]);
        }
        

        
    }
}
