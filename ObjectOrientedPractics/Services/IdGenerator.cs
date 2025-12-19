namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет методы для генерации уникальных идентификаторов.
    /// </summary>
    public static class IdGenerator
    {
        private static int _nextItemId = 1;
        private static int _nextCustomerId = 1;
        private static int _nextOrderId = 1;

        /// <summary>
        /// Возвращает следующий идентификатор товара.
        /// </summary>
        public static int GetNextItemId() => _nextItemId++;

        /// <summary>
        /// Возвращает следующий идентификатор покупателя.
        /// </summary>
        public static int GetNextCustomerId() => _nextCustomerId++;

        /// <summary>
        /// Возвращает следующий идентификатор заказа.
        /// </summary>
        public static int GetNextOrderId() => _nextOrderId++;

        /// <summary>
        /// Сбрасывает генераторы идентификаторов.
        /// </summary>
        public static void Reset()
        {
            _nextItemId = 1;
            _nextCustomerId = 1;
            _nextOrderId = 1;
        }
    }
}