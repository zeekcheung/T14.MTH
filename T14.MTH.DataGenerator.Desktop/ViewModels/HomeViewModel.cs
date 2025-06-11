using CommunityToolkit.Mvvm.ComponentModel;

namespace T14.MTH.DataGenerator.Desktop.ViewModels
{
    public partial class HomeViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string _greeting = "Hello, World!";
    }
}
