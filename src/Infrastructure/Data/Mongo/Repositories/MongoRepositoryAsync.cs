﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MongoDB.Driver;
using SharedKernel.Domain.Aggregates;
using SharedKernel.Domain.Entities;
using SharedKernel.Domain.Repositories;

#pragma warning disable 693

namespace SharedKernel.Infrastructure.Data.Mongo.Repositories
{
    public abstract class MongoRepositoryAsync<TAggregateRoot, TKey> : MongoRepository<TAggregateRoot, TKey>,
        ICreateRepositoryAsync<TAggregateRoot>,
        IReadRepositoryAsync<TAggregateRoot>,
        IUpdateRepositoryAsync<TAggregateRoot>,
        IDeleteRepositoryAsync<TAggregateRoot>
        where TAggregateRoot : class, IAggregateRoot, IEntity<TKey>
    {
        protected MongoRepositoryAsync(MongoClient mongoClient, string database) : base(mongoClient, database)
        {
        }

        public Task AddAsync(TAggregateRoot aggregate, CancellationToken cancellationToken)
        {
            return MongoCollection.InsertOneAsync(aggregate, cancellationToken: cancellationToken);
        }

        public Task AddRangeAsync(IEnumerable<TAggregateRoot> aggregates, CancellationToken cancellationToken)
        {
            return MongoCollection.InsertManyAsync(aggregates, cancellationToken: cancellationToken);
        }

        public Task<TAggregateRoot> GetByIdAsync<TKey>(TKey key, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<TAggregateRoot> GetDeleteByIdAsync<TKey>(TKey key, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AnyAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AnyAsync<TKey>(TKey key, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TAggregateRoot entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRangeAsync(IEnumerable<TAggregateRoot> entities, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(TAggregateRoot aggregate, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task RemoveRangeAsync(IEnumerable<TAggregateRoot> aggregate, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        //public Task<List<TAggregateRoot>> WhereAsync(ISpecification<TAggregateRoot> spec, CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<TAggregateRoot> SingleAsync(ISpecification<TAggregateRoot> spec, CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<TAggregateRoot> SingleOrDefaultAsync(ISpecification<TAggregateRoot> spec, CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<bool> AnyAsync(ISpecification<TAggregateRoot> spec, CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<int> RollbackAsync(CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}
    }
}