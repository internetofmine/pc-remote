using PcControl;
using PcControl.SystemControl;
using PcControl.VolumeControl;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var app = builder.Build();

// Configure the HTTP requests
GlobalVolumeRoutes.Configure(app, VolumeControlFactory.CreateNAudioVolumeControl());
SystemRoutes.Configure(app, SystemControlFactory.CreateWindowsSystemControl());

app.Run();