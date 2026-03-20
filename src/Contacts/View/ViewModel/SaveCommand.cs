using System.Windows.Input;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Команда сохранения контакта.
    /// </summary>
    public class SaveCommand : ICommand
    {
        private readonly MainVM _mainVM;

        /// <summary>
        /// Конструктор команды сохранения.
        /// </summary>
        /// <param name="mainVM">Ссылка на главную ViewModel.</param>
        public SaveCommand(MainVM mainVM)
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
        /// Выполняет команду сохранения.
        /// </summary>
        public void Execute(object? parameter)
        {
            ContactSerializer.Save(_mainVM.CurrentContact);
        }
    }
}