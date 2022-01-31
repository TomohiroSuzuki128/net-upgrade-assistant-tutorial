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
