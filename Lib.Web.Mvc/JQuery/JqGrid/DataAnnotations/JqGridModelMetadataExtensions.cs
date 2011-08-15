﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Lib.Web.Mvc.JQuery.JqGrid.DataAnnotations
{
    internal static class JqGridModelMetadataExtensions
    {
        #region Fields
        private const string _searchableKey = "JqGridColumnModel.Searchable";
        private const string _searchOptionsKey = "JqGridColumnModel.SearchOptions";
        private const string _searchRulesKey = "JqGridColumnModel.SearchRules";
        private const string _searchTypeKey = "JqGridColumnModel.SearchType";
        private const string _summaryTypeKey = "JqGridColumnModel.SummaryType";
        private const string _summaryTemplateKey = "JqGridColumnModel.SummaryTemplate";
        private const string _summaryFunctionKey = "JqGridColumnModel.SummaryFunction";
        #endregion

        #region Methods
        internal static void SetColumnSearchable(this ModelMetadata metadata, bool searchable)
        {
            metadata.AdditionalValues.Add(_searchableKey, searchable);
        }

        internal static bool GetColumnSearchable(this ModelMetadata metadata)
        {
            if (metadata.AdditionalValues.ContainsKey(_searchableKey))
                return (bool)metadata.AdditionalValues[_searchableKey];
            else
                return true;
        }

        internal static void SetColumnSearchOptions(this ModelMetadata metadata, JqGridColumnSearchOptions searchOptions)
        {
            metadata.AdditionalValues.Add(_searchOptionsKey, searchOptions);
        }

        internal static JqGridColumnSearchOptions GetColumnSearchOptions(this ModelMetadata metadata)
        {
            if (metadata.AdditionalValues.ContainsKey(_searchOptionsKey))
                return (JqGridColumnSearchOptions)metadata.AdditionalValues[_searchOptionsKey];
            else
                return null;
        }

        internal static void SetColumnSearchRules(this ModelMetadata metadata, JqGridColumnRules searchRules)
        {
            metadata.AdditionalValues.Add(_searchRulesKey, searchRules);
        }

        internal static JqGridColumnRules GetColumnSearchRules(this ModelMetadata metadata)
        {
            if (metadata.AdditionalValues.ContainsKey(_searchRulesKey))
                return (JqGridColumnRules)metadata.AdditionalValues[_searchRulesKey];
            else
                return null;
        }

        internal static void SetColumnSearchType(this ModelMetadata metadata, JqGridColumnSearchTypes searchType)
        {
            metadata.AdditionalValues.Add(_searchTypeKey, searchType);
        }

        internal static JqGridColumnSearchTypes GetColumnSearchType(this ModelMetadata metadata)
        {
            if (metadata.AdditionalValues.ContainsKey(_searchTypeKey))
                return (JqGridColumnSearchTypes)metadata.AdditionalValues[_searchTypeKey];
            else
                return JqGridColumnSearchTypes.Text;
        }

        internal static void SetColumnSummaryType(this ModelMetadata metadata, JqGridColumnSummaryTypes type)
        {
            metadata.AdditionalValues.Add(_summaryTypeKey, type);
        }

        internal static JqGridColumnSummaryTypes? GetColumnSummaryType(this ModelMetadata metadata)
        {
            if (metadata.AdditionalValues.ContainsKey(_summaryTypeKey))
                return (JqGridColumnSummaryTypes)metadata.AdditionalValues[_summaryTypeKey];
            else
                return null;
        }

        internal static void SetColumnSummaryTemplate(this ModelMetadata metadata, string template)
        {
            metadata.AdditionalValues.Add(_summaryTemplateKey, template);
        }

        internal static string GetColumnSummaryTemplate(this ModelMetadata metadata)
        {
            if (metadata.AdditionalValues.ContainsKey(_summaryTemplateKey))
                return (string)metadata.AdditionalValues[_summaryTemplateKey];
            else
                return null;
        }

        internal static void SetColumnSummaryFunction(this ModelMetadata metadata, string function)
        {
            metadata.AdditionalValues.Add(_summaryFunctionKey, function);
        }

        internal static string GetColumnSummaryFunction(this ModelMetadata metadata)
        {
            if (metadata.AdditionalValues.ContainsKey(_summaryFunctionKey))
                return (string)metadata.AdditionalValues[_summaryFunctionKey];
            else
                return null;
        }
        #endregion
    }
}
