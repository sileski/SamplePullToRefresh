namespace TestPullToRefresh;

public static class NavigationHelper
{
    public static ShellNavigationState? CurrentState;
    
    public static void SaveState()
    {
        CurrentState = Shell.Current.CurrentState;
    }
    
    public static void ClearState()
    {
        CurrentState = null;
    }
}