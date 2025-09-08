namespace CobaltOS
{
    public static class BootLogs
    {
        public static void BootLogViewer()
        {

        }
    }

    public partial class CobaltOS
    {
        public void BootLogsButton_Click(object sender, EventArgs e)
        {
            BootLogs.BootLogViewer();
        }
    }
}