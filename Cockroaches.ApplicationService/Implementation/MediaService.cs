using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Cockroaches.ApplicationService.Implementation.Contract;
using Cockroaches.Core.Messages;
using Cockroaches.Model;
using Cockroaches.Model.Validators;
using Cockroaches.Repository;
using Cockroaches.Repository.Queries;

namespace Cockroaches.ApplicationService
{
    public partial class MediaService : BaseService, IMediaService
    {
        BannerRepository _bannerRepository;
        public MediaService()
        {
            _bannerRepository = new BannerRepository();
        }
       
    }
}
