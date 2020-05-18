using System;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
using Refit;
using Test.RestfulApi.Models;

namespace Test.RestfulApi.ViewModels
{
  ////public interface IGitHubApi
  ////{
  ////  [Get("/users/{user}")]
  ////  Task<User> GetUser(string user);
  ////}

  public class RefitSampleViewModel : BindableBase
  {
    private string _jsonOutput;

    public RefitSampleViewModel()
    {
    }

    public DelegateCommand CmdRefitGet => new DelegateCommand(OnRefitGet);

    public string JsonOutput
    {
      get => _jsonOutput;
      set => SetProperty(ref _jsonOutput, value);
    }

    private async void OnRefitGet()
    {
      ////var gitHubApi = RestService.For<IGitHubApi>("https://api.github.com");
      ////var results = await gitHubApi.GetUser("octocat");

      ////var service = new CatsService(new Uri("https://api.thecatapi.com"));
      
      var service = new RestService.For<ITheCatsAPI>("https://api.thecatapi.com");
      var results = await service.Search("bengal");

      JsonOutput = results;
    }
  }
}
}
