using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cockroaches.ApplicationService.Implementation.Contract;
using Cockroaches.Core.Messages;
using Cockroaches.Model;
using Cockroaches.Model.Validators;
using Cockroaches.Repository;
using Cockroaches.Repository.Queries;

namespace Cockroaches.ApplicationService.Implementation
{
    public class SystemService : BaseService, ISystemService
    {
        protected readonly AspNetRoleRepository _aspNetRoleRepository;
        protected readonly AspNetUserRolesRepository _aspNetUserRolesRepository;
        protected readonly AspNetUsersRepository _userRepository;
        protected readonly ApplicationLoggingRepository _applicationLoggingRepository;
        public SystemService()
        {
            _aspNetRoleRepository = new AspNetRoleRepository();
            _userRepository = new AspNetUsersRepository();
            _aspNetUserRolesRepository = new AspNetUserRolesRepository();
            _applicationLoggingRepository = new ApplicationLoggingRepository();
        }
      
    }
}
