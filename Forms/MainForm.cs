using AirAutoClicker.Helpers;
using AirAutoClicker.Models;
using System.Reflection;

namespace AirAutoClicker.Forms
{
    public partial class MainForm : Form, IMainForm
    {
        //Fields
        private string _digitMark;
        private int _digitMilliseconds;
        private bool _digitOnOff;
        private string _letterMark;
        private int _letterMilliseconds;
        private bool _letterOnOff;
        private string _mouseButton;
        private int _mouseMilliseconds;
        private bool _mouseOnOff;
        private int _startTime;

        //Constructor
        public MainForm()
        {
            InitializeComponent();
            LoadSettingsForm();
            HookingUpEvents();
        }

        private void LoadSettingsForm()
        {
            try
            {
                this.Text += " " + Assembly.GetExecutingAssembly().GetName().Version;
            }
            catch (Exception ex)
            {
                LogsHelper.LogError(ex);
                throw;
            }
            this.Text += " " + Assembly.GetExecutingAssembly().GetName().Version;
        }

        private void HookingUpEvents()
        {
            try
            {
                buttonStart.Click += (sender, e) => btnStartClickEvent?.Invoke(sender, e);
                buttonStop.Click += (sender, e) => btnStopClickEvent?.Invoke(sender, e);
                buttonSaveSettings.Click += (sender, e) => btnSaveSettingsClickEvent?.Invoke(sender, e);
            }
            catch (Exception ex)
            {
                LogsHelper.LogError(ex);
                throw;
            }
        }


        //Properties
        public string DigitMark
        {
            get { return _digitMark; }
            set { _digitMark = value; }
        }
        public int DigitMilliseconds
        {
            get { return _digitMilliseconds; }
            set { _digitMilliseconds = value; }
        }
        public bool DigitOnOff
        {
            get { return _digitOnOff; }
            set { _digitOnOff = value; }
        }
        public string LetterMark
        {
            get { return _letterMark; }
            set { _letterMark = value; }
        }
        public int LetterMilliseconds
        {
            get { return _letterMilliseconds; }
            set { _letterMilliseconds = value; }
        }
        public bool LetterOnOff
        {
            get { return _letterOnOff; }
            set { _letterOnOff = value; }
        }
        public string MouseButton
        {
            get { return _mouseButton; }
            set { _mouseButton = value; }
        }
        public int MouseMilliseconds
        {
            get { return _mouseMilliseconds; }
            set { _mouseMilliseconds = value; }
        }
        public bool MouseOnOff
        {
            get { return _mouseOnOff; }
            set { _mouseOnOff = value; }
        }

        //Events
        public event EventHandler btnStartClickEvent;
        public event EventHandler btnStopClickEvent;
        public event EventHandler btnSaveSettingsClickEvent;

        //Methods
        public void SetDefaultSettings(JsonSettingsModel jsonSettingsModel)
        {
            try
            {
                DigitMark = jsonSettingsModel.MainFormJsonSettings.DigitMark;
                comboBoxDigitMark.Text = DigitMark;
                DigitMilliseconds = jsonSettingsModel.MainFormJsonSettings.DigitMilliseconds;
                textBoxDigitMiliseconds.Text = DigitMilliseconds.ToString();
                DigitOnOff = jsonSettingsModel.MainFormJsonSettings.DigitOnOff;
                checkBoxDigitOnOff.Checked = DigitOnOff;

                LetterMark = jsonSettingsModel.MainFormJsonSettings.LetterMark;
                comboBoxLetterMark.Text = LetterMark;
                LetterMilliseconds = jsonSettingsModel.MainFormJsonSettings.LetterMilliseconds;
                textBoxLetterMilliseconds.Text = LetterMilliseconds.ToString();
                LetterOnOff = jsonSettingsModel.MainFormJsonSettings.LetterOnOff;
                checkBoxLetterOnOff.Checked = LetterOnOff;

                MouseButton = jsonSettingsModel.MainFormJsonSettings.MouseButton;
                comboBoxMouseButton.Text = MouseButton;
                MouseMilliseconds = jsonSettingsModel.MainFormJsonSettings.MouseMilliseconds;
                textBoxMouseMilliseconds.Text = MouseMilliseconds.ToString();
                MouseOnOff = jsonSettingsModel.MainFormJsonSettings.MouseOnOff;
                checkBoxMouseOnOff.Checked = MouseOnOff;
            }
            catch (Exception ex)
            {
                LogsHelper.LogError(ex);
                throw;
            }
        }
    }
}
