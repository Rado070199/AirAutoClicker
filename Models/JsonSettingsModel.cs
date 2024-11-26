using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirAutoClicker.Models
{
    public class JsonSettingsModel
    {
        public MainFormJsonSettings MainFormJsonSettings { get; set; }
    }

    public class MainFormJsonSettings
    {
        public string DigitMark { get; set; }
        public int DigitMilliseconds { get; set; }
        public bool DigitOnOff { get; set; }
        public string LetterMark { get; set; }
        public int LetterMilliseconds { get; set; }
        public bool LetterOnOff { get; set; }
        public string MouseButton { get; set; }
        public int MouseMilliseconds { get; set; }
        public bool MouseOnOff { get; set; }
        public int StartTime { get; set; }
    }
}
