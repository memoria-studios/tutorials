namespace FormDataExchange
{
    public partial class MainForm : Form
    {
        public static Action<MyCustomDataPackage> DataChangedEvent;
        
        private AuthForm m_authForm;
        private MyCustomDataPackage m_dataPackage;

        public MainForm()
        {
            InitializeComponent();

            SettingsForm.DataChangedEvent += OnSettingsDataChanged;

            m_authForm = new AuthForm(); // We instantiate new AuthForm but we are not opening it yet. We just allocate a memory for it so it's ready to be shown later.
            m_dataPackage = new MyCustomDataPackage(); // We instantiate our data package that we will use to exchange the data between multiple forms
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            m_dataPackage.ApplicationName = comboBoxApp.Text; // We update data inside our data package
            DataChangedEvent?.Invoke(m_dataPackage); // We trigger the event with our data package, so whoever is listening to our event will get our newly updated data package

            m_authForm.ShowDialog();
        }

        private void OnSettingsDataChanged(MyCustomDataPackage package)
        {
            textBoxTheme.Text = package.Theme;
        }
    }
}
