using Logic;
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
    public partial class SignInScreen : UserControl
    {
        public const string ScreenName = "SignInScreen";

        private IRouter router;
        private INotifier notifier;
        private AuthManager authManager;
        public SignInScreen(IRouter router, INotifier notifier, AuthManager authManager)
        {
            this.router = router;
            this.notifier = notifier;
            this.authManager = authManager;
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new PostsUser(txtUsername.Text);
                authManager.SignIn(user);
                router.ShowScreen(LogsScreen.ScreenName);
            } catch (Exception ex)
            {
                notifier.ShowNotification(ex.Message);
            }
        }
    }
}
