using System.Windows.Controls;
using MahApps.Metro.Controls;
namespace Wing.DesignPattern.View.CreationalPatterns

{
    public sealed partial class HamburgerMenuCreationalPatterns : UserControl
    {
        public HamburgerMenuCreationalPatterns()
        {
            this.InitializeComponent();
        }

        private void HamburgerMenuControl_OnItemInvoked(object sender, HamburgerMenuItemInvokedEventArgs e)
        {
            HamburgerMenuControl.Content = e.InvokedItem;
        }
    }
}