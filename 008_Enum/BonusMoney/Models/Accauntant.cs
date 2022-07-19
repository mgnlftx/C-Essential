namespace BonusMoney
{
    internal class Accauntant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            if ((int)worker < hours)
                return true;
            //Console.WriteLine("Add a bonus");
            else
                return false;
            //Console.WriteLine("Don't add bonus");
        }
    }
}
