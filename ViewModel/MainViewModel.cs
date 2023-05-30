using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiApp1.ViewModel
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

        [RelayCommand] // video suggested ICommand. Correction to use RelayCommand instead.
        void Add() // Because of our decorator, there will be a AddCommand generated
        {
            if (string.IsNullOrWhiteSpace(Text))
            {
                // Note: There is an option to use if (expression) return; instead. Even with newlines
                return;
            }
            // add our item
            Items.Add(Text);
            // Empty out the list.
            Text = string.Empty;
        }

        [RelayCommand]
        void Delete(string s)
        {
            if (Items.Contains(s))
            {
                Items.Remove(s);
            }
        }
    }
}
