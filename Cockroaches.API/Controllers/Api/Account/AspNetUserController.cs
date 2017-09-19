using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Text.RegularExpressions;
using System.Web.Http;
using Cockroaches.ApplicationService.Implementation;
using Cockroaches.ApplicationService.Implementation.Contract;
using Cockroaches.Core.Messages;
using Cockroaches.Model;
using Cockroaches.Repository.Queries;
using System.Collections.Generic;

namespace Cockroaches.API.Controllers.Api.Account
{
    /// <summary>
    /// Application User Account
    /// </summary>
    public class AspNetUserController : ApiController
    {
        private ISystemService _systemService;

        /// <summary>
        /// Contructor
        /// </summary>
        public AspNetUserController()
        {
            _systemService = new SystemService();
        }
    }
}