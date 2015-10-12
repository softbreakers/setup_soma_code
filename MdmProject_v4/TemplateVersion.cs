using System;

namespace MdmProject_v4
{
	[Serializable]
	internal class TemplateVersion
	{
		private string run_file;

		private string[] root_dir;

		private string up_dir;

		private string task_name;

		private string[] files;

		private string tmp_dir;

		public string prop_tmp_dir
		{
			get
			{
				return this.tmp_dir;
			}
			set
			{
				this.tmp_dir = value;
			}
		}

		public string prop_run_file
		{
			get
			{
				return this.run_file;
			}
			set
			{
				this.run_file = value;
			}
		}

		public string[] prop_root_dirs
		{
			get
			{
				return this.root_dir;
			}
			set
			{
				this.root_dir = value;
			}
		}

		public string prop_up_dir
		{
			get
			{
				return this.up_dir;
			}
			set
			{
				this.up_dir = value;
			}
		}

		public string prop_task_name
		{
			get
			{
				return this.task_name;
			}
			set
			{
				this.task_name = value;
			}
		}

		public string[] prop_files
		{
			get
			{
				return this.files;
			}
			set
			{
				this.files = value;
			}
		}
	}
}
