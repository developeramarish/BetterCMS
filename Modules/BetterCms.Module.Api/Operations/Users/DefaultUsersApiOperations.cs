﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DefaultUsersApiOperations.cs" company="Devbridge Group LLC">
// 
// Copyright (C) 2015,2016 Devbridge Group LLC
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with this program.  If not, see http://www.gnu.org/licenses/. 
// </copyright>
// 
// <summary>
// Better CMS is a publishing focused and developer friendly .NET open source CMS.
// 
// Website: https://www.bettercms.com 
// GitHub: https://github.com/devbridge/bettercms
// Email: info@bettercms.com
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using BetterCms.Module.Api.Operations.Users.Roles;
using BetterCms.Module.Api.Operations.Users.Roles.Role;
using BetterCms.Module.Api.Operations.Users.Users;
using BetterCms.Module.Api.Operations.Users.Users.User;

namespace BetterCms.Module.Api.Operations.Users
{
    public class DefaultUsersApiOperations : IUsersApiOperations
    {
        public DefaultUsersApiOperations(IUsersService users, IUserService user, IRolesService roles, IRoleService role)
        {
            Users = users;
            User = user;
            Roles = roles;
            Role = role;
        }

        public IUsersService Users
        {
            get; 
            private set;
        }
        
        public IUserService User
        {
            get; 
            private set;
        }
        
        public IRolesService Roles
        {
            get; 
            private set;
        }
        
        public IRoleService Role
        {
            get; 
            private set;
        }
    }
}
