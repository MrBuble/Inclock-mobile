using Inclock.BL.SqlLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

[assembly: Xamarin.Forms.Dependency(typeof(Inclock.iOS.Frameworks.Config))]
namespace Inclock.iOS.Frameworks
{
    class Config : IConfig
    {
        public string StringConnection => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "..", "Library");
    }
}
