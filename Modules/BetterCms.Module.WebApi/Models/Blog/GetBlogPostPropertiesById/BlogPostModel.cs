﻿using System.Runtime.Serialization;

namespace BetterCms.Module.WebApi.Models.Blog.GetBlogPostPropertiesById
{
    [DataContract]
    public class BlogPostModel : ModelBase
    {
        /// <summary>
        /// Gets or sets the blog post URL.
        /// </summary>
        /// <value>
        /// The blog post URL.
        /// </value>
        [DataMember(Order = 10, Name = "blogPostUrl")]
        public string BlogPostUrl { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [DataMember(Order = 20, Name = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the intro text.
        /// </summary>
        /// <value>
        /// The intro text.
        /// </value>
        [DataMember(Order = 25, Name = "introText")]
        public string IntroText { get; set; }

        /// <summary>
        /// Gets or sets the page status.
        /// </summary>
        /// <value>
        /// The page status.
        /// </value>
        [DataMember(Order = 30, Name = "isPublished")]
        public bool IsPublished { get; set; }

        /// <summary>
        /// Gets or sets the page published date.
        /// </summary>
        /// <value>
        /// The page published date.
        /// </value>
        [DataMember(Order = 40, Name = "publishedOn")]
        public System.DateTime? PublishedOn { get; set; }

        /// <summary>
        /// Gets or sets the page layout id.
        /// </summary>
        /// <value>
        /// The page layout id.
        /// </value>
        [DataMember(Order = 50, Name = "layoutId")]
        public System.Guid LayoutId { get; set; }

        /// <summary>
        /// Gets or sets the category id.
        /// </summary>
        /// <value>
        /// The category id.
        /// </value>
        [DataMember(Order = 60, Name = "categoryId")]
        public System.Guid? CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the blog post author id.
        /// </summary>
        /// <value>
        /// The blog post author id.
        /// </value>
        [DataMember(Order = 70, Name = "authorId")]
        public System.Guid? AuthorId { get; set; }

        /// <summary>
        /// Gets or sets the blog post activation date.
        /// </summary>
        /// <value>
        /// The blog post activation date.
        /// </value>
        [DataMember(Order = 80, Name = "activationDate")]
        public System.DateTime ActivationDate { get; set; }

        /// <summary>
        /// Gets or sets the blog post expiration date.
        /// </summary>
        /// <value>
        /// The blog post expiration date.
        /// </value>
        [DataMember(Order = 90, Name = "expirationDate")]
        public System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Gets or sets the featured main image id.
        /// </summary>
        /// <value>
        /// The main image id.
        /// </value>
        [DataMember(Order = 100, Name = "mainImageId")]
        public System.Guid? MainImageId { get; set; }

        /// <summary>
        /// Gets or sets the featured image id.
        /// </summary>
        /// <value>
        /// The featured image id.
        /// </value>
        [DataMember(Order = 110, Name = "featuredImageId")]
        public System.Guid? FeaturedImageId { get; set; }

        /// <summary>
        /// Gets or sets the secondary image id.
        /// </summary>
        /// <value>
        /// The secondary image id.
        /// </value>
        [DataMember(Order = 120, Name = "secondaryImageId")]
        public System.Guid? SecondaryImageId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use canonical URL.
        /// </summary>
        /// <value>
        ///   <c>true</c> if to use canonical URL; otherwise, <c>false</c>.
        /// </value>
        [DataMember(Order = 130, Name = "useCanonicalUrl")]
        public bool UseCanonicalUrl { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use no follow.
        /// </summary>
        /// <value>
        ///   <c>true</c> if to use no follow; otherwise, <c>false</c>.
        /// </value>
        [DataMember(Order = 140, Name = "useNoFollow")]
        public bool UseNoFollow { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use no index.
        /// </summary>
        /// <value>
        ///   <c>true</c> if to use no index; otherwise, <c>false</c>.
        /// </value>
        [DataMember(Order = 150, Name = "useNoIndex")]
        public bool UseNoIndex { get; set; }
    }
}