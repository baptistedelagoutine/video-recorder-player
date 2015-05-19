using System.Windows.Forms;

namespace VideoPicture
{
    public partial class UnlockForm : Form
    {
        public UnlockForm()
        {
            InitializeComponent();
        }

        private void KeyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && KeyTextBox.Text == "889094")
            {
                Properties.Settings.Default.Unlocked = true;
                Properties.Settings.Default.Save();
                this.Close();
            }
        }
    }
}
