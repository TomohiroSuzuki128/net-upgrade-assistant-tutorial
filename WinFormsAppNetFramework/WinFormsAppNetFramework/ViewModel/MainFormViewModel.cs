using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using WinFormsAppNetFramework.ExtensionMethods;
using WinFormsAppNetFramework.Models;
using WinFormsAppNetFramework.Sevices;

namespace WinFormsAppNetFramework.ViewModel
{
    public class MainFormViewModel : ViewModelBase
    {
        string labelZipCodeText = string.Empty;
        public string LabelZipCodeText
        {
            get { return labelZipCodeText; }
            set { SetProperty(ref labelZipCodeText, value); }
        }

        string labelPrefectureText = string.Empty;
        public string LabelPrefectureText
        {
            get { return labelPrefectureText; }
            set { SetProperty(ref labelPrefectureText, value); }
        }

        string buttonGetAddressText = string.Empty;
        public string ButtonGetAddressText
        {
            get { return buttonGetAddressText; }
            set { SetProperty(ref buttonGetAddressText, value); }
        }

        string zipCode = string.Empty;
        public string ZipCode
        {
            get { return zipCode; }
            set { SetProperty(ref zipCode, value); }
        }

        string address = string.Empty;
        public string Address
        {
            get { return address; }
            set { SetProperty(ref address, value); }
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
            LabelZipCodeText = "郵便番号";
            LabelPrefectureText = "都道府県";
            ButtonGetAddressText = "住所検索";

            Prefectures = new ObservableCollection<Prefecture>();
            Prefectures.Add(Prefecture.Empty);
            Sevices.Prefectures.All().ForEach(x => Prefectures.Add(x));
            SelectedPrefecture = Prefecture.Empty;

            GetAddressCommand = new Command(() => GetAddress(), () => !string.IsNullOrWhiteSpace(ZipCode));
        }

        async void GetAddress()
        {
            var addresses = await SearchAddressClient.ZipToAddress(ZipCode.Replace("-",""));

            if (addresses.Length > 0)
                Address = $"{addresses.FirstOrDefault().City}{addresses.FirstOrDefault().Machi}";
        }

        public void CreatePdbGenerator()
        {
            incompatibleAPIs.CreatePdbGenerator();
        }

    }
}
