﻿using FortnoxApiSDK.Models.Authorization;
using FortnoxNET.Constants.Search;
using FortnoxNET.Constants.Sort;
using System.Collections.Generic;

namespace FortnoxNET.Communication.FinancialYear
{
    public class FinancialYearListRequest : FortnoxApiListedResourceRequest
    {
        public FinancialYearListRequest(string accessToken, string clientSecret) : base(accessToken, clientSecret)
        {
        }

        public FinancialYearListRequest(OAuthToken oAuthToken) : base(oAuthToken)
        {
        }

        public FinancialYearSortableProperties? SortBy { get; set; }

        public Dictionary<FinancialYearSearchParameters, object> SearchParameters { get; set; }
    }
}
