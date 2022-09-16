using CRM_System.DataBase;
using CRM_System.IDataModel;
using CRM_System.Models;

namespace CRM_System.Data
{
    public class PostrgreDb : IAppData 
    {
        private PostDatabase context; 
        public PostrgreDb(PostDatabase context)
        { 
            this.context = context; 
        }
        public IEnumerable<Message> GetMessages()
        { 
            return context.MessageData;
        }
    }
}
