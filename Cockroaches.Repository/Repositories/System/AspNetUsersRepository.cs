using Cockroaches.Model;
using Cockroaches.Repository.Queries;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cockroaches.Repository.Infrastructure;
using Cockroaches.Model;

namespace Cockroaches.Repository
{
    public partial class AspNetUsersRepository : BaseRepository<AspNetUser>
    {
        public AspNetUsersRepository()
        {
           
        }
    }
}
