using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstarct
{
    public interface IHeadingService
    {
        List<Heading> GetList();
        void HeadingAdd(Heading heading);
        Heading GetById(int id);
        void HeadingDelete(Heading heading);
        void HeadingUpdate(Heading heading);
    }
}
