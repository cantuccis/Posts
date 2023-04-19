using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsUI.Interfaces
{
    public interface INotifier
    {
        void ShowNotification(string message);
    }
}
