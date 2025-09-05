namespace CobaltOS
{
    public static class NetworkAndInfo
    {
        public static void QuickIpAndMacInfo()
        {

        }

        public static void InternetSpeedTest()
        {

        }

        public static void QuickNetworkTroubleshooter()
        {

        }
    }

    public partial class Form1
    {
        public void QuickIpButton_Click(object sender, EventArgs e)
        {
            NetworkAndInfo.QuickIpAndMacInfo();
        }

        public void NetworkTestButton_Click(object sender, EventArgs e)
        {
            NetworkAndInfo.InternetSpeedTest();
        }

        public void NetworkHelpButton_Click(object sender, EventArgs e)
        {
            NetworkAndInfo.QuickNetworkTroubleshooter();
        }
    }
}