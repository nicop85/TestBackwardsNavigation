using TestBackwardsNavigation.Pages;

namespace TestBackwardsNavigation
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            InitializeRouting();
        }

        private void InitializeRouting()
        {
            Routing.RegisterRoute(nameof(Page1), typeof(Page1));
            Routing.RegisterRoute(nameof(Page2), typeof(Page2));
            Routing.RegisterRoute(nameof(Page3), typeof(Page3));
        }
    }
}
