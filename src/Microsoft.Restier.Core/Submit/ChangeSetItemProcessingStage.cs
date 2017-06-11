// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

namespace Microsoft.Restier.Core.Submit
{
    /// <summary>
    /// Possible states of an resource during a ChangeSet life cycle
    /// </summary>
    internal enum ChangeSetItemProcessingStage
    {
        /// <summary>
        /// If an new change set item is created
        /// </summary>
        Initialized,

        /// <summary>
        /// The resource has been validated.
        /// </summary>
        Validated,

        /// <summary>
        /// The resource set deleting, inserting or updating events are raised
        /// </summary>
        PreEventing,

        /// <summary>
        /// The resource was modified within its own pre eventing interception method. This indicates that the resource
        /// should be revalidated but its pre eventing interception point should not be invoked again.
        /// </summary>
        ChangedWithinOwnPreEventing,

        /// <summary>
        /// The resource's pre events have been raised
        /// </summary>
        PreEvented
    }
}
