using System;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;

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
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

        /// <summary>
        /// Инициализирует данные и подписывается на события.
        /// </summary>
        private void InitializeData()
        {
            _store = new Store();

            itemsTab1.Items = _store.Items;
            customersTab1.Customers = _store.Customers;
            cartsTab1.Items = _store.Items;
            cartsTab1.Customers = _store.Customers;
            ordersTab1.Customers = _store.Customers;

            itemsTab1.ItemsChanged += ItemsTab1_ItemsChanged;
            cartsTab1.OrderCreated += CartsTab1_OrderCreated;
        }

        /// <summary>
        /// Обработчик события изменения товаров.
        /// </summary>
        private void ItemsTab1_ItemsChanged(object sender, ItemsChangedEventArgs e)
        {
            cartsTab1.Items = _store.Items;

            if (cartsTab1 is CartsTab cartsTab)
            {
                cartsTab.RefreshCartList();
            }
        }

        /// <summary>
        /// Обработчик события создания заказа.
        /// </summary>
        private void CartsTab1_OrderCreated(object sender, EventArgs e)
        {
            ordersTab1.Customers = _store.Customers;

            if (ordersTab1 is OrdersTab ordersTab)
            {
                ordersTab.RefreshOrdersList();
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