using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omryar.Helpers
{
    public static class FoundControls<T>
    {
        public static List<T> Found(Control ctr)
        {
            List<T> list = new List<T>();
            foreach (Control item in ctr.Controls)
            {
                if (item is T t)
                    list.Add(t);
            }
            return list;
        }
    }
}
