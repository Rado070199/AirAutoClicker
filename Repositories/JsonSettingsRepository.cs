using AirAutoClicker.Helpers;
using AirAutoClicker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AirAutoClicker.Repositories
{
    public class JsonSettingsRepository : IJsonSettingsRepository
    {
        public JsonSettingsModel GetJsonSettingsModel()
        {
            try
            {
                string jsonString = File.ReadAllText("settings.json");
                JsonSettingsModel jsonSettingsModel = JsonSerializer.Deserialize<JsonSettingsModel>(jsonString);

                return jsonSettingsModel;
            }
            catch (Exception ex)
            {
                LogsHelper.LogError(ex);
                throw;
            }
        }
    }
}
