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

            }
            else if (e.PropertyName.CompareTo(nameof(GreenValue)) == 0)
            {

            }
            else if (e.PropertyName.CompareTo(nameof(BlueValue)) == 0)
            {

            }
        }

        [ObservableProperty]
        Brush background;

        [ObservableProperty]
        double minimumValue = 0;
        [ObservableProperty]
        double maximumValue = 255;
        [ObservableProperty]
        double redValue;
        [ObservableProperty]
        double greenValue;
        [ObservableProperty]
        double blueValue;


    }
}
