using System.Windows.Forms;

namespace Programming.View.Controls
{
    /// <summary>
    /// ������������ ������� ���������� � ��������� ��� ����������� ��������� �������.
    /// </summary>
    public partial class ClassesTabControl : UserControl
    {
        /// <summary>
        /// �������������� ����� ��������� ������ <see cref="ClassesTabControl"/>.
        /// </summary>
        public ClassesTabControl()
        {
            InitializeComponent();
            InitializeTabs();
        }

        /// <summary>
        /// �������������� ������� � ��������� ��������������� �������� ����������.
        /// </summary>
        private void InitializeTabs()
        {
            // ��������� �������� �� �������
            rectanglesTabPage.Controls.Add(new RectanglesControl());
            moviesTabPage.Controls.Add(new MoviesControl());
            ringsTabPage.Controls.Add(new RingsControl());

            // ����������� Dock ��� ������� ��������
            rectanglesTabPage.Controls[0].Dock = DockStyle.Fill;
            moviesTabPage.Controls[0].Dock = DockStyle.Fill;
            ringsTabPage.Controls[0].Dock = DockStyle.Fill;
        }

        /// <summary>
        /// �������� ������� ���������� <see cref="RectanglesControl"/> �� �������.
        /// </summary>
        /// <returns>������� ���������� <see cref="RectanglesControl"/>.</returns>
        public RectanglesControl GetRectanglesControl()
        {
            return (RectanglesControl)rectanglesTabPage.Controls[0];
        }

        /// <summary>
        /// �������� ������� ���������� <see cref="MoviesControl"/> �� �������.
        /// </summary>
        /// <returns>������� ���������� <see cref="MoviesControl"/>.</returns>
        public MoviesControl GetMoviesControl()
        {
            return (MoviesControl)moviesTabPage.Controls[0];
        }

        /// <summary>
        /// �������� ������� ���������� <see cref="RingsControl"/> �� �������.
        /// </summary>
        /// <returns>������� ���������� <see cref="RingsControl"/>.</returns>
        public RingsControl GetRingsControl()
        {
            return (RingsControl)ringsTabPage.Controls[0];
        }
    }
}