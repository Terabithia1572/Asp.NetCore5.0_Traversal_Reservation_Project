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
    public class SubAboutManager : ISubAboutService
    {
        ISubAboutDal _subAboutDal;

        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            _subAboutDal = subAboutDal;
        }

        public SubAbout GetByID(int id)
        {
            return _subAboutDal.GetByID(id);
        }

        public void TAdd(SubAbout t)
        {
            _subAboutDal.Insert(t);
        }

        public void TDelete(SubAbout t)
        {
            _subAboutDal.Delete(t);
        }

        public List<SubAbout> TGetList()
        {
            return _subAboutDal.GetListAll();
        }

        public void TUpdate(SubAbout t)
        {
            _subAboutDal.Update(t);
        }
    }
}
