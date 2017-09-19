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
using Newtonsoft.Json;

namespace Cockroaches.Repository
{
    public partial class ItemImagesRepository : BaseRepository<ItemImage>
    {
        public ItemImagesRepository()
        {

        }
       
    }
}
