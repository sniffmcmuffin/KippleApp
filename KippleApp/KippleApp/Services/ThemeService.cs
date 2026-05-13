namespace KippleApp.Services;

public class ThemeService
{
    private string _currentTheme = "theme-light";

    public string CurrentTheme
    {
        get => _currentTheme;
        set
        {
            if (_currentTheme != value)
            {
                _currentTheme = value;
                NotifyStateChanged();
            }
        }
    }

    public event Action? OnChange;

    public void SetTheme(string theme)
    {
        CurrentTheme = theme;
    }

    public void NotifyStateChanged()
        => OnChange?.Invoke();
}