namespace CobaltOS
{
    public static class BootLogs
    {
        public static void BootLogViewer()
        {

        }
    }

    public partial class Form1
    {
        public void BootLogsButton_Click(object sender, EventArgs e)
        {
            BootLogs.BootLogViewer();
        }
    }
}