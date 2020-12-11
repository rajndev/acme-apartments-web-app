﻿using AcmeApartments.DAL.Identity;
using AcmeApartments.DAL.Interfaces;
using AcmeApartments.DAL.Models;
using System;

namespace AcmeApartments.DAL.Data
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private ApplicationDbContext _dbContext;
        private GenericRepository<AptUser> _aptUsers;
        private GenericRepository<Application> _applications;
        private GenericRepository<MaintenanceRequest> _maintenanceRequests;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IRepository<AptUser> AptUserRepository
        {
            get
            {
                return _aptUsers ??
                    (_aptUsers = new GenericRepository<AptUser>(_dbContext));
            }
        }

        public IRepository<Application> ApplicationRepository
        {
            get
            {
                return _applications ??
                    (_applications = new GenericRepository<Application>(_dbContext));
            }
        }

        public IRepository<MaintenanceRequest> MaintenanceRequestRepository
        {
            get
            {
                return _maintenanceRequests ??
                    (_maintenanceRequests = new GenericRepository<MaintenanceRequest>(_dbContext));
            }
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
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