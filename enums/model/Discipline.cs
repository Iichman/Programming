namespace Programming.Model
{
    /// <summary>
    /// ������������ ������� ���������� � ����������� � ��������, ������������� � ���������� ��������.
    /// </summary>
    public class Discipline
    {
        private string _name;
        private string _teacher;
        private int _credits;

        /// <summary>
        /// �������������� ����� ��������� ������ <see cref="Discipline"/> � ��������� �����������.
        /// </summary>
        /// <param name="name">�������� ����������. �� ������ ���� ������.</param>
        /// <param name="teacher">��� �������������. �� ������ ���� ������.</param>
        /// <param name="credits">���������� ��������. ������ ���� ������������� ������.</param>
        public Discipline(string name, string teacher, int credits)
        {
            Name = name;
            Teacher = teacher;
            Credits = credits;
        }

        /// <summary>
        /// �������������� ����� ��������� ������ <see cref="Discipline"/> � ������� ����������.
        /// </summary>
        public Discipline() { }

        /// <summary>
        /// ���������� � ������ �������� ����������.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// ���������� � ������ ��� �������������.
        /// </summary>
        public string Teacher
        {
            get { return _teacher; }
            set { _teacher = value; }
        }

        /// <summary>
        /// ���������� � ������ ���������� �������� �� ����������.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// ���������, ���� �������� �� �������� ������������� ������.
        /// </exception>
        public int Credits
        {
            get { return _credits; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Credits must be positive");
                }
                _credits = value;
            }
        }
    }
}