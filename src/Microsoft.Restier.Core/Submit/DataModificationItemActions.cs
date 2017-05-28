// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

namespace Microsoft.Restier.Core.Submit
{
    /// <summary>
    /// This enum controls the actions requested for an resource.
    /// </summary>
    /// <remarks>
    /// This is required because during the post-CUD events, the resource state has been lost.
    /// This enum allows the API to remember which pre-CUD event was raised for the Resource.
    /// </remarks>
    public enum DataModificationItemAction
    {
        /// <summary>
        /// Specifies an undefined action.
        /// </summary>
        Undefined = 0,

        /// <summary>
        /// Specifies the resource is being updated.
        /// </summary>
        Update,

        /// <summary>
        /// Specifies the resource is being inserted.
        /// </summary>
        Insert,

        /// <summary>
        /// Specifies the resource is being removed.
        /// </summary>
        Remove
    }
}
