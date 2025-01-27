﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Npgsql.EntityFrameworkCore.PostgreSQL.Infrastructure.Internal
{
    /// <summary>
    /// Represents options for Npgsql that can only be set at the <see cref="IServiceProvider"/> singleton level.
    /// </summary>
    public interface INpgsqlOptions : ISingletonOptions
    {
        /// <summary>
        /// The backend version to target.
        /// </summary>
        Version PostgresVersion { get; }

        /// <summary>
        /// True if reverse null ordering is enabled; otherwise, false.
        /// </summary>
        bool ReverseNullOrderingEnabled { get; }

        /// <summary>
        /// The collection of range mappings.
        /// </summary>
        IReadOnlyList<UserRangeDefinition> UserRangeDefinitions { get; }
    }
}
