using CRM_System.Models;

namespace CRM_System.IDataModel
{
    public interface IAppData
    {
        public IEnumerable<Message> GetMessages();
    }
}