using BrumCustomAlerts;
using Logic;
using LogsUI.Interfaces;
using LogsUI.Screens;
using MaterialSkin.Controls;
using System.Resources;
using System.Windows.Forms;

namespace LogsUI
{
    public partial class MainForm : MaterialForm, IRouter, INotifier
    {
        private readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private readonly AuthManager authManager;

        public MainForm()
        {
            authManager = new AuthManager();

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            SetupMaterialTheme();
            InitializeComponent();

            this.mainPanel.Controls.Add(new Screens.SignInScreen(this, this, this.authManager));
        }

        public void GoBack()
        {
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
                this.mainPanel.Refresh();
            }
        }

        public void ShowNotification(string message)
        {
            BrumAlertFactory.OpenAlert(
                message,
                materialSkinManager.TextHighEmphasisColor,
                materialSkinManager.CardsColor,
                global::LogsUI.Properties.Resources.user_icon,
                5000,
                AlertLocation.BottomMiddle);
  
        }

        public void ShowScreen(string screen)
        {
            UserControl newScreen = new SignInScreen(this, this, authManager);
            switch (screen)
            {
                case LogsScreen.ScreenName:
                    newScreen = new LogsScreen(this, this, authManager);
                    break;
                default:
                    break;
            }
            this.mainPanel.Controls.Add(newScreen);
            this.mainPanel.Controls.SetChildIndex(newScreen, 0);
            Refresh();
        }

        private void SetupMaterialTheme()
        {
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.DeepPurple400,
                MaterialSkin.Primary.DeepPurple500,
                MaterialSkin.Primary.Blue100,
                MaterialSkin.Accent.Blue200,
                MaterialSkin.TextShade.WHITE
               );
        }
    }


}
