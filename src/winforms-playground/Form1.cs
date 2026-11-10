namespace winforms_playground;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void simpleButton1_Click(object sender, EventArgs e)
    {
        contextMenuStrip1.Show(Cursor.Position);
    }

    private void simpleButton2_Click(object sender, EventArgs e)
    {
        popupMenu1.ShowPopup(Cursor.Position);
    }
}
