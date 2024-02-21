﻿using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AddressManager : IAddressService
    {
        IAddressDal _addressDal;

        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }

        public void Delete(Address t)
        {
            _addressDal.Delete(t);
        }

        public Address GetById(int id)
        {
            return _addressDal.GetByID(id);
        }

        public List<Address> GetListAll()
        {
            return _addressDal.GetListAll();
        }

        public void Insert(Address t)
        {
            _addressDal.Insert(t);
        }

        public void Update(Address t)
        {
            _addressDal.Update(t);
        }
    }
}
