using System;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using ControlCatalog.ViewModels;

namespace ControlCatalog.Pages
{
    public class PivotPage : UserControl
    {
        public PivotPage()
        {
            InitializeComponent();

            DataContext = new PivotPageViewModel
            {
                Tabs = new[]
                {
                    new TabControlPageViewModelItem
                    {
                        Header = "Arch",
                        Text = "This is the first templated tab page.",
                        Image = LoadBitmap("avares://ControlCatalog/Assets/delicate-arch-896885_640.jpg"),
                    },
                    new TabControlPageViewModelItem
                    {
                        Header = "Leaf",
                        Text = "This is the second templated tab page.",
                        Image = LoadBitmap("avares://ControlCatalog/Assets/maple-leaf-888807_640.jpg"),
                    },
                    new TabControlPageViewModelItem
                    {
                        Header = "Disabled",
                        Text = "You should not see this.",
                        IsEnabled = false,
                    },
                },
                TabPlacement = PivotHeaderPlacement.Top,
            };
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private static IBitmap LoadBitmap(string uri)
        {
            var assets = AvaloniaLocator.Current.GetRequiredService<IAssetLoader>();
            return new Bitmap(assets.Open(new Uri(uri)));
        }
    }
}