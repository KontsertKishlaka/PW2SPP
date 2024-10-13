namespace PW2SPP;

public partial class ReadWriteFilesForm : Form
{
    public string TextDirPath { get; private set; } = @"C:\Users\vlad\Desktop\Study\Subjets\OAiP_(C#)\CsharpSystemProgrammingPracticum\PW2SPP\TextFilesDir\";
    public string FilePath { get; private set; }

    public ReadWriteFilesForm() => InitializeComponent();

    private void FormLoad(object sender, EventArgs e)
    {
        textBox1.Multiline = true;
        textBox1.Clear();
        textBox1.Size = new(1238, 538);

        OpenButton.Text = "Открыть";
        OpenButton.TabIndex = 0;

        SaveButton.Text = "Сохранить";

        Text = "Здесь кодировка Unicode";
        FilePath = TextDirPath + @"ExampleTextFile1.txt";
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        try
        {
            StreamWriter writer = new(FilePath, false);

            writer.Write(textBox1.Text);
            writer.Close();

            File.WriteAllText(TextDirPath + @"TempFile1.tmp",
                textBox1.Text);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }

    private void OpenButton_Click(object sender, EventArgs e)
    {
        try
        {
            StreamReader reader = new(FilePath);

            textBox1.Text = reader.ReadToEnd();
            reader.Close();
        }
        catch (FileNotFoundException exception)
        {
            MessageBox.Show(exception.Message + "\n" + "Нет такого файла", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message, "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}