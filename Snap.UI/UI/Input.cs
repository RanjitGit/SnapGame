using Snap.Core.Model;

namespace Snap.UI
{
    public partial class Input : Form
    {
        public InputData SelectedOption { get; set; }

        public Input()
        {
            InitializeComponent();
            SelectedOption = new InputData() { NoOfDecks = 1, MatchingCondition = MathingConditions.Both};
            txtNoOfDecks.Text = "1";
            rdbBoth.Checked = true;
        }

        private void txtNoOfDecks_TextChanged(object sender, EventArgs e)
        {
            int numberOfDecks;
            if (!string.IsNullOrEmpty(txtNoOfDecks.Text))
                if (int.TryParse(txtNoOfDecks.Text, out numberOfDecks))
                    SelectedOption.NoOfDecks = numberOfDecks;
                else
                {
                    txtNoOfDecks.Text = "1";                    
                    MessageBox.Show("Please enter only numbers", "Information");
                }                    
        }

        private void rdbFaceValue_CheckedChanged(object sender, EventArgs e)
        {
            SelectedOption.MatchingCondition = MathingConditions.FaceValue;
        }

        private void rdbSuit_CheckedChanged(object sender, EventArgs e)
        {
            SelectedOption.MatchingCondition = MathingConditions.SuitOfTheCard;
        }

        private void rdbBoth_CheckedChanged(object sender, EventArgs e)
        {
            SelectedOption.MatchingCondition = MathingConditions.Both;
        }
    }
}
