namespace FormDataExchange
{
    public partial class AuthForm : Form
    {
        private const string USERNAME = "lol";
        private const string PASSWORD = "lol";

        private SettingsForm m_settingsForm;

        public AuthForm()
        {
            InitializeComponent();

            m_settingsForm = new SettingsForm();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == USERNAME && textBoxPassowrd.Text == PASSWORD)
            {
                this.Hide();
                m_settingsForm.ShowDialog();
                this.Close();
            }
        }
    }
}
