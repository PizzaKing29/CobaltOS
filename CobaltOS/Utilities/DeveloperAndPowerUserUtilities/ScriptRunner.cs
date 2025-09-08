namespace CobaltOS
{
    public static class ScriptRunner
    {
        public static void RunScripts()
        {
            ScriptRunnerForm scriptRunner = new ScriptRunnerForm();
            scriptRunner.Show();
        }
    }

    public partial class CobaltOS
    {
        public void ScriptRunnerButton_Click(object sender, EventArgs e)
        {
            ScriptRunner.RunScripts();
        }
    }
}