using System;
using System.DirectoryServices;

namespace standard.two
{
    public class Class1
    {
        public void Foo()
        {
            var bar = new System.DirectoryServices.DirectoryEntry(@"c:\temp");
        }
    }
}
