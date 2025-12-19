using System;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics
{
    /// <summary>
    /// Главная форма приложения.
    /// </summary>
    public partial class MainForm : Form
    {
        private Store _store;

        /// <summary>
        /// Создает главную форму.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            // Инициализируем данные после полной загрузки формы
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

        /// <summary>
        /// Инициализирует данные.
        /// </summary>
        private void InitializeData()
        {
            _store = new Store();

            // Инициализация вкладок
            itemsTab1.Items = _store.Items;
            customersTab1.Customers = _store.Customers;

            // Устанавливаем данные для CartsTab и OrdersTab
            cartsTab1.Items = _store.Items;
            cartsTab1.Customers = _store.Customers;
            ordersTab1.Customers = _store.Customers;

            // Подписка на события
            cartsTab1.OrderCreated += CartsTab1_OrderCreated;
            itemsTab1.ItemsChanged += ItemsTab1_ItemsChanged;
        }

        private void CartsTab1_OrderCreated(object sender, EventArgs e)
        {
            // Обновляем список заказов при создании нового заказа
            ordersTab1.Customers = _store.Customers;
        }

        private void ItemsTab1_ItemsChanged(object sender, EventArgs e)
        {
            // Обновляем список товаров в CartsTab
            cartsTab1.Items = _store.Items;
            cartsTab1.RefreshData();
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Обновление данных при переключении вкладок
            if (tabControl1.SelectedTab == tabPage4) // Orders tab
            {
                ordersTab1.Customers = _store.Customers;
            }
            else if (tabControl1.SelectedTab == tabPage3) // Carts tab
            {
                cartsTab1.Items = _store.Items;
                cartsTab1.Customers = _store.Customers;
                cartsTab1.RefreshData();
            }
        }

        private void itemsTab1_Load(object sender, EventArgs e)
        {

        }

        private void customersTab1_Load(object sender, EventArgs e)
        {

        }
    }
}