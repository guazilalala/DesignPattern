using System.Windows.Controls;
using MahApps.Metro.Controls;
namespace Wing.DesignPattern.View.DesignPrinciples

{
    public sealed partial class HamburgerMenuDesignPrinciples : UserControl
    {
        public HamburgerMenuDesignPrinciples()
        {
            this.InitializeComponent();
        }

        private void HamburgerMenuControl_OnItemInvoked(object sender, HamburgerMenuItemInvokedEventArgs e)
        {
            HamburgerMenuControl.Content = e.InvokedItem;
        }
    }
}