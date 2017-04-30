// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Reflection;

namespace System
{

    internal static class TypeHelper
    {
        public static Type GetUnderlyingTypeOrSelf(Type type)
        {
            return Nullable.GetUnderlyingType(type) ?? type;
        }

        public static bool IsEnum(Type type)
        {
            Type underlyingTypeOrSelf = GetUnderlyingTypeOrSelf(type);
            return underlyingTypeOrSelf.IsEnum;
        }

        public static bool IsDateTime(Type type)
        {
            Type underlyingTypeOrSelf = GetUnderlyingTypeOrSelf(type);
            return underlyingTypeOrSelf == typeof(DateTime);
        }

        public static bool IsTimeSpan(Type type)
        {
            Type underlyingTypeOrSelf = GetUnderlyingTypeOrSelf(type);
            return underlyingTypeOrSelf == typeof(TimeSpan);
        }

        public static bool IsDateTimeOffset(Type type)
        {
            Type underlyingTypeOrSelf = GetUnderlyingTypeOrSelf(type);
            return underlyingTypeOrSelf == typeof(DateTimeOffset);
        }
    }
}
