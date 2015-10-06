﻿using System;
using System.Runtime.Serialization;

using BetterCms.Module.Api.Infrastructure;

namespace BetterCms.Module.Api.Operations.Pages.Pages.Search
{
    [DataContract]
    [Serializable]
    public class SearchPagesRequest : RequestBase<SearchPagesModel>
    {
        [DataMember]
        public string SearchString { get; set; }
    }
}