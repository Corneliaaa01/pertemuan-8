using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Abdul Mizwar", 24);
            person1.InfoPerson();

            Karyawan karyawan1 = new Karyawan("Putri", 24, "Dosen");
            karyawan1.InfoPerson();

            Console.ReadKey();
        }
    }
}