namespace TestBackwardsNavigation.Pages;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        var item = new ToolbarItem()
        {
            Text = "Go to Page3"
        };
        item.Clicked += OnGoToPage3;

        Shell.Current.ToolbarItems.Add(item);
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();

        Shell.Current.ToolbarItems.Clear();
    }

    private async void OnGoToPage3(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Page3));
    }
}