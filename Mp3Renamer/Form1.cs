using System.Diagnostics;

namespace Mp3Renamer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void folderPickerButton_Click(object sender, EventArgs e)
        {
            if (folderPicker.ShowDialog() == DialogResult.OK)
            {
                folderPathTextBox.Text = folderPicker.SelectedPath;
                startRenamingButton.Enabled = true;
            }
        }

        private string SanitizeFileName(string name)
        {
            foreach (char invalidCharacter in Path.GetInvalidFileNameChars())
            {
                name = name.Replace(invalidCharacter, '_');
            }
            return name;
        }

        private int RenameFilesInFolder(string folderPath)
        {
            int filesRenamedCount = 0;

            string[] files = Directory.GetFiles(folderPath, "*.mp3");

            foreach (var file in files)
            {
                try
                {
                    var tfile = TagLib.File.Create(file);

                    // Only proceed if both Artist and Title exist
                    string artist = tfile.Tag.FirstAlbumArtist ?? tfile.Tag.FirstPerformer;
                    string title = tfile.Tag.Title;

                    if (string.IsNullOrEmpty(artist) || string.IsNullOrEmpty(title))
                    {
                        // Skip this file because it lacks required tags
                        continue;
                    }

                    // Build the new filename
                    string newFileName = $"{artist} - {title}.mp3";
                    string newPath = Path.Combine(folderPath, SanitizeFileName(newFileName));

                    // Rename/move the file if it doesn't exist already
                    // Prevents overwriting existing files
                    if (!File.Exists(newPath))
                    {
                        File.Move(file, newPath);
                        filesRenamedCount++;
                    }
                }
                catch
                {
                    // Skip any files that cause errors (e.g., not a valid MP3)
                    continue;
                }
            }

            return filesRenamedCount;
        }

        private void startRenamingButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                UseWaitCursor = true;

                int count = RenameFilesInFolder(folderPathTextBox.Text);

                MessageBox.Show(
                    $"Renamed {count} MP3 files successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Something went wrong:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                UseWaitCursor = false;
            }
        }
    }
}
