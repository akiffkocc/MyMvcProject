using BusinessLayer.Abstarct;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public Message GetByID(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Message> GetList()
        {
            return _messageDal.List(x => x.ReceiverMail == "admin@gmail.com");
        }

        public void MessageAdd(Message message)
        {
            throw new System.NotImplementedException();
        }

        public void MessageDelete(Message message)
        {
            throw new System.NotImplementedException();
        }

        public void MessageUpdate(Message message)
        {
            throw new System.NotImplementedException();
        }
    }
}
