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
        MainFormViewModel mainFormViewModel;

        public MainForm(MainFormViewModel mainFormViewModel)
        {
            InitializeComponent();

        }
    }
}
