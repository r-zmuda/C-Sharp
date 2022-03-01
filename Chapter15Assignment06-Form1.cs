using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//File Browser
namespace Chapter15Assignment06
{
	public partial class FileBrowser : Form
	{
		//Variables
		string substringDirectory; //Store last part path name
		string currentDirectory = Directory.GetCurrentDirectory(); //Store current directory

		//Constructor
		public FileBrowser()
		{
			InitializeComponent();
		}

		//Events
		//Load
		public void Form1_Load(object sender, EventArgs e)
		{
			//Load icons
			ImageList.Images.Add(Properties.Resources.folder);
			ImageList.Images.Add(Properties.Resources.file);
			//Load current directory on startup
			LoadDir(currentDirectory);
			InputBox.Text = currentDirectory;
			GoButton_Click(sender, e);
		}
		//Click FileList
		private void FileList_Click(object sender, EventArgs e)
		{
			//Ensure item is selected
			if (FileList.SelectedItems.Count != 0)
			{
				//If "..." selected, go up one level, else selected item
				if (FileList.Items[0].Selected)
				{
					DirectoryInfo directoryObject = new DirectoryInfo(currentDirectory);
					if (directoryObject.Parent != null)
					{
						LoadDir(directoryObject.Parent.FullName);
						InputBox.Text = currentDirectory;
						refreshTree();
					}
				}
				else
				{
					//Get name of selected item, check type
					string chosen = FileList.SelectedItems[0].Text;
					if (Directory.Exists(Path.Combine(currentDirectory, chosen)))
					{
						LoadDir(Path.Combine(currentDirectory, chosen));
						InputBox.Text = currentDirectory;
						refreshTree();
					}
					else
					{
						InputBox.Text = currentDirectory + "\\" + chosen;
					}
				}
			}
		}
		//Double-click FileList item
		public void FileList_DoubleClick(object sender, EventArgs e)
		{
			//Ensure item is selected
			if (FileList.SelectedItems.Count != 0)
			{
				//Get name of selected item, check type
				//If file, launch file
				string chosen = FileList.SelectedItems[0].Text;
				if (!Directory.Exists(Path.Combine(currentDirectory, chosen)))
				{
					System.Diagnostics.Process.Start(Path.Combine(currentDirectory, chosen));
					InputBox.Text = currentDirectory;
				}
			}
		}
		//Click GoButton
		private void GoButton_Click(object sender, EventArgs e)
		{
			refreshTree();
		}
		//Double-click TreeView item
		private void TreeView_DoubleClick(object sender, EventArgs e)
		{
			//Get name of selected item, check type
			//If directory, load it
			string chosen = TreeView.SelectedNode.Text;
			if (Directory.Exists(Path.Combine(currentDirectory, chosen)))
			{
				LoadDir(Path.Combine(currentDirectory, chosen));
			}
			InputBox.Text = currentDirectory;
			LoadDir(Path.Combine(currentDirectory));
			refreshTree();
		}

		//Methods
		//Make TreeView
		public void buildTree(string directoryValue, TreeNode parentNode)
		{
			//Stores all subdirectories in the directory
			string[] directoryArray = Directory.GetDirectories(directoryValue);

			//Build node with subdirectories (bar access exception)
			try
			{
				//Check if subdirectories exist
				if (directoryArray.Length != 0)
				{
					//Create TreeNode per subdirectory
					//Build recursively for their children
					foreach (string directory in directoryArray)
					{
						//Get subdirectory name, make TreeNode, add to parent node
						substringDirectory = Path.GetFileNameWithoutExtension(directory);
						TreeNode myNode = new TreeNode(substringDirectory);
						parentNode.Nodes.Add(myNode);

						//Recursively build subdirectories
						buildTree(directory, myNode);
					}
				}
			}
			catch (UnauthorizedAccessException)
			{
			}
		}

		//Display files/subdirectories
		public void LoadDir(string currentDirectoryValue)
		{
			//Load directory contents (bar access exception)
			try
			{
				//Refresh ListView, begin with "..."
				FileList.Items.Clear();
				FileList.Items.Add("...");

				//Update current directory, put files and directories into array
				currentDirectory = currentDirectoryValue;
				DirectoryInfo newCurrentDirectory = new DirectoryInfo(currentDirectory);
				DirectoryInfo[] directoryArray = newCurrentDirectory.GetDirectories();
				FileInfo[] fileArray = newCurrentDirectory.GetFiles();

				//Add subdirectories and files
				foreach (DirectoryInfo dir in directoryArray)
				{
					ListViewItem newDirectoryItem = FileList.Items.Add(dir.Name);
					newDirectoryItem.ImageIndex = 0;
				}
				foreach (FileInfo file in fileArray)
				{
					ListViewItem newFileItem = FileList.Items.Add(file.Name);
					newFileItem.ImageIndex = 1;
				}
			}
			catch (UnauthorizedAccessException)
			{
				MessageBox.Show("Warning: Some files may not be visible due to permission settings", "Attention", 0, MessageBoxIcon.Warning);
			}
		}

		//Refresh TreeView, directory changed
		public void refreshTree()
		{
			//Refresh TreeView
			TreeView.Nodes.Clear();
			//Check if directory exists
			if (Directory.Exists(InputBox.Text))
			{
				//Make nodes
				TreeView.Nodes.Add(InputBox.Text);
				buildTree(InputBox.Text, TreeView.Nodes[0]);
				//Expand parent
				TreeView.Nodes[0].Expand();
				LoadDir(InputBox.Text);
			}
			//Directory not found
			else
			{
				MessageBox.Show(InputBox.Text + " could not be found.", "Directory Not Found",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
