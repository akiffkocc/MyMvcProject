﻿using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstarct
{
    public interface IContactService
    {
        List<Contact> GetList();
        void ContactAdd(Contact contact);
        Contact GetByID(int id);
        void ContactDelete(Contact contact);
        void ContactUpdate(Contact contact);
    }
}
