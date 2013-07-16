﻿using System.Runtime.Serialization;

namespace BetterCms.Module.Api.Operations.Pages.Redirects
{
    [DataContract]
    public class RedirectModel : ModelBase
    {
        /// <summary>
        /// Gets or sets the page URL.
        /// </summary>
        /// <value>
        /// The page URL.
        /// </value>
        [DataMember]
        public string PageUrl { get; set; }

        /// <summary>
        /// Gets or sets the redirect URL.
        /// </summary>
        /// <value>
        /// The redirect URL.
        /// </value>
        [DataMember]
        public string RedirectUrl { get; set; }
    }
}