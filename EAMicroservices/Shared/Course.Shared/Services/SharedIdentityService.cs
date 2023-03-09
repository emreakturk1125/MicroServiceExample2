using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Course.Shared.Services
{
    // Json web Token içerisindeki user Id yi alabilmek için 
    public class SharedIdentityService : ISharedIdentityService
    {
        private IHttpContextAccessor _httpContextAccessor;

        public SharedIdentityService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public string GetUserId => _httpContextAccessor.HttpContext.User.FindFirst("sub").Value;
    }
}