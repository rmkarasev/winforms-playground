using DevExpress.LookAndFeel;
using DevExpress.XtraBars;

namespace winforms_playground;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        UserLookAndFeel.Default.SetFlatStyle();
        UserLookAndFeel.Default.UseWindowsXPTheme = true;
        BarAndDockingController.Default.LookAndFeel.SetSkinStyle(SkinStyle.WXICompact);

        Application.Run(new Form1());
    }    
}