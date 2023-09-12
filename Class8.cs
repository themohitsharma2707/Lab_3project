using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3project
{
    internal class Class8
    {
        public String country;
        private int mobile;
        public Class8(String country, int mobile)
        {
            this.country = country;
            this.mobile = mobile;
        }
        private void Getinfo()
        {
            Console.WriteLine($"The agent country name is {country} and mobile number is {mobile}");
        }

        public void Getinfo2()
        {
            Getinfo();
        }

    }
}
