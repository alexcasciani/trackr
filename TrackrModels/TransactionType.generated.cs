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
	public partial class TransactionType
	{
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
		
		private string _name;
		public virtual string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		
		private string _description;
		public virtual string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				this._description = value;
			}
		}
		
		private DateTime _activeStartDt;
		public virtual DateTime ActiveStartDt
		{
			get
			{
				return this._activeStartDt;
			}
			set
			{
				this._activeStartDt = value;
			}
		}
		
		private DateTime _activeEndDt;
		public virtual DateTime ActiveEndDt
		{
			get
			{
				return this._activeEndDt;
			}
			set
			{
				this._activeEndDt = value;
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
		
		private IList<Transaction> _transactions = new List<Transaction>();
		public virtual IList<Transaction> Transactions
		{
			get
			{
				return this._transactions;
			}
		}
		
	}
}
#pragma warning restore 1591
