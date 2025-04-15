public class Contact
{
    private string _name;
    private string _surname;
    private string _phoneNumber;
    private string _email;

    public Contact(string name, string surname, string phoneNumber, string email)
    {
        Name = name;
        Surname = surname;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public Contact() { }

    public string Name
    {
        get => _name;
        set
        {
            AssertStringContainsOnlyLetters(value, nameof(Name));
            _name = value;
        }
    }

    public string Surname
    {
        get => _surname;
        set
        {
            AssertStringContainsOnlyLetters(value, nameof(Surname));
            _surname = value;
        }
    }

    public string PhoneNumber
    {
        get => _phoneNumber;
        set => _phoneNumber = value;
    }

    public string Email
    {
        get => _email;
        set => _email = value;
    }

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