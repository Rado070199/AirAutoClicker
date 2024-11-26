using AirAutoClicker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirAutoClicker.Repositories
{
    public interface IJsonSettingsRepository
    {
        JsonSettingsModel GetJsonSettingsModel();
    }
}
