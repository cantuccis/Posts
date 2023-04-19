using Logic;
using LogsUI.Controls;
using LogsUI.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogsUI.Screens
{
    public partial class LogsScreen : UserControl
    {
        public const string ScreenName = "LogsScreen";

        private readonly IRouter router;
        private readonly INotifier notifier;
        private readonly AuthManager authManager;

        public LogsScreen(IRouter router, INotifier notifier, AuthManager authManager)
        {
            this.router = router;
            this.authManager = authManager;
            this.notifier = notifier;

            InitializeComponent();

            this.logsList.Controls.AddRange(
                authManager.Logs.Select(
                    log => new LogCard(log)
                ).ToArray()
            );
            this.logsList.Refresh();
            this.Refresh();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            authManager.SignOut();
            notifier.ShowNotification("Signing out");
            router.GoBack();
        }
    }
}
