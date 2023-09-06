using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiMVVMandShellNavigation.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            Items = new ObservableCollection<string>();
        }

        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        string text;

        //Will handle async events
        [RelayCommand]
        void AddTask()
        {
            if(string.IsNullOrWhiteSpace(Text))
            {
                return;
            }
            Items.Add(Text);
            Text = string.Empty;
        }

        [RelayCommand]
        void DeleteTask(string task)
        {
            if(Items.Contains(task))
            {
                Items.Remove(task);
            }
        }
    }
}
