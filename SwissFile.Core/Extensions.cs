using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissFile.Core
{
    public static class Extensions
    {
        public static void EnsureNotNull<T>(this T obj, string name)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(name + " cannot be null"); 
            }
        }

        public static void EnsureExists<T>(this T fs) where T : FileSystemInfo
        {
            if (!fs.Exists)
            {
                throw new ArgumentException(fs.Name + " does not exist");
            }
        }
    }
}
