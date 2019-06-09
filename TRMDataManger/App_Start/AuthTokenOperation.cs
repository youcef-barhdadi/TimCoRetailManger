using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Description;

namespace TRMDataManger.App_Start
{
    public class AuthTokenOperation : IDocumentFilter
    {
        public void Apply(SwaggerDocument swaggerDoc, SchemaRegistry schemaRegistry, IApiExplorer apiExplorer)
        {
            swaggerDoc.paths.Add("/token", new PathItem
            {
                post = new Operation
                {
                    tags = new List<String> { "Auth" },
                    consumes = new List<string>
                    {
                        "appliction/x-www-form-urlencoded"
                    },
                    parameters = new List<Parameter>
                    {
                        new Parameter
                        {
                            type = "string",
                            name="grant_type" ,
                            required = true,
                            @in ="formData",
                            @default ="password"
                        },
                           new Parameter
                        {
                            type = "string",
                            name="password" ,
                            required = false,
                            @in ="formData"
                        },
                              new Parameter
                        {
                            type = "string",
                            name="username" ,
                            required = false,
                            @in ="formData"
                        }

                    }
                }
            });
        }
    }
}