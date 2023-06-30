using System.Windows;
using NATSWatcher.infrastructure;

namespace NATSWatcher;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        new Builder(this).Start();
        base.OnStartup(e);
    }
}