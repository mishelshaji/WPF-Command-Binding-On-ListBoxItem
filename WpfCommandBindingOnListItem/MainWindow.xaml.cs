using System.Windows;
using WpfCommandBindingOnListItem.CustomCommands;
using WpfCommandBindingOnListItem.ViewModels;

namespace WpfCommandBindingOnListItem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            // DataContext = new MainWindowViewModel();
        }
    }
}