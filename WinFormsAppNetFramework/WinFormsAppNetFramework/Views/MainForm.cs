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
            labelZipCode.DataBindings.Add(new Binding("Text", viewModel, "LabelZipCode"));
            labelPrefecture.DataBindings.Add(new Binding("Text", viewModel, "LabelPrefecture"));
            comboBoxPrefectures.DataBindings.Add(new Binding("DataSource", viewModel, "Prefectures"));
        }
    }
}
