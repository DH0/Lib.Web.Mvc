﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Routing;
using System.Web.Mvc;
using System.Web;

namespace Lib.Web.Mvc.JQuery.JqGrid.DataAnnotations
{
    /// <summary>
    /// Specifies the searching options for column
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class JqGridColumnSearchableAttribute : JqGridColumnElementAttribute, IMetadataAware
    {
        #region Properties
        /// <summary>
        /// Gets or sets if the value is required while searching.
        /// </summary>
        public bool RequiredValidation
        {
            get { return Rules.Required; }
            set { Rules.Required = value; }
        }

        /// <summary>
        /// Gets the value defining if this column can be searched.
        /// </summary>
        public bool Searchable { get; private set; }

        /// <summary>
        /// Gets or sets the value which defines if hidden column can be searched.
        /// </summary>
        public bool SearchHidden
        {
            get { return SearchOptions.SearchHidden; }
            set { SearchOptions.SearchHidden = value; }
        }

        /// <summary>
        /// Gets or sets the available search operators for the column (default JqGridSearchOperators.Eq).
        /// </summary>
        public JqGridSearchOperators SearchOperators
        {
            get { return SearchOptions.SearchOperators; }
            set { SearchOptions.SearchOperators = value; }
        }

        private JqGridColumnSearchOptions SearchOptions
        {
            get { return (base.Options as JqGridColumnSearchOptions); }
            set { base.Options = value; }
        }

        /// <summary>
        /// Gets or sets the type of the search field (default JqGridColumnSearchTypes.Text).
        /// </summary>
        public JqGridColumnSearchTypes SearchType { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the JqGridColumnSearchableAttribute class.
        /// </summary>
        /// <param name="searchable">If this column can be searched</param>
        public JqGridColumnSearchableAttribute(bool searchable)
        {
            Searchable = searchable;
            SearchOptions = new JqGridColumnSearchOptions();
            Rules = new JqGridColumnRules();
            SearchType = JqGridColumnSearchTypes.Text;
        }

        /// <summary>
        /// Initializes a new instance of the JqGridColumnSearchableAttribute class.
        /// </summary>
        /// <param name="searchable">If this column can be searched</param>
        /// <param name="dataUrlRouteName">Route name for the URL to get the AJAX data for the select element (if is JqGridColumnSearchTypes.Select)</param>
        public JqGridColumnSearchableAttribute(bool searchable, string dataUrlRouteName)
            : this(searchable)
        {
            if (String.IsNullOrWhiteSpace(dataUrlRouteName))
                throw new ArgumentNullException("dataUrlRouteName");
            

            DataUrlRouteName = dataUrlRouteName;
            DataUrlRouteData = new RouteValueDictionary();
        }

        /// <summary>
        /// Initializes a new instance of the JqGridColumnSearchableAttribute class.
        /// </summary>
        /// <param name="searchable">If this column can be searched</param>
        /// <param name="dataUrlAction">Action for the URL to get the AJAX data for the select element (if is JqGridColumnSearchTypes.Select)</param>
        /// <param name="dataUrlController">Controller for the URL to get the AJAX data for the select element (if is JqGridColumnSearchTypes.Select)</param>
        public JqGridColumnSearchableAttribute(bool searchable, string dataUrlAction, string dataUrlController) :
            this(searchable, dataUrlAction, dataUrlController, null)
        { }

        /// <summary>
        /// Initializes a new instance of the JqGridColumnSearchableAttribute class.
        /// </summary>
        /// <param name="searchable">If this column can be searched</param>
        /// <param name="dataUrlAction">Action for the URL to get the AJAX data for the select element (if is JqGridColumnSearchTypes.Select)</param>
        /// <param name="dataUrlController">Controller for the URL to get the AJAX data for the select element (if is JqGridColumnSearchTypes.Select)</param>
        /// <param name="dataUrlAreaName">Area for the URL to get the AJAX data for the select element (if is JqGridColumnSearchTypes.Select)</param>
        public JqGridColumnSearchableAttribute(bool searchable, string dataUrlAction, string dataUrlController, string dataUrlAreaName)
            : this(searchable)
        {
            if (String.IsNullOrWhiteSpace(dataUrlAction))
                throw new ArgumentNullException("dataUrlAction");
            
            if (String.IsNullOrWhiteSpace(dataUrlController))
                throw new ArgumentNullException("dataUrlController");

            DataUrlRouteData = new RouteValueDictionary();
            DataUrlRouteData["controller"] = dataUrlController;
            DataUrlRouteData["action"] = dataUrlAction;

            if (!String.IsNullOrWhiteSpace(dataUrlAreaName))
                DataUrlRouteData["area"] = dataUrlAreaName;
        }
        #endregion

        #region IMetadataAware
        /// <summary>
        /// Provides metadata to the model metadata creation process.
        /// </summary>
        /// <param name="metadata">The model metadata.</param>
        public void OnMetadataCreated(ModelMetadata metadata)
        {
            SearchOptions.DataEvents = DataEvents;
            SearchOptions.DataUrl = DataUrl;
            SearchOptions.HtmlAttributes = HtmlAttributes;

            if ((metadata.ModelType == typeof(Int16)) || (metadata.ModelType == typeof(Int32)) || (metadata.ModelType == typeof(Int64)) || (metadata.ModelType == typeof(UInt16)) || (metadata.ModelType == typeof(UInt32)) || (metadata.ModelType == typeof(UInt32)))
                Rules.Integer = true;
            else if ((metadata.ModelType == typeof(Decimal)) || (metadata.ModelType == typeof(Double)) || (metadata.ModelType == typeof(Single)))
                Rules.Number = true;

            metadata.SetColumnSearchable(Searchable);
            metadata.SetColumnSearchOptions(SearchOptions);
            metadata.SetColumnSearchRules(Rules);
            metadata.SetColumnSearchType(SearchType);
        }
        #endregion
    }
}
