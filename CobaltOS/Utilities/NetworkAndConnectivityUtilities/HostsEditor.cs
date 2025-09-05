namespace CobaltOS
{
    public static class HostsEditor
    {
        public static void EditHostsFile()
        {

        }
    }

    public partial class Form1
    {
        public void HostsFileButton_Click(object sender, EventArgs e)
        {
            HostsEditor.EditHostsFile();
        }
    }
}