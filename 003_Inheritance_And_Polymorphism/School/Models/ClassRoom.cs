namespace School
{
    internal class ClassRoom
    {
        public Pupil[] Pupils = new Pupil[4];

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4)
        {
            Pupils[0] = p1;
            Pupils[1] = p2;
            Pupils[2] = p3;
            Pupils[3] = p4;
        }

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3)
        {
            Pupils[0] = p1;
            Pupils[1] = p2;
            Pupils[2] = p3;
            Pupils[3] = new Pupil();
        }

        public ClassRoom(Pupil p1, Pupil p2)
        {
            Pupils[0] = p1;
            Pupils[1] = p2;
            Pupils[2] = new Pupil();
            Pupils[3] = new Pupil();
        }
    }
}
