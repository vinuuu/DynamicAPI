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
		private PropertyAttributes _budgetModelID;
		private PropertyAttributes _pSiteID;
		private PropertyAttributes _budgetYear;
		private PropertyAttributes _budgetType;
		private PropertyAttributes _propertyName;
		private PropertyAttributes _modelName;
		private PropertyAttributes _lastModifiedDate;
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
			_budgetModelID = GetPropertyAttributes("BudgetModelID");
			_pSiteID = GetPropertyAttributes("PSiteID");
			_budgetYear = GetPropertyAttributes("BudgetYear");
			_budgetType = GetPropertyAttributes("BudgetType");
			_propertyName = GetPropertyAttributes("PropertyName");
			_modelName = GetPropertyAttributes("ModelName");
			_lastModifiedDate = GetPropertyAttributes("LastModifiedDate");



		}

		#region Serializable properties

		/// <summary>
		/// Represents the BudgetModelID
		/// </summary>
		[XmlAttributeBehavior
			(PropertyAttributes.PropertyType.Serializable
			, PropertyAttributes.ValueBehavior.SimpleGetterSetter
			)]
		public int BudgetModelID
		{
			get { return (int)_budgetModelID.Value; }
			set { _budgetModelID.Value = value; }
		}

		/// <summary>
		/// Represents the PSiteID
		/// </summary>
		[XmlAttributeBehavior
			(PropertyAttributes.PropertyType.Serializable
			, PropertyAttributes.ValueBehavior.SimpleGetterSetter
			)]
		public int PSiteID
		{
			get { return (int)_pSiteID.Value; }
			set { _pSiteID.Value = value; }
		}

		/// <summary>
		/// Represents the BudgetYear
		/// </summary>
		[XmlAttributeBehavior
			(PropertyAttributes.PropertyType.Serializable
			, PropertyAttributes.ValueBehavior.SimpleGetterSetter
			)]
		public int BudgetYear
		{
			get { return (int)_budgetYear.Value; }
			set { _budgetYear.Value = value; }
		}

		/// <summary>
		/// Represents the BudgetType
		/// </summary>
		[XmlAttributeBehavior
			(PropertyAttributes.PropertyType.Serializable
			, PropertyAttributes.ValueBehavior.SimpleGetterSetter
			)]
		public string BudgetType
		{
			get { return (string)_budgetType.Value; }
			set { _budgetType.Value = value; }
		}

		/// <summary>
		/// Represents the PropertyName
		/// </summary>
		[XmlAttributeBehavior
			(PropertyAttributes.PropertyType.Serializable
			, PropertyAttributes.ValueBehavior.SimpleGetterSetter
			)]
		public string PropertyName
		{
			get { return (string)_propertyName.Value; }
			set { _propertyName.Value = value; }
		}

		/// <summary>
		/// Represents the ModelName
		/// </summary>
		[XmlAttributeBehavior
			(PropertyAttributes.PropertyType.Serializable
			, PropertyAttributes.ValueBehavior.SimpleGetterSetter
			)]
		public string ModelName
		{
			get { return (string)_modelName.Value; }
			set { _modelName.Value = value; }
		}
		/// <summary>
		/// Represents the LastModifiedDate
		/// </summary>
		[XmlAttributeBehavior
			(PropertyAttributes.PropertyType.Serializable
			, PropertyAttributes.ValueBehavior.SimpleGetterSetter
			)]
		public string LastModifiedDate
		{
			get { return (string)_lastModifiedDate.Value; }
			set { _modelName.Value = value; }
		}
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
			{
				BudgetModelID = 1,
				PSiteID = 1,
				BudgetYear = 2017,
				BudgetType = "Budegt",
				PropertyName = "Property",
				ModelName = "MM",
				LastModifiedDate="01-01-2016"
			};
			list.Add(@Dynamic);

			@Dynamic = new @Dynamic()
			{
				BudgetModelID = 1,
				PSiteID = 1,
				BudgetYear = 2017,
				BudgetType = "Budegt",
				PropertyName = "Property",
				ModelName = "MM",
				LastModifiedDate = "01-01-2016"
			};
			list.Add(@Dynamic);
			return list;
		}
		#endregion
	}
}
