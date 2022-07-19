using System;

namespace School
{
    internal class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Study excelent");
        }

        public override void Read()
        {
            Console.WriteLine("Read excelent");
        }

        public override void Write()
        {
            Console.WriteLine("Write excelent");
        }

        public override void Relax()
        {
            Console.WriteLine("Relax excelent");
        }
    }
}
