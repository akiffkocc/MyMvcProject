using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstarct
{
    public interface IMessageService
    {
        List<Message> GetList();
        void MessageAdd(Message message);
        Message GetByID(int id);
        void MessageDelete(Message message);
        void MessageUpdate(Message message);
    }
}
