using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAppNetFramework.Sevices;

namespace WinFormsAppNetFramework.ViewModel
{
    public class MainFormViewModel
    {
        IncompatibleAPIs incompatibleAPIs = new IncompatibleAPIs();

        public MainFormViewModel()
        {
            CreatePdbGenerator();
        }

        public void CreatePdbGenerator()
        {
            incompatibleAPIs.CreatePdbGenerator();
        }

    }
}
