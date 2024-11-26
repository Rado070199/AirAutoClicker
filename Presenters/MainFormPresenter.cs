using AirAutoClicker.Forms;
using AirAutoClicker.Models;
using AirAutoClicker.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirAutoClicker.Presenters
{
    public class MainFormPresenter
    {
        IMainForm _mainForm;
        IJsonSettingsRepository _jsonSettingsRepository;
        private JsonSettingsModel _jsonSettingsModel;
        public MainFormPresenter(IMainForm mainForm, IJsonSettingsRepository jsonSettingsRepository) 
        {
            _mainForm = mainForm;
            _jsonSettingsRepository = jsonSettingsRepository;
            LoadData();
        }

        public void LoadData()
        {
            _jsonSettingsModel = _jsonSettingsRepository.GetJsonSettingsModel();
            _mainForm.SetDefaultSettings(_jsonSettingsModel);
        }
    }
}
