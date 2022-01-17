﻿using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Implementation
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly MovieContext context;

        public ReviewRepository(MovieContext movieContext)
        {
            this.context = movieContext;
        }
        public void Add(Review entity)
        {
            context.Add(entity);
        }

        public void Delete(Review entity)
        {
            throw new NotImplementedException();
        }

        public List<Review> GetAll()
        {
            return context.Reviews.ToList().OfType<Review>().ToList();
        }

        public Review GetSingle(Review entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Review entity)
        {
            throw new NotImplementedException();
        }
    }
}
