#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
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
	public partial class Program
	{
		private int _programID;
		public virtual int ProgramID
		{
			get
			{
				return this._programID;
			}
			set
			{
				this._programID = value;
			}
		}
		
		private string _programName;
		public virtual string ProgramName
		{
			get
			{
				return this._programName;
			}
			set
			{
				this._programName = value;
			}
		}
		
		private int _clubID;
		public virtual int ClubID
		{
			get
			{
				return this._clubID;
			}
			set
			{
				this._clubID = value;
			}
		}
		
		private Club _club;
		public virtual Club Club
		{
			get
			{
				return this._club;
			}
			set
			{
				this._club = value;
			}
		}
		
		private IList<Team> _teams = new List<Team>();
		public virtual IList<Team> Teams
		{
			get
			{
				return this._teams;
			}
		}
		
	}
}
#pragma warning restore 1591
