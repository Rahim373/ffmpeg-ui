using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace FfmpegApp
{
	public partial class Form1 : Form
	{
		private string _defaultOutputDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Videos");

		public Form1()
		{
			InitializeComponent();
			openFileDialog1.Multiselect = true;
			ouputDirLabel.Text = _defaultOutputDir;
		}

		private void convertButton_Click(object sender, EventArgs e)
		{
			if (fileListBox.Items.Count > 0)
			{
				convertButton.Enabled = false;
				addFilesButton.Enabled = false;
				folderOpenButton.Enabled = false;

				statusLabel.Text = "Converting...";

				int numberOfFiles = fileListBox.Items.Count;
				int counter = 1;

				foreach (string item in fileListBox.Items)
				{
					string output = _defaultOutputDir + $"\\{Path.GetFileNameWithoutExtension(item)}-{DateTime.Now.Ticks}.mp4";
					LaunchCommandLineApp(item, output);
					statusLabel.Text = counter++ + " File(s) converted";
				}

				Process.Start("explorer.exe", "\"" + _defaultOutputDir + "\"");

				statusLabel.Text = "Completed.";

				convertButton.Enabled = true;
				addFilesButton.Enabled = true;
				folderOpenButton.Enabled = true;
			}
			else
			{
				MessageBox.Show("No files are selected.");
			}
		}

		private void LaunchCommandLineApp(string input, string outputFile)
		{
			ProcessStartInfo startInfo = new ProcessStartInfo();
			startInfo.CreateNoWindow = false;
			startInfo.UseShellExecute = false;
			startInfo.FileName = "ffmpeg.exe";
			startInfo.WindowStyle = ProcessWindowStyle.Hidden;
			startInfo.Arguments = $"-i \"{input}\" \"{outputFile}\"";
			startInfo.CreateNoWindow = true;
			try
			{
				using (Process exeProcess = Process.Start(startInfo))
				{
					exeProcess.WaitForExit();
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
		}

		private void openFileButton_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				foreach (string file in openFileDialog1.FileNames)
				{
					if (fileListBox.Items.Contains(file)) continue;
					fileListBox.Items.Add(file);
				}
			}

			numberOfFilesLabel.Text = fileListBox.Items.Count.ToString();

			if (fileListBox.Items.Count > 0)
			{
				statusLabel.Text = "Pending...";
			}

		}

		private void folderOpenButton_Click(object sender, EventArgs e)
		{
			folderBrowserDialog1.SelectedPath = Environment.CurrentDirectory;
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				ouputDirLabel.Text = folderBrowserDialog1.SelectedPath;
				_defaultOutputDir = folderBrowserDialog1.SelectedPath;
			}
		}

		private void removeAllButton_Click(object sender, EventArgs e)
		{
			fileListBox.Items.Clear();
		}

		private void removeSelectctedButton_Click(object sender, EventArgs e)
		{
			while (fileListBox.SelectedItems.Count > 0)
			{
				fileListBox.Items.Remove(fileListBox.SelectedItems[0]);
			}
		}
	}
}