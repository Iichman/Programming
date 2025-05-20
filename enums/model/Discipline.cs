namespace Programming.Model
{
    /// <summary>
    /// Представляет учебную дисциплину с информацией о названии, преподавателе и количестве кредитов.
    /// </summary>
    public class Discipline
    {
        private string _name;
        private string _teacher;
        private int _credits;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Discipline"/> с заданными параметрами.
        /// </summary>
        /// <param name="name">Название дисциплины. Не должно быть пустым.</param>
        /// <param name="teacher">ФИО преподавателя. Не должно быть пустым.</param>
        /// <param name="credits">Количество кредитов. Должно быть положительным числом.</param>
        public Discipline(string name, string teacher, int credits)
        {
            Name = name;
            Teacher = teacher;
            Credits = credits;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Discipline"/> с пустыми значениями.
        /// </summary>
        public Discipline() { }

        /// <summary>
        /// Возвращает и задает название дисциплины.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Возвращает и задает ФИО преподавателя.
        /// </summary>
        public string Teacher
        {
            get { return _teacher; }
            set { _teacher = value; }
        }

        /// <summary>
        /// Возвращает и задает количество кредитов по дисциплине.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Возникает, если значение не является положительным числом.
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