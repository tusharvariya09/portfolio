using Microsoft.JSInterop;

namespace TusharPortfolio.Services
{
    public class ThemeService
    {
        private bool _isDark = true;
        public bool IsDark => _isDark;
        public event Action? OnThemeChanged;

        public void Toggle()
        {
            _isDark = !_isDark;
            OnThemeChanged?.Invoke();
        }

        public string ThemeAttribute => _isDark ? "dark" : "light";
    }
}
