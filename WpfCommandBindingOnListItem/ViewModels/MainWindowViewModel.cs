using System.Windows;
using System.Windows.Controls;
using WpfCommandBindingOnListItem.CustomCommands;

namespace WpfCommandBindingOnListItem.ViewModels
{
    public class MainWindowViewModel
    {
        public RelayCommand SelectCommand { get; set; }

        public MainWindowViewModel()
        {
            SelectCommand = new RelayCommand(SelectedCommandHandler, CanExecuteSelectedCommand);
        }
        
        private void SelectedCommandHandler(object data)
        {
            var selectedItem = (ListBoxItem) data;
            // var selectedItem = (ListViewItem) data;
            MessageBox.Show($"Selected: {selectedItem.Content}");
        }

        private bool CanExecuteSelectedCommand(object data) => true;
    }
}