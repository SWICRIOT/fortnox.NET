﻿using FortnoxApiSDK.Models.Authorization;
using FortnoxNET.Constants.Sort;

namespace FortnoxNET.Communication.CostCenter
{
    public class CostCenterListRequest : FortnoxApiListedResourceRequest
    {
        public CostCenterListRequest(string accessToken, string clientSecret) : base(accessToken, clientSecret)
        {
        }

        public CostCenterListRequest(OAuthToken oAuthToken) : base(oAuthToken)
        {
        }

        public CostCenterSortableProperties? SortBy { get; set; }
    }
}
