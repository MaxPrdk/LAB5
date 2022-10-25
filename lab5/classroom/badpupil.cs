using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classroom
{
    internal class badpupil : pupil
    {
        public override void Read()
        {
            Console.WriteLine("bad read");
        }

        public override void Write()
        {
            Console.WriteLine("bad write");
        }

        public override void Relax()
        {
            Console.WriteLine("bad relax");
        }

        public override void Study()
        {
            Console.WriteLine("bad study");
        }
    }
}