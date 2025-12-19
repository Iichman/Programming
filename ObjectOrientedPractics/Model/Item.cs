using System;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет товар.
    /// </summary>
    public class Item : ICloneable, IEquatable<Item>, IComparable<Item>
    {
        private string _name;
        private string _info;
        private decimal _cost;
        private Category _category;

        /// <summary>
        /// Событие изменения названия товара.
        /// </summary>
        public event EventHandler NameChanged;

        /// <summary>
        /// Событие изменения описания товара.
        /// </summary>
        public event EventHandler InfoChanged;

        /// <summary>
        /// Событие изменения стоимости товара.
        /// </summary>
        public event EventHandler CostChanged;

        /// <summary>
        /// Событие изменения категории товара.
        /// </summary>
        public event EventHandler CategoryChanged;

        /// <summary>
        /// Событие изменения любого свойства товара.
        /// </summary>
        public event EventHandler AnyPropertyChanged;

        /// <summary>
        /// Уникальный идентификатор товара.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Название товара.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnNameChanged();
                    OnAnyPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Описание товара.
        /// </summary>
        public string Info
        {
            get => _info;
            set
            {
                if (_info != value)
                {
                    _info = value;
                    OnInfoChanged();
                    OnAnyPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Стоимость товара.
        /// </summary>
        public decimal Cost
        {
            get => _cost;
            set
            {
                if (_cost != value)
                {
                    _cost = value;
                    OnCostChanged();
                    OnAnyPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Категория товара.
        /// </summary>
        public Category Category
        {
            get => _category;
            set
            {
                if (_category != value)
                {
                    _category = value;
                    OnCategoryChanged();
                    OnAnyPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Создает новый товар.
        /// </summary>
        public Item()
        {
            Id = GenerateId();
        }

        /// <summary>
        /// Создает товар с заданными параметрами.
        /// </summary>
        public Item(string name, string info, decimal cost, Category category)
        {
            Id = GenerateId();
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }

        private static int _nextId = 1;

        /// <summary>
        /// Генерирует уникальный идентификатор.
        /// </summary>
        private static int GenerateId() => _nextId++;

        /// <summary>
        /// Вызывает событие изменения названия.
        /// </summary>
        protected virtual void OnNameChanged() => NameChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Вызывает событие изменения описания.
        /// </summary>
        protected virtual void OnInfoChanged() => InfoChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Вызывает событие изменения стоимости.
        /// </summary>
        protected virtual void OnCostChanged() => CostChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Вызывает событие изменения категории.
        /// </summary>
        protected virtual void OnCategoryChanged() => CategoryChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Вызывает событие изменения любого свойства.
        /// </summary>
        protected virtual void OnAnyPropertyChanged() => AnyPropertyChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Создает копию товара.
        /// </summary>
        public object Clone()
        {
            return new Item(Name, Info, Cost, Category) { Id = this.Id };
        }

        /// <summary>
        /// Сравнивает текущий товар с другим товаром.
        /// </summary>
        public bool Equals(Item other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            return Id == other.Id && Name == other.Name && Cost == other.Cost && Category == other.Category;
        }

        /// <summary>
        /// Сравнивает текущий товар с другим объектом.
        /// </summary>
        public override bool Equals(object obj) => Equals(obj as Item);

        /// <summary>
        /// Возвращает хэш-код товара.
        /// </summary>
        public override int GetHashCode() => HashCode.Combine(Id, Name, Cost, Category);

        /// <summary>
        /// Сравнивает текущий товар с другим товаром по стоимости.
        /// </summary>
        public int CompareTo(Item other)
        {
            if (other is null) return 1;
            return Cost.CompareTo(other.Cost);
        }

        /// <summary>
        /// Проверяет равенство двух товаров.
        /// </summary>
        public static bool operator ==(Item left, Item right)
        {
            if (ReferenceEquals(left, right)) return true;
            if (left is null || right is null) return false;
            return left.Equals(right);
        }

        /// <summary>
        /// Проверяет неравенство двух товаров.
        /// </summary>
        public static bool operator !=(Item left, Item right) => !(left == right);

        /// <summary>
        /// Возвращает строковое представление товара.
        /// </summary>
        public override string ToString() => $"{Name} - {Cost:C}";
    }
}