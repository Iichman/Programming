using System;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Аргументы события изменения свойства товара.
    /// </summary>
    public class ItemPropertyChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Название измененного свойства.
        /// </summary>
        public string PropertyName { get; }

        /// <summary>
        /// Старое значение свойства.
        /// </summary>
        public object OldValue { get; }

        /// <summary>
        /// Новое значение свойства.
        /// </summary>
        public object NewValue { get; }

        /// <summary>
        /// Создает новый экземпляр <see cref="ItemPropertyChangedEventArgs"/>.
        /// </summary>
        /// <param name="propertyName">Название измененного свойства.</param>
        /// <param name="oldValue">Старое значение свойства.</param>
        /// <param name="newValue">Новое значение свойства.</param>
        public ItemPropertyChangedEventArgs(string propertyName, object oldValue, object newValue)
        {
            PropertyName = propertyName;
            OldValue = oldValue;

            NewValue = newValue;
        }
    }

    /// <summary>
    /// Представляет товар с поддержкой клонирования, сравнения и сортировки.
    /// </summary>
    public class Item : ICloneable, IEquatable<Item>, IComparable<Item>
    {
        private string _name;
        private string _info;
        private decimal _cost;
        private Category _category;

        /// <summary>
        /// Статический счётчик для генерации уникальных идентификаторов.
        /// </summary>
        private static int _nextId = 1;

        /// <summary>
        /// Событие изменения названия товара.
        /// </summary>
        public event EventHandler<ItemPropertyChangedEventArgs> NameChanged;

        /// <summary>
        /// Событие изменения описания товара.
        /// </summary>
        public event EventHandler<ItemPropertyChangedEventArgs> InfoChanged;

        /// <summary>
        /// Событие изменения стоимости товара.
        /// </summary>
        public event EventHandler<ItemPropertyChangedEventArgs> CostChanged;

        /// <summary>
        /// Событие изменения категории товара.
        /// </summary>
        public event EventHandler<ItemPropertyChangedEventArgs> CategoryChanged;

        /// <summary>
        /// Событие изменения любого свойства товара.
        /// </summary>
        public event EventHandler<ItemPropertyChangedEventArgs> AnyPropertyChanged;

        /// <summary>
        /// Уникальный идентификатор товара.
        /// </summary>
        /// <remarks>
        /// Идентификатор генерируется автоматически при создании товара
        /// и не должен изменяться в течение жизненного цикла объекта.
        /// </remarks>
        public int Id { get; }

        /// <summary>
        /// Название товара. Не может быть пустой строкой или null.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    string oldValue = _name;
                    _name = value;
                    OnNameChanged(oldValue, value);
                    OnAnyPropertyChanged("Name", oldValue, value);
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
                    string oldValue = _info;
                    _info = value;
                    OnInfoChanged(oldValue, value);
                    OnAnyPropertyChanged("Info", oldValue, value);
                }
            }
        }

        /// <summary>
        /// Стоимость товара. Должна быть неотрицательной.
        /// </summary>
        public decimal Cost
        {
            get => _cost;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Стоимость не может быть отрицательной.");
                }

                if (_cost != value)
                {
                    decimal oldValue = _cost;
                    _cost = value;
                    OnCostChanged(oldValue, value);
                    OnAnyPropertyChanged("Cost", oldValue, value);
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
                    Category oldValue = _category;
                    _category = value;
                    OnCategoryChanged(oldValue, value);
                    OnAnyPropertyChanged("Category", oldValue, value);
                }
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Item"/> с автоматически сгенерированным идентификатором.
        /// </summary>
        public Item()
        {
            Id = GenerateId();
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Item"/> с указанными параметрами.
        /// </summary>
        /// <param name="name">Название товара.</param>
        /// <param name="info">Описание товара.</param>
        /// <param name="cost">Стоимость товара.</param>
        /// <param name="category">Категория товара.</param>
        /// <exception cref="ArgumentException">Выбрасывается, когда стоимость отрицательная.</exception>
        public Item(string name, string info, decimal cost, Category category)
            : this()
        {
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }

        /// <summary>
        /// Генерирует уникальный идентификатор для нового товара.
        /// </summary>
        /// <returns>Уникальный целочисленный идентификатор.</returns>
        private static int GenerateId()
        {
            return _nextId++;
        }

        /// <summary>
        /// Вызывает событие <see cref="NameChanged"/>.
        /// </summary>
        /// <param name="oldValue">Старое значение названия.</param>
        /// <param name="newValue">Новое значение названия.</param>
        protected virtual void OnNameChanged(string oldValue, string newValue)
        {
            NameChanged?.Invoke(this, new ItemPropertyChangedEventArgs("Name", oldValue, newValue));
        }

        /// <summary>
        /// Вызывает событие <see cref="InfoChanged"/>.
        /// </summary>
        /// <param name="oldValue">Старое значение описания.</param>
        /// <param name="newValue">Новое значение описания.</param>
        protected virtual void OnInfoChanged(string oldValue, string newValue)
        {
            InfoChanged?.Invoke(this, new ItemPropertyChangedEventArgs("Info", oldValue, newValue));
        }

        /// <summary>
        /// Вызывает событие <see cref="CostChanged"/>.
        /// </summary>
        /// <param name="oldValue">Старая стоимость.</param>
        /// <param name="newValue">Новая стоимость.</param>
        protected virtual void OnCostChanged(decimal oldValue, decimal newValue)
        {
            CostChanged?.Invoke(this, new ItemPropertyChangedEventArgs("Cost", oldValue, newValue));
        }

        /// <summary>
        /// Вызывает событие <see cref="CategoryChanged"/>.
        /// </summary>
        /// <param name="oldValue">Старая категория.</param>
        /// <param name="newValue">Новая категория.</param>
        protected virtual void OnCategoryChanged(Category oldValue, Category newValue)
        {
            CategoryChanged?.Invoke(this, new ItemPropertyChangedEventArgs("Category", oldValue, newValue));
        }

        /// <summary>
        /// Вызывает событие <see cref="AnyPropertyChanged"/>.
        /// </summary>
        /// <param name="propertyName">Название измененного свойства.</param>
        /// <param name="oldValue">Старое значение свойства.</param>
        /// <param name="newValue">Новое значение свойства.</param>
        protected virtual void OnAnyPropertyChanged(string propertyName, object oldValue, object newValue)
        {
            AnyPropertyChanged?.Invoke(this, new ItemPropertyChangedEventArgs(propertyName, oldValue, newValue));
        }

        /// <inheritdoc cref="ICloneable.Clone"/>
        /// <summary>
        /// Создает новый объект <see cref="Item"/>, который является копией текущего экземпляра.
        /// </summary>
        /// <returns>
        /// Новый объект <see cref="Item"/> с теми же значениями свойств, но новым идентификатором.
        /// </returns>
        /// <remarks>
        /// Создается глубокая копия: все свойства копируются по значению.
        /// Для ссылочных типов строк создаются новые строки.
        /// </remarks>
        public object Clone()
        {
            return new Item(Name, Info, Cost, Category);
        }

        /// <summary>
        /// Сравнивает текущий товар с другим товаром по содержанию (без учета идентификатора).
        /// </summary>
        /// <param name="other">Товар для сравнения.</param>
        /// <returns>
        /// <see langword="true"/>, если товары имеют одинаковые название, описание, стоимость и категорию;
        /// в противном случае — <see langword="false"/>.
        /// </returns>
        /// <remarks>
        /// Этот метод используется для поиска дубликатов товаров в каталоге.
        /// </remarks>
        public bool ContentEquals(Item other)
        {
            if (other is null) return false;
            return Name == other.Name
                && Info == other.Info
                && Cost == other.Cost
                && Category == other.Category;
        }

        /// <inheritdoc cref="IEquatable{T}.Equals(T)"/>
        /// <summary>
        /// Определяет, равен ли текущий товар другому товару по идентификатору.
        /// </summary>
        /// <param name="other">Товар для сравнения.</param>
        /// <returns>
        /// <see langword="true"/>, если товары имеют одинаковый идентификатор;
        /// в противном случае — <see langword="false"/>.
        /// </returns>
        /// <remarks>
        /// Два товара считаются равными, если они имеют одинаковый идентификатор.
        /// Это соответствует бизнес-логике, где идентификатор уникален для каждого товара.
        /// </remarks>
        public bool Equals(Item other)
        {
            return other is not null && Id == other.Id;
        }

        /// <inheritdoc cref="object.Equals(object)"/>
        /// <summary>
        /// Определяет, равен ли текущий товар указанному объекту.
        /// </summary>
        public override bool Equals(object obj)
        {
            return Equals(obj as Item);
        }

        /// <inheritdoc cref="object.GetHashCode"/>
        /// <summary>
        /// Возвращает хеш-код текущего товара.
        /// </summary>
        /// <returns>
        /// Хеш-код, основанный на идентификаторе товара.
        /// </returns>
        /// <remarks>
        /// Хеш-код вычисляется только по идентификатору, так как он уникален и неизменяем.
        /// Это гарантирует корректную работу с коллекциями, использующими хеширование.
        /// </remarks>
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        /// <inheritdoc cref="IComparable{T}.CompareTo(T)"/>
        /// <summary>
        /// Сравнивает текущий товар с другим товаром для определения порядка сортировки.
        /// </summary>
        /// <param name="other">Товар для сравнения.</param>
        /// <returns>
        /// Целое число, которое указывает отношение порядка между текущим товаром и <paramref name="other"/>:
        /// <list type="bullet">
        /// <item>Меньше нуля — текущий товар должен располагаться перед <paramref name="other"/>.</item>
        /// <item>Нуль — товары имеют одинаковый порядок (но не обязательно равны).</item>
        /// <item>Больше нуля — текущий товар должен располагаться после <paramref name="other"/>.</item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// Сравнение выполняется в следующем порядке:
        /// 1. По категории товара
        /// 2. По названию товара (без учета регистра)
        /// 3. По стоимости товара (если названия совпадают)
        /// </remarks>
        public int CompareTo(Item other)
        {
            if (other is null) return 1;

            int categoryComparison = Category.CompareTo(other.Category);
            if (categoryComparison != 0) return categoryComparison;

            int nameComparison = string.Compare(Name, other.Name, StringComparison.OrdinalIgnoreCase);
            if (nameComparison != 0) return nameComparison;

            return Cost.CompareTo(other.Cost);
        }

        /// <summary>
        /// Определяет, равны ли два указанных экземпляра <see cref="Item"/>.
        /// </summary>
        /// <param name="left">Первый товар для сравнения.</param>
        /// <param name="right">Второй товар для сравнения.</param>
        /// <returns>
        /// <see langword="true"/>, если товары равны; в противном случае — <see langword="false"/>.
        /// </returns>
        public static bool operator ==(Item left, Item right)
        {
            if (ReferenceEquals(left, right)) return true;
            if (left is null || right is null) return false;
            return left.Equals(right);
        }

        /// <summary>
        /// Определяет, не равны ли два указанных экземпляра <see cref="Item"/>.
        /// </summary>
        /// <param name="left">Первый товар для сравнения.</param>
        /// <param name="right">Второй товар для сравнения.</param>
        /// <returns>
        /// <see langword="true"/>, если товары не равны; в противном случае — <see langword="false"/>.
        /// </returns>
        public static bool operator !=(Item left, Item right)
        {
            return !(left == right);
        }

        /// <summary>
        /// Определяет, меньше ли первый товар второго товара.
        /// </summary>
        /// <param name="left">Первый товар для сравнения.</param>
        /// <param name="right">Второй товар для сравнения.</param>
        /// <returns>
        /// <see langword="true"/>, если <paramref name="left"/> меньше <paramref name="right"/>;
        /// в противном случае — <see langword="false"/>.
        /// </returns>
        public static bool operator <(Item left, Item right)
        {
            if (left is null) return right is not null;
            return left.CompareTo(right) < 0;
        }

        /// <summary>
        /// Определяет, больше ли первый товар второго товара.
        /// </summary>
        /// <param name="left">Первый товар для сравнения.</param>
        /// <param name="right">Второй товар для сравнения.</param>
        /// <returns>
        /// <see langword="true"/>, если <paramref name="left"/> больше <paramref name="right"/>;
        /// в противном случае — <see langword="false"/>.
        /// </returns>
        public static bool operator >(Item left, Item right)
        {
            if (left is null) return false;
            return left.CompareTo(right) > 0;
        }

        /// <summary>
        /// Определяет, меньше или равен первый товар второму товару.
        /// </summary>
        /// <param name="left">Первый товар для сравнения.</param>
        /// <param name="right">Второй товар для сравнения.</param>
        /// <returns>
        /// <see langword="true"/>, если <paramref name="left"/> меньше или равен <paramref name="right"/>;
        /// в противном случае — <see langword="false"/>.
        /// </returns>
        public static bool operator <=(Item left, Item right)
        {
            if (left is null) return true;
            return left.CompareTo(right) <= 0;
        }

        /// <summary>
        /// Определяет, больше или равен первый товар второму товару.
        /// </summary>
        /// <param name="left">Первый товар для сравнения.</param>
        /// <param name="right">Второй товар для сравнения.</param>
        /// <returns>
        /// <see langword="true"/>, если <paramref name="left"/> больше или равен <paramref name="right"/>;
        /// в противном случае — <see langword="false"/>.
        /// </returns>
        public static bool operator >=(Item left, Item right)
        {
            if (left is null) return right is null;
            return left.CompareTo(right) >= 0;
        }

        /// <inheritdoc cref="object.ToString"/>
        /// <summary>
        /// Возвращает строковое представление товара.
        /// </summary>
        /// <returns>Строка в формате "Название - Стоимость".</returns>
        public override string ToString()
        {
            return $"{Name} - {Cost:C}";
        }
    }
}