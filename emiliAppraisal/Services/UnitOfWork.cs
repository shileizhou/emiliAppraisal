using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using emiliAppraisal.DAL;
using emiliAppraisal.Models;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace emiliAppraisal.Services
{
    public class UnitOfWork : IDisposable
    {
        private emiliDB context = new emiliDB();
        private GenericRepository<Referral> referralRepository;

        public virtual int GetNextCMHCNo(Nullable<int> nextCMHCNO)
        {
            var nextCMHCNOParameter = nextCMHCNO.HasValue ?
                new ObjectParameter("NextCMHCNO", nextCMHCNO) :
                new ObjectParameter("NextCMHCNO", typeof(int));

            return ((IObjectContextAdapter)context).ObjectContext.ExecuteFunction("GetNextCMHCNo", nextCMHCNOParameter);
        }

        public GenericRepository<Referral> ReferralRepository
        {
            get
            {

                if (this.referralRepository == null)
                {
                    this.referralRepository = new GenericRepository<Referral>(context);
                }
                return referralRepository;
            }
        }


        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}