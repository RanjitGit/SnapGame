using Snap.Core.Factories;
using Snap.Core.Interfaces;

namespace Snap.UI
{
    public partial class Snap : Form, ISnapUI
    {
        private IGameManager _gameManager;
        private System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer();
        
        public int CommonCount { get => int.Parse(lblCommonCount.Text); set => lblCommonCount.Text = value.ToString().PadLeft(3,'0'); }
        public int Player1Count { get => int.Parse(lblPlayer1Count.Text); set => lblPlayer1Count.Text = value.ToString().PadLeft(3, '0'); }
        public int Player2Count { get => int.Parse(lblPlayer2Count.Text); set => lblPlayer2Count.Text = value.ToString().PadLeft(3, '0'); }
        public int CurrentRun { get => int.Parse(lblCurrentRun.Text); set => lblCurrentRun.Text = value.ToString().PadLeft(3, '0'); }
        public string CurrentCard { set => pbCurrentCard.Image = string.IsNullOrEmpty(value) ? null : Image.FromFile(value); }
        public string PreviousCard { set => pbPrevCard.Image = string.IsNullOrEmpty(value) ? null : Image.FromFile(value); }
        
        public Snap()
        {
            InitializeComponent();
            Input popup = new();
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                _gameManager = GameManagerFactory.Instance.CreateSnapGameManager(this);
                _gameManager.Init(popup.SelectedOption);
            }
            else
                Environment.Exit(0);
        }

        public void DisplayMessageBox(string message)
        {
            _timer.Stop();
            var result = MessageBox.Show(message, "Information");
            if (result == DialogResult.OK)
                _timer.Start();
        }

        private void btnSuffle_Click(object sender, EventArgs e)
        {
            _gameManager.Suffle();
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            _gameManager.Deal();
        }

        private void btnAutoDeal_Click(object sender, EventArgs e)
        {
            if(((Button)sender).Text == "Stop")
            {
                _timer.Enabled = false;
                _timer.Stop();
                btnAutoDeal.Text = "Auto Deal";
            }
            else
            {
                _timer.Tick += new EventHandler((o, e) =>
                {
                    if (_gameManager.CommonPile.Count > 0)
                        _gameManager.Deal();
                    else
                        _timer.Stop();
                });
                _timer.Interval = 1000;
                _timer.Start();
                btnAutoDeal.Text = "Stop";
            }            
        }
    }
}