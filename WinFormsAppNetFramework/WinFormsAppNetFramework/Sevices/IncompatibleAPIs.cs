using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppNetFramework.Sevices
{
    public class IncompatibleAPIs
    {
        // .NET 6 で PlatformNotSupportedException をスローするメソッド
        public void CreatePdbGenerator()
        {
            var dig = System.Runtime.CompilerServices.DebugInfoGenerator.CreatePdbGenerator();
        }
    }
}
