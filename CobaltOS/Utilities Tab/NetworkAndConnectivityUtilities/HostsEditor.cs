namespace CobaltOS
{
    public static class HostsEditor
    {
        public static void EditHostsFile()
        {

        }
    }

    public partial class CobaltOS
    {
        public void HostsFileButton_Click(object sender, EventArgs e)
        {
            HostsEditor.EditHostsFile();
        }
    }
}