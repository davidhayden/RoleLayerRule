using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Scripting;

namespace RoleLayerRule.OrchardCore {
    public class GlobalMethodProvider : IGlobalMethodProvider {
        private readonly GlobalMethod _role;

        public GlobalMethodProvider() {
            _role = new GlobalMethod {
                Name = "role",
                Method = serviceprovider => (Func<string, object>) (role => {
                    var httpContext = serviceprovider.GetRequiredService<IHttpContextAccessor>().HttpContext;
                    var user = httpContext.User;

                    if (user == null || !user.Identity.IsAuthenticated)
                        return false;

                    return user.IsInRole(role);
                })
            };
        }

        public IEnumerable<GlobalMethod> GetMethods() {
            return new[] {_role};
        }
    }
}