﻿using System.Runtime.Serialization;

namespace BetterCms.Module.Api.Operations.MediaManager.Files.File
{
    [DataContract]
    public class TagModel : ModelBase
    {
        /// <summary>
        /// Gets or sets the tag name.
        /// </summary>
        /// <value>
        /// The tag name.
        /// </value>
        [DataMember]
        public string Name { get; set; }
    }
}