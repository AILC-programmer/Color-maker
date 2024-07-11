using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls.Platform;
using System.ComponentModel;

namespace ColorMaker.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private Random random = new Random();
        protected override void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);

            if (e.PropertyName.CompareTo(nameof(RedValue)) == 0)
                Color = Color.FromRgb(RedValue, GreenValue, BlueValue);

            else if (e.PropertyName.CompareTo(nameof(GreenValue)) == 0)
                Color = Color.FromRgb(RedValue, GreenValue, BlueValue);

            else if (e.PropertyName.CompareTo(nameof(BlueValue)) == 0)
                Color = Color.FromRgb(RedValue, GreenValue, BlueValue);

            else if (e.PropertyName.CompareTo(nameof(Color)) == 0)
                Background = new SolidColorBrush(Color);

        }

        [ObservableProperty]
        Color color = new Color(255, 255, 255, 255);

        [ObservableProperty]
        Brush background;

        [ObservableProperty]
        double minimumValue = 0;
        [ObservableProperty]
        double maximumValue = 1;
        [ObservableProperty]
        double redValue = 1;
        [ObservableProperty]
        double greenValue = 1;
        [ObservableProperty]
        double blueValue = 1;


        [RelayCommand]
        void GetRandomeColor()
        {
            RedValue = random.NextDouble();
            GreenValue = random.NextDouble();
            BlueValue = random.NextDouble();
        }

        [RelayCommand]
        async Task CopyHexCode()
        {
            await Clipboard.SetTextAsync(Color.ToHex());
            /*var toast = Toast.Make("Color's Hex value copied!", ToastDuration.Short);
            await toast.Show();*/
        }
    }
}
