﻿using RealPage.OneSite.All.Common.DBObjects;
namespace RealPage.OneSite.Budgeting.BudgetModels.DBObjects
{
	/// <summary>
	///	interface of @ParentDB Class
	/// </summary>
	public interface I@ParentDB : IDBObjectBase
	{
		/// <summary>
		/// Query to Select @Dynamic
		/// </summary>
		string Get@Dynamic { get; }
	}
}