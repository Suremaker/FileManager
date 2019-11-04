using System.Linq;
using System.Windows.Input;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.VisualTree;

namespace FileManagement.UI.Views
{
    public class DirectoryPanel : UserControl
    {
        private readonly DataGrid _grid;

        public DirectoryPanel()
        {
            this.InitializeComponent();

            _grid = this.FindControl<DataGrid>("grid");
            _grid.AddHandler(Gestures.DoubleTappedEvent, Grid_Tapped);
        }

        private void Grid_Tapped(object sender, RoutedEventArgs e)
        {
            var item = ((IVisual)e.Source).GetSelfAndVisualAncestors()
                .OfType<DataGridRow>()
                .FirstOrDefault();

            if (item != null)
            {
                var keyBinding = _grid.KeyBindings.FirstOrDefault(b => b.Gesture.Key == Key.Enter);
                if (keyBinding?.Command?.CanExecute(item.DataContext) ?? false)
                {
                    keyBinding.Command.Execute(item.DataContext);
                    e.Handled = true;
                }
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
