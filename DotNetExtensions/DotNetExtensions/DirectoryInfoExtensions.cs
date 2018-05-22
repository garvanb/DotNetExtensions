using System.IO;

namespace DotNetExtensions
{
    public static class DirectoryInfoExtensions
    {
        /// <summary>
        /// Deletes all files in the directory
        /// </summary>
        /// <param name="directoryInfo"></param>
        public static void DeleteFiles(this DirectoryInfo directoryInfo)
        {
            if (directoryInfo.Exists)
            {
                FileInfo[] files = directoryInfo.GetFiles();
                foreach (FileInfo file in files)
                {
                    file.Delete();
                }
            }
        }

        /// <summary>
        /// Creates the directory if it doesn't already exist
        /// </summary>
        public static void CreateIfNeeded(this DirectoryInfo directoryInfo)
        {
            if (!directoryInfo.Exists)
                directoryInfo.Create();
        }
    }
}
