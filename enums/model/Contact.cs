/// <summary>
/// ������������ ���������� ���������� ��������.
/// </summary>
public class Contact
{
    private string _name;
    private string _surname;
    private string _phoneNumber;
    private string _email;

    /// <summary>
    /// �������������� ����� ��������� ������ <see cref="Contact"/> � ���������� �������.
    /// </summary>
    /// <param name="name">���. ������ ��������� ������ �����.</param>
    /// <param name="surname">�������. ������ ��������� ������ �����.</param>
    /// <param name="phoneNumber">����� ��������.</param>
    /// <param name="email">����� ����������� �����.</param>
    public Contact(string name, string surname, string phoneNumber, string email)
    {
        Name = name;
        Surname = surname;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    /// <summary>
    /// �������������� ����� ��������� ������ <see cref="Contact"/> � ������� ����������.
    /// </summary>
    public Contact() { }

    /// <summary>
    /// ���������� � ������ ���. ������ ��������� ������ �����.
    /// </summary>
    /// <exception cref="ArgumentException">�������������, ���� �������� �������� �� ������ �����.</exception>
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
    /// ���������� � ������ �������. ������ ��������� ������ �����.
    /// </summary>
    /// <exception cref="ArgumentException">�������������, ���� �������� �������� �� ������ �����.</exception>
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
    /// ���������� � ������ ����� ��������.
    /// </summary>
    public string PhoneNumber
    {
        get => _phoneNumber;
        set => _phoneNumber = value;
    }

    /// <summary>
    /// ���������� � ������ ����� ����������� �����.
    /// </summary>
    public string Email
    {
        get => _email;
        set => _email = value;
    }

    /// <summary>
    /// ���������, ��� ������ �������� ������ ����� ����������� ��������.
    /// </summary>
    /// <param name="value">����������� ������.</param>
    /// <param name="propertyName">�������� ��������, ������� �����������.</param>
    /// <exception cref="ArgumentException">
    /// �������������, ���� ������ ������, �������� ������� ��� ����������� �������.
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