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
            DataBindings.Add(new Binding("Text", viewModel, nameof(viewModel.Title)));
            labelZipCode.DataBindings.Add(new Binding("Text", viewModel, nameof(viewModel.LabelZipCodeText)));
            labelPrefecture.DataBindings.Add(new Binding("Text", viewModel, nameof(viewModel.LabelPrefectureText)));
            labelAddress.DataBindings.Add(new Binding("Text", viewModel, nameof(viewModel.LabelAddressText)));
            buttonGetAddress.DataBindings.Add(new Binding("Text", viewModel, nameof(viewModel.ButtonGetAddressText)));
            comboBoxPrefectures.DataBindings.Add(new Binding("DataSource", viewModel, nameof(viewModel.Prefectures)));
            comboBoxPrefectures.DataBindings.Add(new Binding("SelectedItem", viewModel, nameof(viewModel.SelectedPrefecture)));
            textBoxZipCode.DataBindings.Add(new Binding("Text", viewModel, nameof(viewModel.ZipCode)));
            textBoxAddress.DataBindings.Add(new Binding("Text", viewModel, nameof(viewModel.Address)));

            buttonGetAddress.Click += (_, __) => viewModel.GetAddressCommand.Execute(null);
        }
    }
}
