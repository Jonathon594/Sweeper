
using System.ComponentModel;

namespace Sweeper
{
    public partial class SweeperControlView : Form
    {
        public SweeperModel Model { get; set; }

        public SweeperControlView()
        {
            InitializeComponent();
            InitializeLocationBox();

            // Construct Model
            Model = new SweeperModel(this, locationBox.Text);

        }

        private void InitializeLocationBox()
        {
            // Populate the location combobox
            locationBox.Items.Add(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));
            locationBox.Items.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));

            foreach (var item in DriveInfo.GetDrives())
            {
                locationBox.Items.Add(item);
            }
            locationBox.Items.Add("<Select Folder...>");
            locationBox.SelectedIndex = 0;
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            sortWorker.RunWorkerAsync();
        }

        private void Sweeper_Load(object sender, EventArgs e)
        {
            nodeTreeBuilder.RunWorkerAsync();
        }

        private void locationBox_TextUpdate(object sender, EventArgs e)
        {
            onLocatonChanged();
        }

        private void onLocatonChanged()
        {
            if (Model != null && Directory.Exists(locationBox.Text))
            {
                Model.SelectedLocation = locationBox.Text;
                nodeTreeBuilder.RunWorkerAsync();
            }
        }

        internal void UpdateTreeView(TreeNode dummyParentNode)
        {
            Invoke(() =>
            {
                treeView.Nodes.Clear();
                foreach (TreeNode item in dummyParentNode.Nodes)
                {
                    treeView.Nodes.Add(item);
                }
            });
        }

        private void locationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            onLocatonChanged();
        }

        public void setStatus(string status)
        {
            Invoke(() =>
            {
                labelStatus.Text = status;
            });
        }

        private void searchWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BackgroundWorker? backgroundWorker = sender as BackgroundWorker;
            if (backgroundWorker == null) return;
            Model.onLocationChanged(backgroundWorker);
        }

        private void searchWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            updateProgress(e);
        }

        private void updateProgress(ProgressChangedEventArgs e)
        {
            Invoke(() =>
            {
                progressBar.Value = e.ProgressPercentage;
            });
        }

        private void searchWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            setReady();
        }

        private void setReady()
        {
            setStatus("Ready");
        }

        private void extensionsView_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            FileInfo file = new FileInfo(Model.SelectedLocation + "\\" + e.Node.FullPath);
            addExtensionFromFile(file);
        }

        private void addExtensionFromFile(FileInfo file)
        {
            if (Model.Extensions.TryAdd(file.Extension, extensionAsPath(file.Extension)))
            {
                addOrUpdateExtension(file.Extension, extensionAsPath(file.Extension));
            }
        }

        private string extensionAsPath(string extension)
        {
            if (extension.StartsWith("."))
            {
                return extension.Replace(".", "/");
            }
            else if (extension.StartsWith("/"))
            {
                return extension;
            }
            else return "/" + extension;
        }

        private void extensionViewContextMenu_Opening(object sender, CancelEventArgs e)
        {
            bool selected = extensionsView.SelectedItems.Count > 0;
            editToolStripMenuItem.Enabled = selected;
            deleteToolStripMenuItem.Enabled = selected;
        }

        internal void addOrUpdateExtension(string extension, string path)
        {
            if (Model.Extensions.ContainsKey(extension))
            {
                Model.Extensions[extension] = path;
                ListViewItem? item = extensionsView.FindItemWithText(extension);
                if (item == null)
                {
                    item = new ListViewItem(extension);
                    item.SubItems.Add(extensionAsPath(path));
                    extensionsView.Items.Add(item);
                }
                else
                {
                    item.SubItems[1].Text = path;
                }
            }
            else
            {
                Model.Extensions.Add(extension, path);
                ListViewItem item = new ListViewItem(extension);
                item.SubItems.Add(extensionAsPath(path));
                extensionsView.Items.Add(item);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in extensionsView.SelectedItems)
            {
                Model.Extensions.Remove(item.Text);
                extensionsView.Items.Remove(item);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExtensionDialog extensionDialog = new ExtensionDialog(this, extensionsView.SelectedItems[0].Text,
                extensionsView.SelectedItems[0].SubItems[1].Text, true);
            extensionDialog.ShowDialog();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExtensionDialog extensionDialog = new ExtensionDialog(this);
            extensionDialog.ShowDialog();
        }

        private void subfoldersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Model.IncludeSubfolders = subfoldersCheckBox.Checked;
        }

        private void deleteEmptyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Model.DeleteEmptyFolders = deleteEmptyCheckBox.Checked;
        }

        private void directoryCacheWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker? backgroundWorker = sender as BackgroundWorker;
            if (backgroundWorker == null) return;
            Model.beginSort(backgroundWorker);
        }

        private void sortWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            updateProgress(e);
        }

        private void sortWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            nodeTreeBuilder.RunWorkerAsync();
        }
    }
}
