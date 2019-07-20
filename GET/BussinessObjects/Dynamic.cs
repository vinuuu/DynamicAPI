using System;
using System.Collections.Generic;
using RealPage.OneSite.All.Common.BusinessObjects;
using RealPage.OneSite.All.Common.BusinessObjects.Attributes;

namespace RealPage.OneSite.Budgeting.BudgetModels.BusinessObjects
{
	/// <summary>
	/// Used to Manage @Dynamic
	/// <summary>
	public class @Dynamic : BusinessObjectBase, I@Dynamic
	{
		#region Private variables
		@Privatevariables
		#endregion

		#region Constructors
		/// <summary>
		/// Create a basic instance of the @Dynamic class
		/// <summary>
		public @Dynamic()
		{
		}
		/// <summary>
		/// Create a basic instance of the @Dynamic class
		/// <summary>
		/// <param name="env">A reference to an initialized Environment class</param>
		public @Dynamic(IEnvironment env) : base(env)
		{
		}
		/// <summary>
		/// Create a basic instance of the @Dynamic class
		/// <summary>
		/// <param name="bob">A reference to an initialized Business Object</param>
		public @Dynamic(BusinessObjectBase bob) : base(bob)
		{
		}
		#endregion

		/// <summary>
		/// Use this to shove any PropertyAttributes based properties into the properties collection
		/// <summary>
		public override void Initialize()
		{
			base.Initialize();
			@Initialize
		}

		#region Serializable properties
         @Serializable		
		#endregion

		#region Examples
		/// <summary>
		/// Used to get an example of the @Dynamic object with test data
		/// </summary>
		/// <returns>List of @Dynamic Model with test data</returns>
		public static List<I@Dynamic> Get@DynamicExample()
		{
			List<I@Dynamic> list = new List<I@Dynamic>();
			I@Dynamic @Dynamic = new @Dynamic()
			@Examples;
			list.Add(@Dynamic);
			return list;
		}
		#endregion
	}
}
