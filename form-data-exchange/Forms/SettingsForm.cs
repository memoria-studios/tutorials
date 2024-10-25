namespace FormDataExchange
{
    public partial class SettingsForm : Form
    {
        public static Action<MyCustomDataPackage> DataChanged;

        private MyCustomDataPackage m_dataPackage;

        public SettingsForm()
        {
            InitializeComponent();

            MainForm.DataChanged += OnDataChanged;
        }

        private void SettingsForm_Activated(object sender, EventArgs e)
        {
            var appName = m_dataPackage.ApplicationName; // Let's pull app name that was selected on the MainForm.
            labelAppName.Text = appName;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            m_dataPackage.Theme = comboBoxTheme.Text; // We add our selected theme to the data package so we can send it back later.

            DataChanged?.Invoke(m_dataPackage); // We are triggering our event and sending our Data Package to anyone who is listening to this event.

            this.Close();
        }

        private void OnDataChanged(MyCustomDataPackage package)
        {
            m_dataPackage = package;
        }

        
    }
}
