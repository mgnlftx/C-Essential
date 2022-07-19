using System;

namespace School
{
    internal class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Study good");
        }

        public override void Read()
        {
            Console.WriteLine("Read good");
        }

        public override void Write()
        {
            Console.WriteLine("Write good");
        }

        public override void Relax()
        {
            Console.WriteLine("Relax good");
        }
    }
}
