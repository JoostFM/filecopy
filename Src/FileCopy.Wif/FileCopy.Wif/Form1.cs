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
        private readonly INowPlayingTargetService _nowPlayingTargetService;
        private readonly ITop100_2024DataService _googleSheetsService;
        private readonly ArtworkSettingsOptions _options;
        private bool _isPopulatingListBox = false;


        public Form1(IArtworkTargetService artworkTargetService,
            INowPlayingTargetService nowPlayingTargetService,
            ITop100_2024DataService googleSheetsService,
            IOptions<ArtworkSettingsOptions> options)
        {
            InitializeComponent();
            _artworkTargetService = artworkTargetService;
            _nowPlayingTargetService = nowPlayingTargetService;
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
                LblStatus.ForeColor = Color.Blue;
                LblStatus.BackColor = SystemColors.Control;
            }
            catch (Exception ex)
            {
                LblStatus.Text = $"{ex.Message}";
                LblStatus.ForeColor = Color.White;
                LblStatus.BackColor = Color.Red;
            }

            await _nowPlayingTargetService.UpdateAsync(fileName);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isPopulatingListBox) return;
            if (listBox1.SelectedItem is TrackData selectedTrack)
            {
                var fileName = $"{selectedTrack.Artist} - {selectedTrack.Title}";
                TxtlblArtistTitleValue.Text = fileName;

                var exists = await _artworkTargetService.CheckAsync(fileName);

                LblStatus.Text = exists ? "Exists" : "--- MISSING TRACK ---";
                LblStatus.ForeColor = exists ? Color.Green : Color.White;
                LblStatus.BackColor = exists ? SystemColors.Control : Color.Red;
            }
        }
    }
}
