using BusinessLayer.Abstarct;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class ContentManager : IContentService
    {
        IContentDal _contentDal;

        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }

        public void ContentAdd(Content content)
        {
            throw new System.NotImplementedException();
        }

        public void ContentDelete(Content content)
        {
            throw new System.NotImplementedException();
        }

        public void ContentUpdate(Content content)
        {
            throw new System.NotImplementedException();
        }

        public Content GetByID(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Content> GetList()
        {
            throw new System.NotImplementedException();
        }

        public List<Content> GetListByHeadingID(int id)
        {
            return _contentDal.List(x => x.HeadingId == id);
        }
    }
}
