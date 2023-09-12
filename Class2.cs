using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3project
{
    internal class Class2
    {
        private int privateFieldA;
        public Class2(int value)
        {
            this.privateFieldA = value;
        }
        public int GetPrivateFieldA()
        {
            return privateFieldA;
        }
    }
}
