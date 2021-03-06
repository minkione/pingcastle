﻿//
// Copyright (c) Ping Castle. All rights reserved.
// https://www.pingcastle.com
//
// Licensed under the Non-Profit OSL. See LICENSE file in the project root for full license information.
//
using System;
using System.Collections.Generic;
using System.Text;

namespace PingCastle.Healthcheck.Rules
{
	[HeatlcheckRuleModel("A-DsHeuristicsAnonymous", HealthcheckRiskRuleCategory.Anomalies, HealthcheckRiskModelCategory.Reconnaissance)]
	[HeatlcheckRuleComputation(RuleComputationType.TriggerOnPresence, 5)]
    [HeatlcheckRuleSTIG("V-8555", true)]
    public class HeatlcheckRuleAnomalyDsHeuristicsAnonymous : HeatlcheckRuleBase
    {
		protected override int? AnalyzeDataNew(HealthcheckData healthcheckData)
        {
            if (healthcheckData.DsHeuristicsAnonymousAccess)
            {
                return 1;
            }
            return 0;
        }
    }
}
