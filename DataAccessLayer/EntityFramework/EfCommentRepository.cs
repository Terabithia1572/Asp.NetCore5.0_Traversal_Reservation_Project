﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCommentRepository : GenericRepository<Comment>, ICommentDal
    {
        Context context = new();
        public List<Comment> GetListCommentWithDestination()
        {
            return context.Comments.Include(x => x.Destination).ToList();
        }

        public List<Comment> GetListCommentWithDestinationAndUser(int id)
        {
            return context.Comments.Where(x=>x.DestinationID==id).Include(x => x.AppUser).ToList();
        }
    }
}
