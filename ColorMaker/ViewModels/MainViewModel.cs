using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;

namespace ColorMaker.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        protected override void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);

            if (e.PropertyName.CompareTo(nameof(RedValue)) == 0)
            {
                setColor();
            }
            else if (e.PropertyName.CompareTo(nameof(GreenValue)) == 0)
            {
                setColor();
            }
            else if (e.PropertyName.CompareTo(nameof(BlueValue)) == 0)
            {
                setColor();
            }
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


        private void setColor()
        {

            Color = Color.FromRgb(RedValue, GreenValue, BlueValue);
            Background = new SolidColorBrush(Color);
        }

        
    }
}
