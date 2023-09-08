using CommunityToolkit.Maui.Markup;
using Microsoft.Maui.Controls;
using System.Diagnostics;

namespace MauiApp8
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.AppendLine($"Pixel width: {DeviceDisplay.Current.MainDisplayInfo.Width} / Pixel Height: {DeviceDisplay.Current.MainDisplayInfo.Height}");
            sb.AppendLine($"Density: {DeviceDisplay.Current.MainDisplayInfo.Density}");
            sb.AppendLine($"Orientation: {DeviceDisplay.Current.MainDisplayInfo.Orientation}");
            sb.AppendLine($"Rotation: {DeviceDisplay.Current.MainDisplayInfo.Rotation}");
            sb.AppendLine($"Refresh Rate: {DeviceDisplay.Current.MainDisplayInfo.RefreshRate}");

            RowDefinitionCollection rowDefinitions;

            if (DeviceDisplay.Current.MainDisplayInfo.Width >= 1080 || DeviceDisplay.Current.MainDisplayInfo.Height >= 2400)
            {
                rowDefinitions = new()
                {
                    new RowDefinition { Height = GridLength.Star },
                    new RowDefinition { Height = GridLength.Star },
                    new RowDefinition { Height = GridLength.Star },
                    new RowDefinition { Height = GridLength.Star },
                    new RowDefinition { Height = GridLength.Star },
                    new RowDefinition { Height = GridLength.Star }, //FHD+ 해상도 2400x1080 해상도에서는 더미를 하나 추가한다.
                    new RowDefinition { Height = new GridLength(30, GridUnitType.Absolute) }
                };
            }
            else
            {
                rowDefinitions = new()
                {
                    new RowDefinition { Height = GridLength.Star },
                    new RowDefinition { Height = GridLength.Star },
                    new RowDefinition { Height = GridLength.Star },
                    new RowDefinition { Height = GridLength.Star },
                    new RowDefinition { Height = GridLength.Star },
                    new RowDefinition { Height = new GridLength(30, GridUnitType.Absolute) }
                };
            }

            this.grid.RowDefinitions = rowDefinitions;

            Label label = new()
            {
                Text = "Version 1.2.3",
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.End
            };
            label.ColumnSpan(2);
            label.Column(0);
            label.Row(rowDefinitions.Count);

            this.grid.Add(label);
        }
    }
}