using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogsUI
{
    public interface IRouter
    {
        void ShowScreen(string screen);
        void GoBack();
    }
}
