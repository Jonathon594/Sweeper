using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweeper
{
    public class SweeperModel
    {
        public SweeperControlView ControlView { get; set; }
        public string SelectedLocation { get; set; }

        public bool IncludeSubfolders { get; set; }

        public bool DeleteEmptyFolders { get; set; }

        public Dictionary<string, string> Extensions { get; set; } = new Dictionary<string, string>();

        public SweeperModel(SweeperControlView controlView, string selectedLocation)
        {
            ControlView = controlView;
            SelectedLocation = selectedLocation;
        }

        public void onLocationChanged(BackgroundWorker backgroundWorker)
        {
            ControlView.setStatus("Searching...");
            DirectoryInfo directory = new DirectoryInfo(SelectedLocation);
            TreeNode dummyParentNode = new TreeNode(directory.Name);
            SweeperFunctions.beginRecursiveSearch(backgroundWorker, directory, dummyParentNode);
            ControlView.UpdateTreeView(dummyParentNode);
        }

        internal void beginSort(BackgroundWorker backgroundWorker)
        {
            ControlView.setStatus("Sorting...");
            DirectoryInfo directory = new DirectoryInfo(SelectedLocation);
            SweeperFunctions.beginRecursiveSearch(backgroundWorker, directory);
            SweeperFunctions.sort(this, backgroundWorker);
        }
    }
}
