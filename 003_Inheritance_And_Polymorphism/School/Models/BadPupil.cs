using System;

namespace School
{
    internal class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Study bad");
        }

        public override void Read()
        {
            Console.WriteLine("Read bad");
        }

        public override void Write()
        {
            Console.WriteLine("Write bad");
        }

        //public override void Relax()
        //{
        //    Console.WriteLine("Relax bad");
        //}
    }
}
