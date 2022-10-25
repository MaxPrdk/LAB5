using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classroom
{
    internal abstract class pupil
    {
        public virtual void Study()
        {

        }

        public virtual void Read()
        {

        }

        public virtual void Write()
        {

        }

        public virtual void Relax()
        {

        }

        public void Print()
        {
            Study();
            Read();
            Write();
            Relax();
            Console.WriteLine();
        }
    }
}