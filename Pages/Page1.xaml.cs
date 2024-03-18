namespace TestBackwardsNavigation.Pages;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        var item = new ToolbarItem()
        {
            Text = "Go to Page2"
        };
        item.Clicked += OnGoToPage2;

        Shell.Current.ToolbarItems.Add(item);
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();

        Shell.Current.ToolbarItems.Clear();
    }

    private async void OnGoToPage2(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Page2));
    }
}