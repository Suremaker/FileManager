using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace FileManagement.UI.Views
{
    public class DirectoryPanel : UserControl
    {
        public DirectoryPanel()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
