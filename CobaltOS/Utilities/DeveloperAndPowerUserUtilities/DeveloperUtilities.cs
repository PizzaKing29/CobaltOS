namespace CobaltOS
{
    public static class DeveloperUtilities
    {
        public static void PortScanner()
        {

        }

        public static void RegistryEditor()
        {
            
        }
    }

    public partial class Form1
    {
        public void PortScannerButton_Click(object sender, EventArgs e)
        {
            DeveloperUtilities.PortScanner();
        }

        public void RegistryEditorButton_Click(object sender, EventArgs e)
        {
            DeveloperUtilities.RegistryEditor();
        }
    }
}