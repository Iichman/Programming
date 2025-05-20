/// <summary>
/// Представляет контактную информацию человека.
/// </summary>
public class Contact
{
    private string _name;
    private string _surname;
    private string _phoneNumber;
    private string _email;

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="Contact"/> с указанными данными.
    /// </summary>
    /// <param name="name">Имя. Должно содержать только буквы.</param>
    /// <param name="surname">Фамилия. Должна содержать только буквы.</param>
    /// <param name="phoneNumber">Номер телефона.</param>
    /// <param name="email">Адрес электронной почты.</param>
    public Contact(string name, string surname, string phoneNumber, string email)
    {
        Name = name;
        Surname = surname;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="Contact"/> с пустыми значениями.
    /// </summary>
    public Contact() { }

    /// <summary>
    /// Возвращает и задает имя. Должно содержать только буквы.
    /// </summary>
    /// <exception cref="ArgumentException">Выбрасывается, если значение содержит не только буквы.</exception>
    public string Name
    {
        get => _name;
        set
        {
            AssertStringContainsOnlyLetters(value, nameof(Name));
            _name = value;
        }
    }

    /// <summary>
    /// Возвращает и задает фамилию. Должна содержать только буквы.
    /// </summary>
    /// <exception cref="ArgumentException">Выбрасывается, если значение содержит не только буквы.</exception>
    public string Surname
    {
        get => _surname;
        set
        {
            AssertStringContainsOnlyLetters(value, nameof(Surname));
            _surname = value;
        }
    }

    /// <summary>
    /// Возвращает и задает номер телефона.
    /// </summary>
    public string PhoneNumber
    {
        get => _phoneNumber;
        set => _phoneNumber = value;
    }

    /// <summary>
    /// Возвращает и задает адрес электронной почты.
    /// </summary>
    public string Email
    {
        get => _email;
        set => _email = value;
    }

    /// <summary>
    /// Проверяет, что строка содержит только буквы английского алфавита.
    /// </summary>
    /// <param name="value">Проверяемая строка.</param>
    /// <param name="propertyName">Название свойства, которое проверяется.</param>
    /// <exception cref="ArgumentException">
    /// Выбрасывается, если строка пустая, содержит пробелы или небуквенные символы.
    /// </exception>
    private void AssertStringContainsOnlyLetters(string value, string propertyName)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException($"{propertyName} cannot be empty or whitespace.");
        }

        foreach (char c in value)
        {
            if (!char.IsLetter(c))
            {
                throw new ArgumentException($"{propertyName} must contain only English letters.");
            }
        }
    }
}