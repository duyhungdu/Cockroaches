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
    public partial class ApplicationLoggingRepository : BaseRepository<ApplicationLogging>
    {
        public ApplicationLoggingRepository()
        {

        }
        public int Log(string type, string action, string modelName, string modelId, string modelProperty, object oldValue, object newValue, string message, string ip, string userId)
        {
            int result = 0;
            ApplicationLogging appLog = new ApplicationLogging();
            appLog.Type = type;
            appLog.Action = action;
            appLog.ModelName = modelName;
            appLog.ModelId = modelId;
            appLog.ModelProperty = modelProperty;
            if (oldValue != null)
            {
                string oldVal = JsonConvert.SerializeObject(oldValue);
                if (string.IsNullOrEmpty(oldVal))
                {
                    appLog.OldValue = oldVal;
                }
            }
            if (newValue != null)
                appLog.NewValue = JsonConvert.SerializeObject(newValue);
            appLog.Message = message;
            appLog.UserHostAddress = ip;
            appLog.CreatedBy = userId;
            appLog.CreatedOn = DateTime.Now;
            try
            {
                result = Add(appLog).Id;
            }
            catch
            {
                result = 0;
            }
            return result;
        }
    }
}
