﻿using System.Runtime.Serialization;

using ServiceStack.ServiceHost;

namespace BetterCms.Module.Api.Operations.Pages.Widgets.Widget.HtmlContentWidget
{
    [Route("/widgets/html-content/{WidgetId}", Verbs = "GET")]
    [DataContract]
    public class GetHtmlContentWidgetRequest : RequestBase<GetHtmlContentWidgetModel>, IReturn<GetHtmlContentWidgetResponse>
    {
    }
}