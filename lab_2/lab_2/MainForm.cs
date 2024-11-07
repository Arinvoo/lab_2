using System;
using System.Windows.Forms;

namespace lab_2
{

    public partial class MainForm : Form
    {
        private readonly ITrackFactory _trackFactory;

        public MainForm()
        {
            InitializeComponent();
            _trackFactory = new ShortDistanceTrackFactory();
        }

        private void btnCreateRace_Click(object sender, EventArgs e)
        {
            ITrack track = _trackFactory.CreateTrack();
            IRunner runner = _trackFactory.CreateRunner();

            lblTrackType.Text = $"Track: {track.GetTrackType()}";
            lblRunnerType.Text = $"Runner: {runner.GetRunnerType()}";
        }
    }
}
