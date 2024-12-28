using FileCopy.Wif.Targets;
using Microsoft.Extensions.Options;

namespace FileCopy.Wif
{
    public partial class Form1 : Form
    {
        private readonly IArtworkTargetService _artworkTargetService;
        private readonly ArtworkSettingsOptions _options;

        public Form1(IArtworkTargetService artworkTargetService, IOptions<ArtworkSettingsOptions> options)
        {
            InitializeComponent();
            _artworkTargetService = artworkTargetService;
            _options = options.Value;
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                Title = "Selecteer een bestand",
                InitialDirectory = _options.SourceLocation, // Stel het initiële pad in
                Filter = "Image files (*.jpg)|*.jpg|All files (*.*)|*.*" // Filter op bestandstypen
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                UpdateFileAsync(fileName).ConfigureAwait(false);
            }
        }

        private async Task UpdateFileAsync(string fileName)
        {
            try
            {
                await _artworkTargetService.UpdateAsync(fileName);
                MessageBox.Show($"{fileName} copied");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed: {ex.Message}");
            }
        }
    }
}