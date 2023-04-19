using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogsUI.Controls
{
    public partial class LogCard : UserControl
    {
        private Log log;
        public LogCard(Log log)
        {
            this.log = log;
            InitializeComponent();
            this.lblUsername.Text = log.Username;
            this.lblTimestamp.Text = log.Date.ToShortDateString();
            var action = "";
            switch (log.Action)
            {
                case Logic.Action.SIGN_IN:
                    action = "Sign in";
                    break;
                case Logic.Action.SIGN_OUT:
                    action = "Sign out";
                    break;
                default:
                    break;
            }
            this.lblAction.Text = action;
            this.Refresh();
        }
    }
}
