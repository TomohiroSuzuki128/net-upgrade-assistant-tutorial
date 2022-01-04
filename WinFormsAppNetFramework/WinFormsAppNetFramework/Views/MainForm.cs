using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAppNetFramework.ViewModel;

namespace WinFormsAppNetFramework.Views
{
    public partial class MainForm : Form
    {
        MainFormViewModel viewModel;

        public MainForm(MainFormViewModel viewModel)
        {
            this.viewModel = viewModel;

            InitializeComponent();
            InitializeBinding();
        }

        void InitializeBinding()
        {
            DataBindings.Add(new Binding("Text", viewModel, "Title"));
            labelZipCode.DataBindings.Add(new Binding("Text", viewModel, "LabelZipCodeText"));
            labelPrefecture.DataBindings.Add(new Binding("Text", viewModel, "LabelPrefectureText"));
            buttonGetAddress.DataBindings.Add(new Binding("Text", viewModel, "ButtonGetAddressText"));
            comboBoxPrefectures.DataBindings.Add(new Binding("DataSource", viewModel, "Prefectures"));
            textBoxZipCode.DataBindings.Add(new Binding("Text", viewModel, "ZipCode"));
            textBoxAddress.DataBindings.Add(new Binding("Text", viewModel, "Address"));

            buttonGetAddress.Click += (sender, args) => viewModel.GetAddressCommand.Execute(null);
        }
    }
}
