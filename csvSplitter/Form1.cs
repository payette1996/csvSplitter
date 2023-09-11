using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace csvSplitter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileBtn_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                filePathTextBox.Text = filePath;

                string fileName = Path.GetFileName(filePath);
                fileNameTextBox.Text = fileName;

                string[] lines = File.ReadAllLines(filePath);
                int rowCount = lines.Length;
                int colCount = lines[0].Split(',').Length;

                colNumeric.Value = colCount;
                rowNumeric.Value = rowCount;

                string? directoryPath = Path.GetDirectoryName(filePath);
                outputLocationTextBox.Text = directoryPath;

                int maxRowsPerFile = (int)maxRowsNumeric.Value;
                int fileCount = (int)Math.Ceiling(rowNumeric.Value / maxRowsNumeric.Value);
                filesGeneratedNumeric.Value = fileCount;
            }
        }

        private void splitBtn_Click(object sender, EventArgs e)
        {
            string inputFilePath = filePathTextBox.Text;

            if (File.Exists(inputFilePath))
            {
                // Read all lines from the input CSV file.
                string[] allLines = File.ReadAllLines(inputFilePath);

                // Check if there's at least one row in the file.
                if (allLines.Length > 0)
                {
                    // Create a directory to store the split CSV files.
                    string outputDirectory = Path.Combine(outputLocationTextBox.Text, "output");

                    // Ensure the output directory exists; if not, create it.
                    Directory.CreateDirectory(outputDirectory);

                    int maxRows = (int)maxRowsNumeric.Value;

                    // Split the rest of the rows into chunks of X (maxRows) rows each.
                    List<string[]> chunks = new List<string[]>();
                    for (int i = 1; i < allLines.Length; i += maxRows)
                    {
                        string[] chunk = allLines.Skip(i).Take(maxRows).ToArray();
                        chunks.Add(chunk);
                    }

                    // Check if the headerCheckBox is checked.
                    bool addHeader = headerCheckBox.Checked;

                    for (int i = 0; i < chunks.Count; i++)
                    {
                        string outputFileName = Path.Combine(outputDirectory, $"output_{i}.csv");

                        // Add the header to all files when the checkbox is checked.
                        if (addHeader || i == 0)
                        {
                            File.WriteAllLines(outputFileName, new[] { allLines[0] }.Concat(chunks[i]));
                        }
                        else
                        {
                            File.WriteAllLines(outputFileName, chunks[i]);
                        }
                    }
                }
            }

            MessageBox.Show("Operation completed");
        }



        private void maxRowsNumeric_ValueChanged(object sender, EventArgs e)
        {
            int maxRowsPerFile = (int)maxRowsNumeric.Value;
            int fileCount = (int)Math.Ceiling(rowNumeric.Value / maxRowsNumeric.Value);
            filesGeneratedNumeric.Value = fileCount;
        }
    }
}