using Prism.Commands;
using Prism.Navigation;

namespace Test.RestfulApi.ViewModels
{
  public class MainPageViewModel : ViewModelBase
  {
    public MainPageViewModel(INavigationService navigationService)
        : base(navigationService)
    {
      Title = "Choose REST Helper";
    }

    public DelegateCommand CmdRefit => new DelegateCommand(OnRefit);
    public DelegateCommand CmdRestSharp => new DelegateCommand(OnRestSharp);

    private async void OnRefit()
    {
      // Navigate to Refit Samples
    }

    private async void OnRestSharp()
    {
      // Navigate to Refit Samples
    }
  }
}
