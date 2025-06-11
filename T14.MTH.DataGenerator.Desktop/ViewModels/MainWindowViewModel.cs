using CommunityToolkit.Mvvm.ComponentModel;

namespace T14.MTH.DataGenerator.Desktop.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        [ObservableProperty]
        private ViewModelBase _currentViewModel = new HomeViewModel();
    }
}
