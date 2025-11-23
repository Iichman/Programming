using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет товар.
    /// </summary>
    public class Item
    {
        private readonly int _id;
        private string _name = "";
        private string _info = "";
        private double _cost;
        private Category _category;

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="id">Уникальный идентификатор.</param>
        /// <param name="name">Название товара.</param>
        /// <param name="info">Описание товара.</param>
        /// <param name="cost">Стоимость товара.</param>
        /// <param name="category">Категория товара.</param>
        public Item(int id, string name, string info, double cost, Category category)
        {
            _id = id;
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }

        /// <summary>
        /// Возвращает идентификатор товара.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Возвращает или задает название товара.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Возвращает или задает описание товара.
        /// </summary>
        public string Info
        {
            get { return _info; }
            set { _info = value; }
        }

        /// <summary>
        /// Возвращает или задает стоимость товара.
        /// </summary>
        public double Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        /// <summary>
        /// Возвращает или задает категорию товара.
        /// </summary>
        public Category Category
        {
            get { return _category; }
            set { _category = value; }
        }
    }
}