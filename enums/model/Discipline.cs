namespace Programming.Model
{
    public class Discipline
    {
        private string _name;
        private string _teacher;
        private int _credits;

        public Discipline(string name, string teacher, int credits)
        {
            Name = name;
            Teacher = teacher;
            Credits = credits;
        }

        public Discipline() { }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Teacher
        {
            get { return _teacher; }
            set { _teacher = value; }
        }

        public int Credits
        {
            get { return _credits; }
            set { _credits = value; }
        }
    }
}