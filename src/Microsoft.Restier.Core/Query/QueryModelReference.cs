// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using Microsoft.OData.Edm;

namespace Microsoft.Restier.Core.Query
{
    /// <summary>
    /// Represents a reference to query data in terms of a model.
    /// </summary>
    public class QueryModelReference
    {
        private readonly IEdmEntitySet edmEntitySet;

        private readonly IEdmType edmType;

        internal QueryModelReference()
        {
        }

        internal QueryModelReference(IEdmEntitySet entitySet, IEdmType type)
        {
            this.edmEntitySet = entitySet;
            this.edmType = type;
        }

        /// <summary>
        /// Gets the entity set that ultimately contains the data.
        /// </summary>
        public virtual IEdmEntitySet EntitySet
        {
            get
            {
                return this.edmEntitySet;
            }
        }

        /// <summary>
        /// Gets the type of the data, if any.
        /// </summary>
        public virtual IEdmType Type
        {
            get
            {
                return this.edmType;
            }
        }
    }
}
