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
            context.MessageData.Add(new() { AppDate = DateTime.Now.ToString(), Name = "Игорь", Text = "Оставить заявку", Contact = "pterov@mail.ru" });
            context.SaveChanges();
        }
        public IEnumerable<Message> GetMessages()
        {
            //logger.LogCritical($"----->{context.Messages}");
            return context.MessageData;
        }
    }
}
