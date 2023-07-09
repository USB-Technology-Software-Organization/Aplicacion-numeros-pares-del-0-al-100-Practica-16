using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace Aplicación_números_pares_del_0_al_100;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
