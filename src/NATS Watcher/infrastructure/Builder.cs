using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NATSWatcher.viewModels;
using NATSWatcher.views;

namespace NATSWatcher.infrastructure;

public class Builder
{
    private readonly App app;
    private IHost host;
    public Builder(App app)
    {
        this.app = app;
    }

    public void Start()
    {
        var builder = Host.CreateDefaultBuilder();

        builder.ConfigureServices(services =>
        {
            services.AddSingleton<MainVm>();
            services.AddSingleton<MainWindow>();
        });

        host = builder.Build();

        var mWin = host.Services.GetRequiredService<MainWindow>();
        app.MainWindow = mWin;
        mWin.Show();
    }
}