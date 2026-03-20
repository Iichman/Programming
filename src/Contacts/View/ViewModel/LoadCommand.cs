using System.Windows.Input;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Команда загрузки контакта.
    /// </summary>
    public class LoadCommand : ICommand
    {
        private readonly MainVM _mainVM;

        /// <summary>
        /// Конструктор команды загрузки.
        /// </summary>
        /// <param name="mainVM">Ссылка на главную ViewModel.</param>
        public LoadCommand(MainVM mainVM)
        {
            _mainVM = mainVM;
        }

        /// <summary>
        /// Событие изменения возможности выполнения команды.
        /// </summary>
        public event EventHandler? CanExecuteChanged;

        /// <summary>
        /// Определяет, может ли команда выполняться.
        /// </summary>
        public bool CanExecute(object? parameter) => true;

        /// <summary>
        /// Выполняет команду загрузки.
        /// </summary>
        public void Execute(object? parameter)
        {
            var loaded = ContactSerializer.Load();
            _mainVM.Name = loaded.Name;
            _mainVM.PhoneNumber = loaded.PhoneNumber;
            _mainVM.Email = loaded.Email;
        }
    }
}