using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARINLAB.Services.SessionService
{
    public  class UserDictionary
    {
        private const string SessionKeyName = "_Dictionary";
        private const int DefaultDictionary = 1;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ISession _session;
        public UserDictionary(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _session = _httpContextAccessor.HttpContext.Session;
        }
        public  int GetDictionaryId()
        {            
            if (!string.IsNullOrEmpty(_session.GetString(SessionKeyName)))
            {
                try
                {

                    return int.Parse(_session.GetString(SessionKeyName));

                }catch(Exception e)
                {
                    return DefaultDictionary;
                }
            }
            return DefaultDictionary;
        }

        public void SerDictionary(int dictId)
        {
            _session.SetString(SessionKeyName, $"{dictId}");
        }
        
}
}
