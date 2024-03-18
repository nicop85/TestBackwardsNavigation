using TestBackwardsNavigation.Pages;

namespace TestBackwardsNavigation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var item = new ToolbarItem()
            {
                Text = "Go to Page1"
            };
            item.Clicked += OnGoToPage1;

            Shell.Current.ToolbarItems.Add(item);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            Shell.Current.ToolbarItems.Clear();
        }

        private async void OnGoToPage1(object? sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(Page1));
        }
    }
}
