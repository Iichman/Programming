using System.Windows.Forms;

namespace Programming.View.Controls
{
    /// <summary>
    /// Представляет элемент управления с вкладками для отображения различных классов.
    /// </summary>
    public partial class ClassesTabControl : UserControl
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="ClassesTabControl"/>.
        /// </summary>
        public ClassesTabControl()
        {
            InitializeComponent();
            InitializeTabs();
        }

        /// <summary>
        /// Инициализирует вкладки и добавляет соответствующие элементы управления.
        /// </summary>
        private void InitializeTabs()
        {
            // Добавляем контролы на вкладки
            rectanglesTabPage.Controls.Add(new RectanglesControl());
            moviesTabPage.Controls.Add(new MoviesControl());
            ringsTabPage.Controls.Add(new RingsControl());

            // Настраиваем Dock для каждого контрола
            rectanglesTabPage.Controls[0].Dock = DockStyle.Fill;
            moviesTabPage.Controls[0].Dock = DockStyle.Fill;
            ringsTabPage.Controls[0].Dock = DockStyle.Fill;
        }

        /// <summary>
        /// Получает элемент управления <see cref="RectanglesControl"/> из вкладки.
        /// </summary>
        /// <returns>Элемент управления <see cref="RectanglesControl"/>.</returns>
        public RectanglesControl GetRectanglesControl()
        {
            return (RectanglesControl)rectanglesTabPage.Controls[0];
        }

        /// <summary>
        /// Получает элемент управления <see cref="MoviesControl"/> из вкладки.
        /// </summary>
        /// <returns>Элемент управления <see cref="MoviesControl"/>.</returns>
        public MoviesControl GetMoviesControl()
        {
            return (MoviesControl)moviesTabPage.Controls[0];
        }

        /// <summary>
        /// Получает элемент управления <see cref="RingsControl"/> из вкладки.
        /// </summary>
        /// <returns>Элемент управления <see cref="RingsControl"/>.</returns>
        public RingsControl GetRingsControl()
        {
            return (RingsControl)ringsTabPage.Controls[0];
        }
    }
}