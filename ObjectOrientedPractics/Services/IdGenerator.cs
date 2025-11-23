namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Генератор уникальных идентификаторов.
    /// </summary>
    public static class IdGenerator
    {
        private static int _nextId = 1;

        /// <summary>
        /// Возвращает следующий уникальный идентификатор.
        /// </summary>
        /// <returns>Уникальный идентификатор.</returns>
        public static int GetNextId()
        {
            return _nextId++;
        }
    }
}