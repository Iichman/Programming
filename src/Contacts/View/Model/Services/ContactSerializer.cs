using System.IO;
using Newtonsoft.Json;
using View.Model;

namespace View.Model.Services
{
    /// <summary>
    /// Класс для сохранения и загрузки контакта в JSON.
    /// </summary>
    public static class ContactSerializer
    {
        /// <summary>
        /// Путь к файлу по умолчанию (Documents/Contacts/contacts.json).
        /// </summary>
        private static readonly string _filePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "Contacts", "contacts.json");

        /// <summary>
        /// Сохраняет контакт в файл.
        /// </summary>
        /// <param name="contact">Контакт для сохранения.</param>
        public static void Save(Contact contact)
        {
            string? directoryPath = Path.GetDirectoryName(_filePath);
            if (!string.IsNullOrEmpty(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string json = JsonConvert.SerializeObject(contact, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }

        /// <summary>
        /// Загружает контакт из файла.
        /// </summary>
        /// <returns>Загруженный контакт или новый, если файл не найден.</returns>
        public static Contact Load()
        {
            if (!File.Exists(_filePath))
                return new Contact();

            string json = File.ReadAllText(_filePath);
            Contact? contact = JsonConvert.DeserializeObject<Contact>(json);

            return contact ?? new Contact();
        }
    }
}