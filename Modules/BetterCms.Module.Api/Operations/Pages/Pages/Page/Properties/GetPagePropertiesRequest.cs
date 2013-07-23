﻿using System.Runtime.Serialization;

using ServiceStack.ServiceHost;

namespace BetterCms.Module.Api.Operations.Pages.Pages.Page.Properties
{
    [Route("/page-properties/{PageId}", Verbs = "GET")]
    [Route("/page-properties/by-url/{PageUrl*}", Verbs = "GET")]
    [DataContract]
    public class GetPagePropertiesRequest : RequestBase<GetPagePropertiesModel>, IReturn<GetPagePropertiesResponse>
    {
    }
}