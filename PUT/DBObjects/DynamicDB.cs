﻿using System.Collections;
using RealPage.OneSite.All.Common.DBObjects;
using RealPage.OneSite.All.Common.BusinessObjects;
using System.Diagnostics.CodeAnalysis;

namespace RealPage.OneSite.Budgeting.BudgetModels.DBObjects
{
	/// <summary>
	/// BudgetModel DB class provides all the queries related to BudgetModel and its details
	/// </summary>
	[ExcludeFromCodeCoverage]
	public class @ParentDB : DBObjectBase, I@ParentDB
	{
		#region Constructor
		/// <summary>
		/// Create an instance of a @ParentDB DB Object
		/// </summary>
		/// <param name="businessObject"></param>
		/// <param name="parameters"></param>
		public @ParentDB(IBusinessObjectBase businessObject, Hashtable parameters)
			: base(businessObject, parameters)
		{
		}
		#endregion

		#region SetMap

		/// <summary>
		/// This adds a list of strongly typed parameters that may be referenced in a prepared SQL statement.
		/// </summary>
		protected override void SetMap()
		{
			
		}
		#endregion
		#region Public Methods
		#region Update@Dynamic
		/// <summary>
		/// Query to Insert/Update Comment
		/// </summary>
		public string Update@Dynamic
		{
			get
			{
				string query = @"
				SET NOCOUNT ON

				EXEC [dbo].[uspBgt@DynamicUpdate]
					@InternalEntityID = @PmcID,
					@InternalUserID = @UserID,
					@InternalSiteID = @SiteID,
					@CommentID	= @CommentID,
					@DistributedID = @DistributedID,
					@GLAccountNumber = @GLAccountNumber,
					@Comment = @Comment,
					@CommentSource	 = @CommentSource,
					@UnitTypeID	= @UnitTypeID,
					@UnitID = @UnitID,
					@WorksheetID = @WorksheetID,
					@AptNumber = @AptNumber,
					@ProgramID = @ProgramID,
					@TenantBudgetID = @TenantBudgetID,
					@ServiceGroupID = @ServiceGroupID,
					@VisibleToAll = @VisibleToAll,
					@PinUntilDate = @PinUntilDate,
                    @ProformaUnitTypeID = @ProformaUnitTypeID
                ";

				return query;
			}
		}
		#endregion
		#endregion
	}


}
