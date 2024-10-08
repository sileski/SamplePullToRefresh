using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPullToRefresh;

public partial class LockPage : ContentPage
{
    public LockPage()
    {
        InitializeComponent();
    }

    private async void Button_OnClicked(object? sender, EventArgs e)
    {
        if (NavigationHelper.CurrentState is null)
            await Shell.Current.GoToAsync("//MainPage");
        else
        {
            await Shell.Current.GoToAsync(NavigationHelper.CurrentState);
            NavigationHelper.ClearState();
        }
    }
}