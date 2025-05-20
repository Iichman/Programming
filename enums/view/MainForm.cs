using System.Windows.Forms;
using Programming.View.Controls;

namespace Programming.View
{
    /// <summary>
    /// Основная форма приложения, содержащая вкладки для работы с различными контролами.
    /// </summary>
    public partial class MainForm : Form
    {
        private EnumsTabControl _enumsTabControl; // Контроль для работы с перечислениями
        private ClassesTabControl _classesTabControl; // Контроль для работы с классами
        private RectanglesCollisionControl _collisionControl; // Контроль для проверки пересечений прямоугольников и колец

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            // Инициализация контролов
            _enumsTabControl = new EnumsTabControl();
            _classesTabControl = new ClassesTabControl();

            // Получаем контролы прямоугольников и колец
            var rectanglesControl = _classesTabControl.GetRectanglesControl();
            var ringsControl = _classesTabControl.GetRingsControl();

            // Создаем контрол проверки пересечений
            _collisionControl = new RectanglesCollisionControl(rectanglesControl, ringsControl);

            // Настройка layout
            _enumsTabControl.Dock = DockStyle.Fill;
            _classesTabControl.Dock = DockStyle.Fill;
            _collisionControl.Dock = DockStyle.Fill;

            // Добавление контролов на вкладки
            enumsTabPage.Controls.Add(_enumsTabControl);
            classesTabPage.Controls.Add(_classesTabControl);
            collisionTabPage.Controls.Add(_collisionControl);
        }

        /// <summary>
        /// Обработчик события отображения формы. Обновляет данные в контроле пересечений.
        /// </summary>
        /// <param name="e">Аргументы события отображения.</param>
        protected override void OnShown(System.EventArgs e)
        {
            base.OnShown(e);
            _collisionControl.UpdateData();
        }
    }
}