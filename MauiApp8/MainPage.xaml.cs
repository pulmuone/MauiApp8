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


            //if (DeviceDisplay.Current.MainDisplayInfo.Width >= 1080 || DeviceDisplay.Current.MainDisplayInfo.Height >= 2400)
            //{
            //    ImgInbound.WidthRequest = 48;
            //}
            //else
            //{
            //    //작게 표시
            //    ImgInbound.WidthRequest = 32;
            //}
        }
    }
}