using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiMVVMandShellNavigation.ViewModels
{
    //ARG 1 is the internal name for this file, ARG 2 is the ID of the param passed in
    [QueryProperty("TaskDetail", "taskText")]
    public partial class DetailViewModel : ObservableObject
    {
        //Why this taskDetail NEEDS to be camel case, while the QueryProperty NEEDS to be upper case is something I am still figuring out
        [ObservableProperty]
        string taskDetail;

        [RelayCommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
