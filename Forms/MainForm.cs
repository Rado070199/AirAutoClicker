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
            this.Text += " " + Assembly.GetExecutingAssembly().GetName().Version;
        }

        private void HookingUpEvents()
        {
            buttonStart.Click += (sender, e) => btnStartClickEvent?.Invoke(sender, e);
            buttonStop.Click += (sender, e) => btnStopClickEvent?.Invoke(sender, e);
            buttonSaveSettings.Click += (sender, e) => btnSaveSettingsClickEvent?.Invoke(sender, e);
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
        public int StartTime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }

        //Events
        public event EventHandler btnStartClickEvent;
        public event EventHandler btnStopClickEvent;
        public event EventHandler btnSaveSettingsClickEvent;

        //Methods
        public void SetDefaultSettings(JsonSettingsModel jsonSettingsModel)
        {
            DigitMark = jsonSettingsModel.MainFormJsonSettings.DigitMark;
            DigitMilliseconds = jsonSettingsModel.MainFormJsonSettings.DigitMilliseconds;
            textBoxDigitMiliseconds.Text = DigitMilliseconds.ToString();
            DigitOnOff = jsonSettingsModel.MainFormJsonSettings.DigitOnOff;
            LetterMark = jsonSettingsModel.MainFormJsonSettings.LetterMark;
            LetterMilliseconds = jsonSettingsModel.MainFormJsonSettings.LetterMilliseconds;
            LetterOnOff = jsonSettingsModel.MainFormJsonSettings.LetterOnOff;
            MouseButton = jsonSettingsModel.MainFormJsonSettings.MouseButton;
            MouseMilliseconds = jsonSettingsModel.MainFormJsonSettings.MouseMilliseconds;
            MouseOnOff = jsonSettingsModel.MainFormJsonSettings.MouseOnOff;
            StartTime = jsonSettingsModel.MainFormJsonSettings.StartTime;
        }
    }
}
