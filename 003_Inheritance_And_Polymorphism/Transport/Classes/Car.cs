namespace Transport.Classes
{
    internal class Car : Vehicle
    {
        public override void GetInfo()
        {
            System.Console.WriteLine("Информация об автомобиле");
            base.GetInfo();
        }
    }
}
