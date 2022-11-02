using CRM_System.Models;
using CRM_System.IDataModel;

namespace CRM_System.Data
{
    public class DataList:IAppData
    {
        private IEnumerable<Message> Messages;
        public DataList()
        {
            Messages = new List<Message>()
            {
                new() {Id = 1, AppDate=DateTime.Now.ToString(), Contact="petrov@mail.ru", Text="Подать заявку", Name = "Иван Птеров"},
                new() {Id = 2, AppDate=DateTime.Now.ToString(), Contact="ivanov@mail.ru", Text="Встреча с консультантом", Name = "Григорий Иванов"}
            };
        }
        public IEnumerable<Message> GetMessages()
        {
            return Messages;
        }
    }
}
