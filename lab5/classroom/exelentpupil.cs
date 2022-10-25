using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classroom
{
    internal class goodpupil : pupil
    {
        public override void Read()
        {
            Console.WriteLine("good read");
        }

        public override void Write()
        {
            Console.WriteLine("good write");
        }

        public override void Relax()
        {
            Console.WriteLine("good relax");
        }

        public override void Study()
        {
            Console.WriteLine("good study");
        }
    }
}