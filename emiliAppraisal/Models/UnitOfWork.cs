using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace emiliAppraisal.Models
{
    public class UnitOfWork : IDisposable
    {
        private SyrasContext context = new SyrasContext();
        private GenericRepository<Worker> workerRepository;
        private GenericRepository<Enterprise> enterpriseRepository;
        private GenericRepository<Car> carRepository;

        public GenericRepository<Worker> WorkerRepository
        {
            get
            {

                if (this.workerRepository == null)
                {
                    this.workerRepository = new GenericRepository<Worker>(context);
                }
                return workerRepository;
            }
        }

        public GenericRepository<Enterprise> EnterpriseRepository
        {
            get
            {

                if (this.enterpriseRepository == null)
                {
                    this.enterpriseRepository = new GenericRepository<Enterprise>(context);
                }
                return enterpriseRepository;
            }
        }

        public GenericRepository<Car> CarRepository
        {
            get
            {

                if (this.carRepository == null)
                {
                    this.carRepository = new GenericRepository<Car>(context);
                }
                return carRepository;
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