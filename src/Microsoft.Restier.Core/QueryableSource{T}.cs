// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Microsoft.Restier.Core
{

    internal class QueryableSource<T> : QueryableSource, IOrderedQueryable<T>
    {
        public QueryableSource(Expression expression)
            : base(expression)
        {
        }

        public override Type ElementType
        {
            get
            {
                return typeof(T);
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotSupportedException(Resources.CallQueryableSourceMethodNotSupported);
        }
    }
}
