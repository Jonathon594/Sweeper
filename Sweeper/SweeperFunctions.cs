using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweeper
{
    public class SweeperFunctions
    {
        public static int DirectoriesToProcess { get; set; }
        public static int DirectoriesProcessed { get; set; }

        public static List<FileInfo> CachedFiles { get; set; } = new List<FileInfo>();
        public static List<FileInfo> CachedRootFiles { get; set; } = new List<FileInfo>();

        internal static EnumerationOptions NonRecursive = new EnumerationOptions() { IgnoreInaccessible = true };
        internal static EnumerationOptions Recursive = new EnumerationOptions() { IgnoreInaccessible = true, RecurseSubdirectories = true };

        public static void beginRecursiveSearch(BackgroundWorker backgroundWorker, DirectoryInfo directory, TreeNode? dummyParentNode = null)
        {
            CachedFiles.Clear();
            DirectoriesProcessed = 0;
            DirectoriesToProcess = directory.GetDirectories("*", Recursive).Length;
            processDirectoryRecursively(backgroundWorker, dummyParentNode, directory, true);
        }

        public static void processDirectoryRecursively(BackgroundWorker backgroundWorker, TreeNode? parent, DirectoryInfo directory, bool root = false)
        {
            DirectoryInfo[] directoryInfos = directory.GetDirectories("*", NonRecursive);

            foreach (FileInfo file in directory.GetFiles("*", NonRecursive))
            {
                CachedFiles.Add(file);
                if(root) CachedRootFiles.Add(file);
                if(parent != null) parent.Nodes.Add(file.Name); 
            }

            if (parent != null)
            {
                foreach (var item in directory.GetFiles("*", NonRecursive))
                {
                    parent.Nodes.Add(item.Name);
                }
            }

            foreach (DirectoryInfo directoryInfo in directoryInfos)
            {
                TreeNode? node = null;
                if (parent != null)
                {
                    node = new TreeNode(directoryInfo.Name);
                    parent.Nodes.Add(node);
                }
                processDirectoryRecursively(backgroundWorker, node, directoryInfo);
            }

            DirectoriesProcessed++;
            backgroundWorker.ReportProgress((int)(DirectoriesProcessed / (double)DirectoriesToProcess * 100));
        }

        internal static void sort(SweeperModel model, BackgroundWorker backgroundWorker)
        {
            List<FileInfo> files;
            if (model.IncludeSubfolders) files = CachedFiles;
            else files = CachedRootFiles;

            int fileCount = files.Count;
            int filesProcessed = 0;

            foreach (FileInfo item in files)
            {
                DirectoryInfo? sourceDirectory = item.Directory;

                if (!model.Extensions.ContainsKey(item.Extension)) continue;

                DirectoryInfo directoryInfo = Directory.CreateDirectory(model.SelectedLocation + model.Extensions[item.Extension]);
                string destFileName =  directoryInfo.FullName + "\\" + item.Name;
                if (File.Exists(destFileName)) destFileName = getNextFreeFilename(directoryInfo, item);
                item.MoveTo(destFileName, false);

                if (model.DeleteEmptyFolders && sourceDirectory != null)
                {
                    if (sourceDirectory.GetFiles().Length != 0) continue;
                    sourceDirectory.Delete();
                }

                filesProcessed++;
            }

            backgroundWorker.ReportProgress((int)((double)filesProcessed / fileCount * 100.0));
        }

        private static string getNextFreeFilename(DirectoryInfo directoryInfo, FileInfo file)
        {
            int count = 1;
            string nameInc = getIncrementalName(file, count);
            while (File.Exists(directoryInfo.FullName + "\\" + nameInc))
            {
                count++;
                nameInc = getIncrementalName(file, count);
            }

            return directoryInfo.FullName + "\\" + nameInc;
        }

        private static string getIncrementalName(FileInfo file, int count)
        {
            return file.Name.Replace(file.Extension, "") + " (" + count + ")" + file.Extension;
        }
    }
}
