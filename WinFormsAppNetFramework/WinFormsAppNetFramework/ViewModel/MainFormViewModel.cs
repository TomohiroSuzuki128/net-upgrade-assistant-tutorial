using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAppNetFramework.Models;
using WinFormsAppNetFramework.Sevices;
using WinFormsAppNetFramework.ExtensionMethods;
using System.Windows.Input;

namespace WinFormsAppNetFramework.ViewModel
{
    public class MainFormViewModel : ViewModelBase
    {
        string labelZipCode = string.Empty;
        public string LabelZipCode
        {
            get { return labelZipCode; }
            set { SetProperty(ref labelZipCode, value); }
        }

        string labelPrefecture = string.Empty;
        public string LabelPrefecture
        {
            get { return labelPrefecture; }
            set { SetProperty(ref labelPrefecture, value); }
        }

        Prefecture selectedPrefecture;
        public Prefecture SelectedPrefecture
        {
            get { return selectedPrefecture; }
            set { SetProperty(ref selectedPrefecture, value); }
        }

        public ObservableCollection<Prefecture> Prefectures { get; set; }


        public ICommand GetAddressCommand { private set; get; }


        IncompatibleAPIs incompatibleAPIs = new IncompatibleAPIs();

        public MainFormViewModel()
        {
            Initialize();
            //CreatePdbGenerator();
        }

        void Initialize()
        {
            Title = "Windows Form (.NET Framwrork アプリ)";
            LabelZipCode = "郵便番号";
            LabelPrefecture = "都道府県";

            Prefectures = new ObservableCollection<Prefecture>();
            Prefectures.Add(Prefecture.Empty);
            Sevices.Prefectures.All().ForEach(x => Prefectures.Add(x));
            SelectedPrefecture = Prefecture.Empty;

            GetAddressCommand = new Command(() => GetAddress("3460024"));
        }

        void GetAddress(string zipCode)
        {
            //StationItems.Clear();
            //(await stationItemDataStore.GetItemsAsync(selectedLineItem.ID)).ForEach(x => StationItems.Add(x));
            //SelectedStationItem = StationItem.Empty;
        }

        public void CreatePdbGenerator()
        {
            incompatibleAPIs.CreatePdbGenerator();
        }

    }
}
