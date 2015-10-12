using System;
using System.Diagnostics;
using System.IO;
using System.Text;

internal class FileUtils
{
	public static void SaveBinaryToFile(string filePath, byte[] content)
	{
		if (!Directory.Exists(Path.GetDirectoryName(filePath)))
		{
			Directory.CreateDirectory(Path.GetDirectoryName(filePath));
		}
		File.WriteAllBytes(filePath, content);
	}

	public static void SaveTextToFile(string filePath, string text)
	{
		if (!Directory.Exists(Path.GetDirectoryName(filePath)))
		{
			Directory.CreateDirectory(Path.GetDirectoryName(filePath));
		}
		File.WriteAllText(filePath, text, Encoding.Unicode);
	}

	public static void LaunchFile(string filePath, string arguments, bool runAsAdmin, ProcessWindowStyle windowStyle)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = filePath;
		processStartInfo.Arguments = arguments;
		processStartInfo.WindowStyle = windowStyle;
		if (runAsAdmin)
		{
			processStartInfo.Verb = "runas";
		}
		Process.Start(processStartInfo);
	}
}
