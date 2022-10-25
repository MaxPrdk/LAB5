using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classroom
{
    internal class classroom
    {
        List<pupil> pupils;

        public classroom(params pupil[] values)
        {
            if (values.Length < 2 || values.Length > 4)
                return;


            pupils = values.ToList();
        }

        public void showpupils()
        {
            foreach (Pupil pupil in pupils)
            {
                pupil.Print();
            }
        }
    }
}