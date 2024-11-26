using AirAutoClicker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirAutoClicker.Forms
{
    public interface IMainForm
    {
        //Properties - Fields
        string DigitMark { get; set; }
        int DigitMilliseconds { get; set; }
        bool DigitOnOff { get; set; }
        string LetterMark { get; set; }
        int LetterMilliseconds { get; set; }
        bool LetterOnOff { get; set; }
        string MouseButton { get; set; }
        int MouseMilliseconds { get; set; }
        bool MouseOnOff { get; set; }
        int StartTime { get; set; }

        //Events
        event EventHandler btnStartClickEvent;
        event EventHandler btnStopClickEvent;
        event EventHandler btnSaveSettingsClickEvent;

        //Methods
        void SetDefaultSettings(JsonSettingsModel jsonSettingsModel);
    }
}
