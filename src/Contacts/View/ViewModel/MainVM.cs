using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using View.Model;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel для главного окна приложения.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Контакт, с которым работает приложение.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Событие для уведомления интерфейса об изменениях свойств.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public MainVM()
        {
            _contact = new Contact();
            SaveCommand = new SaveCommand(this);
            LoadCommand = new LoadCommand(this);
        }

        /// <summary>
        /// Текущий контакт.
        /// </summary>
        public Contact CurrentContact => _contact;

        /// <summary>
        /// Имя контакта.
        /// </summary>
        public string Name
        {
            get => _contact.Name;
            set
            {
                if (_contact.Name != value)
                {
                    _contact.Name = value;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        public string PhoneNumber
        {
            get => _contact.PhoneNumber;
            set
            {
                if (_contact.PhoneNumber != value)
                {
                    _contact.PhoneNumber = value;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Электронная почта контакта.
        /// </summary>
        public string Email
        {
            get => _contact.Email;
            set
            {
                if (_contact.Email != value)
                {
                    _contact.Email = value;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Команда сохранения контакта.
        /// </summary>
        public ICommand SaveCommand { get; }

        /// <summary>
        /// Команда загрузки контакта.
        /// </summary>
        public ICommand LoadCommand { get; }

        /// <summary>
        /// Метод для вызова события PropertyChanged.
        /// </summary>
        /// <param name="propertyName">Имя изменившегося свойства.</param>
        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}