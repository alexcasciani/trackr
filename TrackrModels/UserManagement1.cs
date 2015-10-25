﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ContextGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using TrackrModels;

namespace TrackrModels	
{
	public partial class UserManagement : OpenAccessContext, IUserManagementUnitOfWork
	{
		private static string connectionStringName = @"UserManagementConnection";
			
		private static BackendConfiguration backend = GetBackendConfiguration();
				
		private static MetadataSource metadataSource = XmlMetadataSource.FromAssemblyResource("UserManagement.rlinq");
		
		public UserManagement()
			:base(connectionStringName, backend, metadataSource)
		{ }
		
		public UserManagement(string connection)
			:base(connection, backend, metadataSource)
		{ }
		
		public UserManagement(BackendConfiguration backendConfiguration)
			:base(connectionStringName, backendConfiguration, metadataSource)
		{ }
			
		public UserManagement(string connection, MetadataSource metadataSource)
			:base(connection, backend, metadataSource)
		{ }
		
		public UserManagement(string connection, BackendConfiguration backendConfiguration, MetadataSource metadataSource)
			:base(connection, backendConfiguration, metadataSource)
		{ }
			
		public IQueryable<WebUser> WebUsers 
		{
			get
			{
				return this.GetAll<WebUser>();
			}
		}
		
		public IQueryable<Scope> Scopes 
		{
			get
			{
				return this.GetAll<Scope>();
			}
		}
		
		public IQueryable<ScopeAssignment> ScopeAssignments 
		{
			get
			{
				return this.GetAll<ScopeAssignment>();
			}
		}
		
		public IQueryable<Role> Roles 
		{
			get
			{
				return this.GetAll<Role>();
			}
		}
		
		public IQueryable<Permission> Permissions 
		{
			get
			{
				return this.GetAll<Permission>();
			}
		}
		
		public static BackendConfiguration GetBackendConfiguration()
		{
			BackendConfiguration backend = new BackendConfiguration();
			backend.Backend = "MsSql";
			backend.ProviderName = "System.Data.SqlClient";
		
			CustomizeBackendConfiguration(ref backend);
		
			return backend;
		}
		
		/// <summary>
		/// Allows you to customize the BackendConfiguration of UserManagement.
		/// </summary>
		/// <param name="config">The BackendConfiguration of UserManagement.</param>
		static partial void CustomizeBackendConfiguration(ref BackendConfiguration config);
		
	}
	
	public interface IUserManagementUnitOfWork : IUnitOfWork
	{
		IQueryable<WebUser> WebUsers
		{
			get;
		}
		IQueryable<Scope> Scopes
		{
			get;
		}
		IQueryable<ScopeAssignment> ScopeAssignments
		{
			get;
		}
		IQueryable<Role> Roles
		{
			get;
		}
		IQueryable<Permission> Permissions
		{
			get;
		}
	}
}
#pragma warning restore 1591