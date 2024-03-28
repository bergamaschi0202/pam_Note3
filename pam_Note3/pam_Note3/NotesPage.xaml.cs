namespace pam_Note3;

public partial class NotesPage : ContentPage {

    string path = Path.Combine(FileSystem.AppDataDirectory,"notes.txt");
    string content = "";

    // public object FileEditor { get; private set; }

    public NotesPage()
	{
        InitializeComponent();
        if (File.Exists(path))
        {
            
            FileEditor.Text = File.ReadAllText(path);
        }
	}

    private void saveButton_Clicked(object sender, EventArgs e)
    {
        content = FileEditor.Text;
        File.WriteAllText(path, content);
    }

    private void deletButton_Clicked(object sender, EventArgs e)
    {
        if (File.Exists(path))
        {
            File.Delete(path);
            FileEditor.Text = "";
        }
    }
}