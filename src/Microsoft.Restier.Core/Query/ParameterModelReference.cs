// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using Microsoft.OData.Edm;
using System;
using System.Linq;

namespace Microsoft.Restier.Core.Query
{

    /// <summary>
    /// Represents a reference to parameter data in terms of a model.
    /// It does not have special logic
    /// </summary>
    public class ParameterModelReference : QueryModelReference
    {
        internal ParameterModelReference(IEdmEntitySet entitySet, IEdmType type)
            : base(entitySet, type)
        {
        }
    }
}
