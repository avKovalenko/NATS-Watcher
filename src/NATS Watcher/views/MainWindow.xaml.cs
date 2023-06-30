using System.Windows;
using NATSWatcher.viewModels;

namespace NATSWatcher.views;

public partial class MainWindow 
{
    public MainWindow(MainVm vm)
    {
        DataContext = vm;
        InitializeComponent();
    }
}