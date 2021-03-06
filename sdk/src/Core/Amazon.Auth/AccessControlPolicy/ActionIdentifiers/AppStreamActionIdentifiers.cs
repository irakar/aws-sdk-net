/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
    /// <summary>
    /// The available AWS access control policy actions for Amazon AppStream.
    /// </summary>
    /// <see cref="Amazon.Auth.AccessControlPolicy.Statement.Actions"/>
    [Obsolete(
            "The Amazon.Auth.AccessContolPolicy classes are out of date and are no longer being maintained.\n" +
            "Please construct policy documents using the information found here: https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html#access_policies-json")]
    public static class AppStreamActionIdentifiers
    {
        public static readonly ActionIdentifier AllAppStreamActions = new ActionIdentifier("appstream:*");

        public static readonly ActionIdentifier CreateApplication = new ActionIdentifier("appstream:CreateApplication");
        public static readonly ActionIdentifier CreateSession = new ActionIdentifier("appstream:CreateSession");
        public static readonly ActionIdentifier DeleteApplication = new ActionIdentifier("appstream:DeleteApplication");
        public static readonly ActionIdentifier GetApiRoot = new ActionIdentifier("appstream:GetApiRoot");
        public static readonly ActionIdentifier GetApplication = new ActionIdentifier("appstream:GetApplication");
        public static readonly ActionIdentifier GetApplications = new ActionIdentifier("appstream:GetApplications");
        public static readonly ActionIdentifier GetApplicationError = new ActionIdentifier("appstream:GetApplicationError");
        public static readonly ActionIdentifier GetApplicationErrors = new ActionIdentifier("appstream:GetApplicationErrors");
        public static readonly ActionIdentifier GetApplicationStatus = new ActionIdentifier("appstream:GetApplicationStatus");
        public static readonly ActionIdentifier GetSession = new ActionIdentifier("appstream:GetSession");
        public static readonly ActionIdentifier GetSessions = new ActionIdentifier("appstream:GetSessions");
        public static readonly ActionIdentifier GetSessionStatus = new ActionIdentifier("appstream:GetSessionStatus");
        public static readonly ActionIdentifier UpdateApplication = new ActionIdentifier("appstream:UpdateApplication");
        public static readonly ActionIdentifier UpdateApplicationState = new ActionIdentifier("appstream:UpdateApplicationState");
        public static readonly ActionIdentifier UpdateSessionState = new ActionIdentifier("appstream:UpdateSessionState");
    }
}

