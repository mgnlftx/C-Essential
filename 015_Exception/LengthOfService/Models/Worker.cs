namespace LengthOfService
{
    internal struct Worker
    {
        public string LastName { get; set; }

        public string Profession { get; set; }

        public int Experience { get; set; }

        //Надо или лишнее?
        public Worker(string name, string prof, int experience)
        {
            LastName = name;
            Profession = prof;
            Experience = experience;
        }

        public override string ToString()
        {
            return (string.Format("Фамилия и инициалы работника: {0} ,\n" +
                                  "Название занимаемой должности: {1},\n" +
                                  "Год поступления на работу: {2} ", LastName, Profession, Experience));
        }
    }
}
