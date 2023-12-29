

using Microsoft.Extensions.Configuration;
using System.Configuration.Internal;

namespace FileCopy.Wif
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            string sourcefolder = Program.Configuration["sourcefolder"];
            string targetfolder = Program.Configuration["targetfolder"];
            string newfilename = Program.Configuration["newfilename"];
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Selecteer een bestand";
            openFileDialog.InitialDirectory = sourcefolder; // Stel het initiële pad in
            openFileDialog.Filter = "Image files (*.jpg)|*.jpg|All files (*.*)|*.*"; // Filter op bestandstypen

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialog.FileName;
                    string newfilepath = Path.Combine(targetfolder, newfilename);
                    File.Copy(filePath, newfilepath, true);
                    MessageBox.Show($"{filePath} copied to {newfilepath}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed: {ex.Message}");
                }
            }
        }
    }
}