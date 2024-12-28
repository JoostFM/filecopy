using FileCopy.Wif.Models;
using FileCopy.Wif.Targets;
using FileCopy.Wif.Top100Data;
using Microsoft.Extensions.Options;
using System.IO.Abstractions;

namespace FileCopy.Wif
{
    public partial class Form1 : Form
    {
        private readonly IArtworkTargetService _artworkTargetService;
        private readonly ITop100_2024DataService _googleSheetsService;
        private readonly ArtworkSettingsOptions _options;
        private bool _isPopulatingListBox = false;


        public Form1(IArtworkTargetService artworkTargetService,
            ITop100_2024DataService googleSheetsService,
            IOptions<ArtworkSettingsOptions> options)
        {
            InitializeComponent();
            _artworkTargetService = artworkTargetService;
            _googleSheetsService = googleSheetsService;
            _options = options.Value;
            PopulateListBox();

        }
        private void PopulateListBox()
        {
            _isPopulatingListBox = true;
            listBox1.DataSource = _googleSheetsService.ToList();
            listBox1.DisplayMember = "Description"; // Toon de titel in de ListBox
            listBox1.ValueMember = "Position"; // Gebruik de positie als waarde 
            _isPopulatingListBox = false;
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            UpdateFileAsync(TxtlblArtistTitleValue.Text).ConfigureAwait(false);
        }

        private async Task UpdateFileAsync(string fileName)
        {
            try
            {
                await _artworkTargetService.UpdateAsync(fileName);
                LblStatus.Text = $"{fileName} copied";
                LblStatus.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                LblStatus.Text = $"{ex.Message}";
                LblStatus.ForeColor = Color.Red;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isPopulatingListBox) return;
            if (listBox1.SelectedItem is TrackData selectedTrack) 
            {
                TxtlblArtistTitleValue.Text = $"{selectedTrack.Artist} - {selectedTrack.Title}";
            }
        }
    }
}