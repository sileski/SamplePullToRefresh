﻿namespace TestPullToRefresh;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        
        Routing.RegisterRoute("DetailsPage", typeof(DetailsPage));
    }
}