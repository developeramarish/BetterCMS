﻿namespace BetterCms.Core.Models
{
    /// <summary>
    /// Defines interface to access basic content properties.
    /// </summary>
    public interface IContent : IEntity
    {
        string Name { get; }

        string PreviewUrl { get; }
    }
}
