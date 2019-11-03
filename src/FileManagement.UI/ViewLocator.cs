using System;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using FileManagement.UI.ViewModels;

namespace FileManagement.UI
{
    public class ViewLocator : IDataTemplate
    {
        private static readonly string Namespace = typeof(ViewLocator).Namespace + ".Views.";
        public bool SupportsRecycling => false;

        public IControl Build(object data)
        {
            var name = $"{Namespace}{data.GetType().Name.Replace("ViewModel","")}";
            var type = Type.GetType(name);

            if (type != null)
            {
                return (Control)Activator.CreateInstance(type);
            }
            else
            {
                return new TextBlock { Text = "Not Found: " + name };
            }
        }

        public bool Match(object data)
        {
            return data is ViewModelBase;
        }
    }
}