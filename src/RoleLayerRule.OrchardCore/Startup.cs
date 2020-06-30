using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;
using OrchardCore.Scripting;

namespace RoleLayerRule.OrchardCore {
    public class Startup : StartupBase {
        public override void Configure(IApplicationBuilder app, IEndpointRouteBuilder routes,
            IServiceProvider serviceProvider) {
            var scriptingManager = serviceProvider.GetRequiredService<IScriptingManager>();
            scriptingManager.GlobalMethodProviders.Add(new GlobalMethodProvider());
        }
    }
}