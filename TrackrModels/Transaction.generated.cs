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
	public partial class Transaction
	{
		private long _transactionID;
		public virtual long TransactionID
		{
			get
			{
				return this._transactionID;
			}
			set
			{
				this._transactionID = value;
			}
		}
		
		private decimal _amount;
		public virtual decimal Amount
		{
			get
			{
				return this._amount;
			}
			set
			{
				this._amount = value;
			}
		}
		
		private int _transactionTypeID;
		public virtual int TransactionTypeID
		{
			get
			{
				return this._transactionTypeID;
			}
			set
			{
				this._transactionTypeID = value;
			}
		}
		
		private string _publicNotes;
		public virtual string PublicNotes
		{
			get
			{
				return this._publicNotes;
			}
			set
			{
				this._publicNotes = value;
			}
		}
		
		private string _privateNotes;
		public virtual string PrivateNotes
		{
			get
			{
				return this._privateNotes;
			}
			set
			{
				this._privateNotes = value;
			}
		}
		
		private DateTime _date;
		public virtual DateTime Date
		{
			get
			{
				return this._date;
			}
			set
			{
				this._date = value;
			}
		}
		
		private int _playerID;
		public virtual int PlayerID
		{
			get
			{
				return this._playerID;
			}
			set
			{
				this._playerID = value;
			}
		}
		
		private bool _active;
		public virtual bool Active
		{
			get
			{
				return this._active;
			}
			set
			{
				this._active = value;
			}
		}
		
		private DateTime _createDt;
		public virtual DateTime CreateDt
		{
			get
			{
				return this._createDt;
			}
			set
			{
				this._createDt = value;
			}
		}
		
		private int _createUserID;
		public virtual int CreateUserID
		{
			get
			{
				return this._createUserID;
			}
			set
			{
				this._createUserID = value;
			}
		}
		
		private DateTime? _modifyDt;
		public virtual DateTime? ModifyDt
		{
			get
			{
				return this._modifyDt;
			}
			set
			{
				this._modifyDt = value;
			}
		}
		
		private int? _modifyUserID;
		public virtual int? ModifyUserID
		{
			get
			{
				return this._modifyUserID;
			}
			set
			{
				this._modifyUserID = value;
			}
		}
		
		private Player _player;
		public virtual Player Player
		{
			get
			{
				return this._player;
			}
			set
			{
				this._player = value;
			}
		}
		
		private TransactionType _transactionType;
		public virtual TransactionType TransactionType
		{
			get
			{
				return this._transactionType;
			}
			set
			{
				this._transactionType = value;
			}
		}
		
		private WebUserInfo _webUserInfo;
		public virtual WebUserInfo WebUserInfo
		{
			get
			{
				return this._webUserInfo;
			}
			set
			{
				this._webUserInfo = value;
			}
		}
		
		private WebUserInfo _webUserInfo1;
		public virtual WebUserInfo WebUserInfo1
		{
			get
			{
				return this._webUserInfo1;
			}
			set
			{
				this._webUserInfo1 = value;
			}
		}
		
	}
}
#pragma warning restore 1591