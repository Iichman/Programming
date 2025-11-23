using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics.View
{
    /// <summary>
    /// Главная форма приложения.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Магазин - основной объект бизнес-логики.
        /// </summary>
        private Store _store = new Store();

        /// <summary>
        /// Создает экземпляр класса <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            Text = "Object Oriented Practics";

            // Инициализация данных
            InitializeStoreData();
            InitializeTabs();

            // Настройка обработчика событий для обновления вкладки корзин
            tabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged!;
        }

        /// <summary>
        /// Инициализирует тестовые данные магазина.
        /// </summary>
        private void InitializeStoreData()
        {
            // Добавляем тестовые товары
            _store.Items.Add(new Item(1, "Laptop", "High-performance laptop", 999.99, Category.Electronics));
            _store.Items.Add(new Item(2, "Book", "Programming guide", 29.99, Category.Books));
            _store.Items.Add(new Item(3, "T-Shirt", "Cotton t-shirt", 19.99, Category.Clothing));

            // Добавляем тестовых покупателей
            var address = new Address(123456, "Russia", "Moscow", "Main Street", "10", "25");
            _store.Customers.Add(new Customer("John Smith", address));

            address = new Address(654321, "Russia", "Saint Petersburg", "Nevsky Prospect", "5", "12");
            _store.Customers.Add(new Customer("Jane Doe", address));
        }

        /// <summary>
        /// Инициализирует данные на вкладках.
        /// </summary>
        private void InitializeTabs()
        {
            // Передаем данные на вкладки
            itemsTab.Items = _store.Items;
            customersTab.Customers = _store.Customers;
            cartsTab.Items = _store.Items;
            cartsTab.Customers = _store.Customers;
        }

        /// <summary>
        /// Обработчик события изменения выбранной вкладки.
        /// </summary>
        private void TabControl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // Если переключились на вкладку Carts, обновляем данные
            if (tabControl.SelectedTab == cartsTabPage)
            {
                cartsTab.RefreshData();
            }
        }
    }
}