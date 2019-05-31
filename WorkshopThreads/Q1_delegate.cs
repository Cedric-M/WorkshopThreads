using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopThreads
{
    class Q1_delegate
    {
        delegate int DELG(int v1, int v2);
        static void Main(string[] args)
        {
            //equivalent (sans delegate) à:
            //work.method(1,2);

            DELG d = new DELG(work.Add);

            var resultat = d.Invoke(1, 2);
            Console.WriteLine(resultat);

            Console.Read();
        }
    }

    static class work
    {
        static public int Add(int v1, int v2)
        {
            return v1 + v2;
        }
    }
}
