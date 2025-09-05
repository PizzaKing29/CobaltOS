namespace CobaltOS
{
    public static class FileUtilities
    {
        public static void SearchForDupedFiles()
        {

        }

        public static void LargeFileFinder()
        {

        }

        public static void EmptyFolderFinder()
        {

        }

        public static void ToggleProtectedFiles()
        {

        }
    }

    public partial class Form1
    {
        public void SearchDupedFilesButton_Click(object sender, EventArgs e)
        {
            FileUtilities.SearchForDupedFiles();
        }

        public void LargeFileFinderButton_Click(object sender, EventArgs e)
        {
            FileUtilities.LargeFileFinder();
        }

        public void EmptyFolderFinderButton_Click(object sender, EventArgs e)
        {
            FileUtilities.EmptyFolderFinder();
        }

        public void ProtectedFilesButton_Click(object sender, EventArgs e)
        {
            FileUtilities.ToggleProtectedFiles();
        }
    }
}