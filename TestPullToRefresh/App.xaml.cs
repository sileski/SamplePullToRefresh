namespace TestPullToRefresh;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }

    protected override async void OnSleep()
    {
        base.OnSleep();
        NavigationHelper.SaveState();
        await Shell.Current.GoToAsync("//LockPage");
    }
}