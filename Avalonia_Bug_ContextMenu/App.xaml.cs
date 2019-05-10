using Avalonia;
using Avalonia.Markup.Xaml;

namespace Avalonia_Bug_ContextMenu
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
