using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PApp1
{
    public static class TestData
    {
        public static string GetTextFromFile(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
