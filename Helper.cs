using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinBrowser
{
    public static class Helper
    {
        public static void InvokeSync<T>(this T @this, Action<T> action) where T : ISynchronizeInvoke
        {
            if (@this.InvokeRequired)
            {
                @this.Invoke(action, new object[] { @this });
            }
            else
            {
                action(@this);
            }
        }

        public enum SearchEngines
        {
            Google, 
            Bing, 
            Yahoo,
            DuckDuckGo
        }
    }
}
