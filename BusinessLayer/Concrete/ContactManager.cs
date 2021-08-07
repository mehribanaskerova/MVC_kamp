﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void ContactAddBL(Contact contact)
        {
            _contactDal.Insert(contact);
        }

        public void ContactDeleteBL(Contact contact)
        {
            _contactDal.Delete(contact);
        }

        public void ContactUpdateBL(Contact contact)
        {
            _contactDal.Update(contact);
        }

        public Contact GetByIDBL(int id)
        {
            return _contactDal.Get(x => x.ContactID == id);
        }

        public List<Contact> GetListBL()
        {
            return _contactDal.List();
        }
    }
}