﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Mocking;

namespace TestNinja.UnitTests
{
    internal class FakeFileReader : IFileReader
    {
        public string Read(string path)
        {
            return "";
        }
    }
}
