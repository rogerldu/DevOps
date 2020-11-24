using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroService
{
    public class JwtIssuerOptions
    {
        public string Secret { get; set; } = "2f5ae96c-b558-4c7b-a590-a501ae1c3f6c";
    }
}
