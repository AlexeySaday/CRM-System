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
                new() {Id = Guid.NewGuid().ToString(), AppDate=DateTime.Now, Contact="petrov@mail.ru", MessageText="Подать заявку", Name = "Иван Птеров"},
                new() {Id = Guid.NewGuid().ToString(), AppDate=DateTime.Now, Contact="ivanov@mail.ru", MessageText="Встреча с консультантом", Name = "Григорий Иванов"}
            };
        }
        public IEnumerable<Message> GetMessages()
        {
            return Messages;
        }
    }
}
