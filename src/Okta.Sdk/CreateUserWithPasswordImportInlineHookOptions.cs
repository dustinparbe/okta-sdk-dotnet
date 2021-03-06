﻿// <copyright file="CreateUserWithPasswordOptions.cs" company="Okta, Inc">
// Copyright (c) 2014 - present Okta, Inc. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.
// </copyright>

namespace Okta.Sdk
{
    /// <summary>
    /// Contains the options for creating a new <see cref="IUser">User</see> with password import inline hook.
    /// Used with <see cref="IUsersClient.CreateUserAsync(CreateUserWithPasswordImportInlineHookOptions, System.Threading.CancellationToken)"/>.
    /// </summary>
    /// <remarks>See <a href="https://developer.okta.com/docs/reference/api/users/#create-user-with-password-import-inline-hook">Create User with Password Import Inline Hook</a> in the documentation.</remarks>
    public sealed class CreateUserWithPasswordImportInlineHookOptions
    {
        /// <summary>
        /// Gets or sets the new user's profile.
        /// </summary>
        /// <value>
        /// The user's profile.
        /// </value>
        public UserProfile Profile { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the new user should be activated immediately.
        /// </summary>
        /// <remarks>The default value is <c>true</c> (users will be activated immediately).</remarks>
        /// <value>
        /// Whether the new user should be activated immediately.
        /// </value>
        public bool Activate { get; set; } = true;
    }
}
