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
	[System.Serializable()]
	public partial class TeamPlayer : System.Runtime.Serialization.ISerializable
	{
		private int _teamPlayerID;
		public virtual int TeamPlayerID
		{
			get
			{
				return this._teamPlayerID;
			}
			set
			{
				this._teamPlayerID = value;
			}
		}
		
		private int _teamID;
		public virtual int TeamID
		{
			get
			{
				return this._teamID;
			}
			set
			{
				this._teamID = value;
			}
		}
		
		private int _playerPassID;
		public virtual int PlayerPassID
		{
			get
			{
				return this._playerPassID;
			}
			set
			{
				this._playerPassID = value;
			}
		}
		
		private bool _isSecondary;
		public virtual bool IsSecondary
		{
			get
			{
				return this._isSecondary;
			}
			set
			{
				this._isSecondary = value;
			}
		}
		
		private Team _team;
		public virtual Team Team
		{
			get
			{
				return this._team;
			}
			set
			{
				this._team = value;
			}
		}
		
		private PlayerPass _playerPass;
		public virtual PlayerPass PlayerPass
		{
			get
			{
				return this._playerPass;
			}
			set
			{
				this._playerPass = value;
			}
		}
		
		#region ISerializable Implementation
		
		public TeamPlayer()
		{
		}
		
		protected TeamPlayer(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			this.TeamPlayerID = info.GetInt32("TeamPlayerID");
			this.TeamID = info.GetInt32("TeamID");
			this.PlayerPassID = info.GetInt32("PlayerPassID");
			this.IsSecondary = info.GetBoolean("IsSecondary");
			CustomizeDeserializationProcess(info, context);
		}
		
		public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			info.AddValue("TeamPlayerID", this.TeamPlayerID, typeof(int));
			info.AddValue("TeamID", this.TeamID, typeof(int));
			info.AddValue("PlayerPassID", this.PlayerPassID, typeof(int));
			info.AddValue("IsSecondary", this.IsSecondary, typeof(bool));
			CustomizeSerializationProcess(info, context);
		}
		
		partial void CustomizeSerializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		partial void CustomizeDeserializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		#endregion
	}
}
#pragma warning restore 1591
