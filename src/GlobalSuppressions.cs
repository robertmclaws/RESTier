// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System.Diagnostics.CodeAnalysis;

#region StyleCop Anlyzers

[assembly: SuppressMessage("StyleCop.CSharp.LayoutRules", "SA1505:OpeningBracesMustNotBeFollowedByBlankLine", Justification = "Code should be given room to breathe.")]
[assembly: SuppressMessage("StyleCop.CSharp.LayoutRules", "SA1508:ClosingBracesMustNotBePrecededByBlankLine", Justification = "Code should be given room to breathe.")]
[assembly: SuppressMessage("StyleCop.CSharp.LayoutRules", "SA1512:SingleLineCommentsMustNotBeFollowedByBlankLine", Justification = "Commented out code may be in a different group, and therefore can have a blank line after it.")]

[assembly: SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:File may only contain a single class", Justification = "Both classes in the file share a delegate.", Scope = "type", Target = "~T:Microsoft.Restier.Core.ChainedService`1")]
[assembly: SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1404:CodeAnalysisSuppressionMustHaveJustification", Justification = "Needs to be fixed, but should not break the build.")]

[assembly: SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1101:PrefixLocalCallsWithThis", Justification = "The project currently does not do this. Recommend it be changed for readability.")]
[assembly: SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1124:DoNotUseRegions", Justification = "Restier is allowed to use Regions.")]
[assembly: SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1127:GenericTypeConstraintsMustBeOnOwnLine", Justification = "Generic type constraints can be inline.")]
[assembly: SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1128:ConstructorInitializerMustBeOnOwnLine", Justification = "Constructor initializers can be inline.")]

[assembly: SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1005:SingleLineCommentsMustBeginWithSingleSpace", Justification = "If code is commented out with VS, the slashes will not be preceeded with a space.")]

#endregion

#region Permanent Exclusions
[assembly: SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes", Scope = "member", Target = "Microsoft.Restier.Providers.EntityFramework.EntityFrameworkApi`1.#ConfigureApi(System.Type,Microsoft.Extensions.DependencyInjection.IServiceCollection)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Microsoft.Restier.Core.Query.QueryRequest.#Create`2(System.Linq.IQueryable`1<!!0>,System.Linq.Expressions.Expression`1<System.Func`2<System.Linq.IQueryable`1<!!0>,!!1>>,System.Nullable`1<System.Boolean>)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "type", Target = "Microsoft.Restier.Core.Submit.ChangeSetValidationException", Justification = "We do not intend to support serialization of this exception yet")]
[assembly: SuppressMessage("Microsoft.Design", "CA1061:DoNotHideBaseClassMethods", Scope = "member", Target = "Microsoft.Restier.Publishers.OData.Batch.RestierBatchChangeSetRequestItem.#DisposeResponses(System.Collections.Generic.IEnumerable`1<System.Net.Http.HttpResponseMessage>)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly", Scope = "member", Target = "Microsoft.Restier.Core.ApiBase.#Dispose()", Justification = "Need to do some clean up before the virtual Dispose(disposing) method gets called.")]
[assembly: SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames", Justification = "These assemblies are delay-signed.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Microsoft.Restier.Core.Submit.ChangeSetValidationResults", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix", Scope = "type", Target = "Microsoft.Restier.Security.ApiPermission", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods", Scope = "member", Target = "Microsoft.Restier.Core.Submit.ChangeSetEntry.#Type", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods", Scope = "member", Target = "Microsoft.Restier.Core.Query.QueryModelReference.#Type", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Scope = "member", Target = "Microsoft.Restier.Providers.EntityFramework.ModelProducer.#.cctor()", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Microsoft.Restier.Publishers.OData.RestierController`1.#GetQuery(System.Web.OData.Extensions.HttpRequestMessageProperties)", Justification = "Instance is disposed elsewhere")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2237:MarkISerializableTypesWithSerializable", Scope = "type", Target = "Microsoft.Restier.Core.Submit.ChangeSetValidationException", Justification = "We do not intend to support serialization of this exception yet")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2243:AttributeStringLiteralsShouldParseCorrectly", Justification = "AssemblyInformationalVersion could be string.")]

#region CA1004 Generic method with type parameter
[assembly: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "Microsoft.Restier.Core.Query.IQueryExecutor.#ExecuteExpressionAsync`1(Microsoft.Restier.Core.Query.QueryContext,System.Linq.IQueryProvider,System.Linq.Expressions.Expression,System.Threading.CancellationToken)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "Microsoft.Restier.Core.ServiceCollectionExtensions.#HasService`1(Microsoft.Extensions.DependencyInjection.IServiceCollection)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "Microsoft.Restier.Core.ServiceCollectionExtensions.#AddService`2(Microsoft.Extensions.DependencyInjection.IServiceCollection)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "Microsoft.Restier.Core.ServiceCollectionExtensions.#MakeSingleton`1(Microsoft.Extensions.DependencyInjection.IServiceCollection)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "Microsoft.Restier.Core.ServiceCollectionExtensions.#MakeScoped`1(Microsoft.Extensions.DependencyInjection.IServiceCollection)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "Microsoft.Restier.Core.ServiceCollectionExtensions.#MakeTransient`1(Microsoft.Extensions.DependencyInjection.IServiceCollection)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "Microsoft.Restier.Providers.EntityFramework.ServiceCollectionExtensions.#AddEfProviderServices`1(Microsoft.Extensions.DependencyInjection.IServiceCollection)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "Microsoft.Restier.Publishers.OData.ServiceCollectionExtensions.#AddODataServices`1(Microsoft.Extensions.DependencyInjection.IServiceCollection)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "Microsoft.Restier.Publishers.OData.HttpConfigurationExtensions.#MapRestierRoute`1(System.Web.Http.HttpConfiguration,System.String,System.String,System.Func`1<Microsoft.Restier.Core.ApiBase>,Microsoft.Restier.Publishers.OData.Batch.RestierBatchHandler)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "Microsoft.Restier.Publishers.OData.HttpConfigurationExtensions.#MapRestierRoute`1(System.Web.Http.HttpConfiguration,System.String,System.String,Microsoft.Restier.Publishers.OData.Batch.RestierBatchHandler)", Justification = "<Pending>")]
#endregion

#region CA1006 Nested Generic Type
[assembly: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Microsoft.Restier.Core.ApiBaseExtensions.#QueryAsync`1(Microsoft.Restier.Core.ApiBase,System.Linq.IQueryable`1<!!0>,System.Threading.CancellationToken)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Microsoft.Restier.Core.ApiBaseExtensions.#QueryAsync`2(Microsoft.Restier.Core.ApiBase,System.Linq.IQueryable`1<!!0>,System.Linq.Expressions.Expression`1<System.Func`2<System.Linq.IQueryable`1<!!0>,!!1>>,System.Threading.CancellationToken)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Microsoft.Restier.Core.Model.ModelContext.#ResourceTypeKeyPropertiesMap", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Microsoft.Restier.Core.Query.QueryRequest.#Create`2(System.Linq.IQueryable`1<!!0>,System.Linq.Expressions.Expression`1<System.Func`2<System.Linq.IQueryable`1<!!0>,!!1>>,System.Nullable`1<System.Boolean>)", Justification = "<Pending>")]
#endregion

#region CA1020 Few types in namespace
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Microsoft.Restier.Core", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Microsoft.Restier.Core.Model", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Microsoft.Restier.Core.Operation", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Microsoft.Restier.Providers.EntityFramework", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Microsoft.Restier.Publishers.OData", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Microsoft.Restier.Publishers.OData.Batch", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Microsoft.Restier.Publishers.OData.Filters", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Microsoft.Restier.Publishers.OData.Model", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Microsoft.Restier.Publishers.OData.Results", Justification = "<Pending>")]
#endregion

#region CA1026 Default Parameter
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Microsoft.Restier.Publishers.OData.Batch.RestierBatchHandler.#.ctor(System.Web.Http.HttpServer,System.Func`1<Microsoft.Restier.Core.ApiBase>)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Microsoft.Restier.Core.ApiBaseExtensions.#GetModelAsync(Microsoft.Restier.Core.ApiBase,System.Threading.CancellationToken)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Microsoft.Restier.Core.ApiBaseExtensions.#QueryAsync`1(Microsoft.Restier.Core.ApiBase,System.Linq.IQueryable`1<!!0>,System.Threading.CancellationToken)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Microsoft.Restier.Core.ApiBaseExtensions.#QueryAsync`2(Microsoft.Restier.Core.ApiBase,System.Linq.IQueryable`1<!!0>,System.Linq.Expressions.Expression`1<System.Func`2<System.Linq.IQueryable`1<!!0>,!!1>>,System.Threading.CancellationToken)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Microsoft.Restier.Core.ApiBaseExtensions.#QueryAsync(Microsoft.Restier.Core.ApiBase,Microsoft.Restier.Core.Query.QueryRequest,System.Threading.CancellationToken)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Microsoft.Restier.Core.ApiBaseExtensions.#SubmitAsync(Microsoft.Restier.Core.ApiBase,Microsoft.Restier.Core.Submit.ChangeSet,System.Threading.CancellationToken)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Microsoft.Restier.Core.Query.QueryRequest.#.ctor(System.Linq.IQueryable,System.Nullable`1<System.Boolean>)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Microsoft.Restier.Core.Query.QueryRequest.#Create`2(System.Linq.IQueryable`1<!!0>,System.Linq.Expressions.Expression`1<System.Func`2<System.Linq.IQueryable`1<!!0>,!!1>>,System.Nullable`1<System.Boolean>)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Microsoft.Restier.Core.Query.QueryRequest.#Create(System.Linq.IQueryable,System.Linq.Expressions.LambdaExpression,System.Nullable`1<System.Boolean>)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Microsoft.Restier.Core.Query.QueryResult.#.ctor(System.Collections.IEnumerable,System.Nullable`1<System.Int64>)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Microsoft.Restier.Security.ApiPermission.#CreateGrant(System.String,System.String,System.String,System.String,System.String)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Microsoft.Restier.Security.ApiPermission.#CreateDeny(System.String,System.String,System.String,System.String,System.String)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Microsoft.Restier.Publishers.OData.HttpConfigurationExtensions.#MapRestierRoute`1(System.Web.Http.HttpConfiguration,System.String,System.String,System.Func`1<Microsoft.Restier.Core.ApiBase>,Microsoft.Restier.Publishers.OData.Batch.RestierBatchHandler)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Microsoft.Restier.Publishers.OData.HttpConfigurationExtensions.#MapRestierRoute`1(System.Web.Http.HttpConfiguration,System.String,System.String,Microsoft.Restier.Publishers.OData.Batch.RestierBatchHandler)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "type", Target = "Microsoft.Restier.Core.PreconditionFailedException", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "type", Target = "Microsoft.Restier.Core.ResourceNotFoundException", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "type", Target = "Microsoft.Restier.Core.PreconditionRequiredException", Justification = "<Pending>")]
#endregion

#region CA1704 Identifiers spelling
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Sourcer", Scope = "type", Target = "Microsoft.Restier.Core.Query.IQueryExpressionSourcer", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Sourcer", Scope = "type", Target = "Microsoft.Restier.Providers.EntityFramework.QueryExpressionSourcer", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Ef", Scope = "member", Target = "Microsoft.Restier.Providers.EntityFramework.ServiceCollectionExtensions.#AddEfProviderServices`1(Microsoft.Extensions.DependencyInjection.IServiceCollection)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Ef", Scope = "member", Target = "Microsoft.Restier.Providers.EntityFramework.ChangeSetInitializer.#ConvertToEfValue(System.Type,System.Object)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Etag", Scope = "member", Target = "Microsoft.Restier.Core.Submit.DataModificationItem.#ValidateEtag(System.Linq.IQueryable)", Justification = "<Pending>")]
#endregion

#region CA1709 Identifiers case
[assembly: SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Ef", Scope = "member", Target = "Microsoft.Restier.Providers.EntityFramework.ServiceCollectionExtensions.#AddEfProviderServices`1(Microsoft.Extensions.DependencyInjection.IServiceCollection)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Ef", Scope = "member", Target = "Microsoft.Restier.Providers.EntityFramework.ChangeSetInitializer.#ConvertToEfValue(System.Type,System.Object)", Justification = "<Pending>")]
#endregion

#endregion

#region Temporary Exclusions

[assembly: SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "System.Net.Http.HttpRequestMessageExtensions.CreateErrorResponse(System.Net.Http.HttpRequestMessage,System.Net.HttpStatusCode,System.String)", Scope = "member", Target = "Microsoft.Restier.Publishers.OData.RestierController`1.#GetQuery(System.Web.OData.Extensions.HttpRequestMessageProperties)", Justification = "<Pending>")]

#region CA1811 Review uncalled private code
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Microsoft.Restier.Core.Submit.DataModificationItem.#ServerValues", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Microsoft.Restier.Providers.EntityFramework.ModelProducer.#InnerModelBuilder", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Microsoft.Restier.Providers.EntityFramework.QueryExecutor.#Inner", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Microsoft.Restier.Publishers.OData.Query.RestierQueryExecutor.#Inner", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Microsoft.Restier.Publishers.OData.ValidationResultDto.#Severity", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Microsoft.Restier.Publishers.OData.ValidationResultDto.#PropertyName", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Microsoft.Restier.Publishers.OData.ValidationResultDto.#Message", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Microsoft.Restier.Publishers.OData.ValidationResultDto.#Id", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Microsoft.Restier.Publishers.OData.Model.ModelMapper.#InnerMapper", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Microsoft.Restier.Publishers.OData.Model.RestierModelBuilder.#InnerModelBuilder", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Microsoft.Restier.Publishers.OData.Model.RestierModelExtender+ModelBuilder.#.ctor(Microsoft.Restier.Publishers.OData.Model.RestierModelExtender)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Microsoft.Restier.Publishers.OData.Model.RestierModelExtender+ModelBuilder.#InnerModelBuilder", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Microsoft.Restier.Publishers.OData.Model.RestierModelExtender+ModelBuilder.#ModelCache", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Microsoft.Restier.Publishers.OData.Model.RestierModelExtender+ModelMapper.#.ctor(Microsoft.Restier.Publishers.OData.Model.RestierModelExtender)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Microsoft.Restier.Publishers.OData.Model.RestierModelExtender+ModelMapper.#ModelCache", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Microsoft.Restier.Publishers.OData.Model.RestierModelExtender+ModelMapper.#InnerModelMapper", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Microsoft.Restier.Publishers.OData.BaseResult.#EdmType", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Microsoft.Restier.Publishers.OData.PropertyAttributes.#NoWritePermission", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Microsoft.Restier.Publishers.OData.PropertyAttributes.#NoReadPermission", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Microsoft.Restier.Publishers.OData.PropertyAttributes.#NoReadPermission", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Microsoft.Restier.Publishers.OData.PropertyAttributes.#NoWritePermission", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Ensure.#NotNull`1(System.Nullable`1<!!0>,System.String)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Linq.Expressions.ExpressionHelperMethods.#EnumerableCastGeneric", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Linq.Expressions.ExpressionHelperMethods.#EnumerableToListGeneric", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Linq.Expressions.ExpressionHelperMethods.#EnumerableToArrayGeneric", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Linq.Expressions.ExpressionHelperMethods.#QueryableAsQueryable", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Linq.Expressions.ExpressionHelperMethods.#QueryableAsQueryableGeneric", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Linq.Expressions.ExpressionHelperMethods.#QueryableCountGeneric", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Linq.Expressions.ExpressionHelperMethods.#QueryableOfTypeGeneric", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Linq.Expressions.ExpressionHelperMethods.#QueryableSelectGeneric", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Linq.Expressions.ExpressionHelperMethods.#QueryableSelectManyGeneric", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Linq.Expressions.ExpressionHelperMethods.#QueryableWhereGeneric", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Linq.Expressions.ExpressionHelpers.#Count(System.Linq.Expressions.Expression,System.Type)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Linq.Expressions.ExpressionHelpers.#CreateEmptyQueryable(System.Type)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Linq.Expressions.ExpressionHelpers.#GetCountableQuery`1(System.Linq.IQueryable`1<!!0>)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Linq.Expressions.ExpressionHelpers.#GetEnumerableItemType(System.Type)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Linq.Expressions.ExpressionHelpers.#GetSelectExpandElementType(System.Type)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Linq.Expressions.ExpressionHelpers.#OfType(System.Linq.IQueryable,System.Type)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Linq.Expressions.ExpressionHelpers.#RemoveUnneededStatement(System.Linq.Expressions.MethodCallExpression)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Linq.Expressions.ExpressionHelpers.#RemoveSelectExpandStatement(System.Linq.Expressions.MethodCallExpression)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Linq.Expressions.ExpressionHelpers.#RemoveAppendWhereStatement(System.Linq.Expressions.Expression)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Linq.Expressions.ExpressionHelpers.#Select(System.Linq.IQueryable,System.Linq.Expressions.LambdaExpression)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Linq.Expressions.ExpressionHelpers.#SelectMany(System.Linq.IQueryable,System.Linq.Expressions.LambdaExpression,System.Type)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Linq.Expressions.ExpressionHelpers.#StripQueryMethod(System.Linq.Expressions.Expression,System.String)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Linq.Expressions.ExpressionHelpers.#StripPagingOperators`1(System.Linq.IQueryable`1<!!0>)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Linq.Expressions.ExpressionHelpers.#Where(System.Linq.IQueryable,System.Linq.Expressions.LambdaExpression,System.Type)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.TypeExtensions.#GetQualifiedMethod(System.Type,System.String)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.TypeExtensions.#TryGetElementType(System.Type,System.Type&)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.TypeHelper.#GetUnderlyingTypeOrSelf(System.Type)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.TypeHelper.#IsDateTime(System.Type)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.TypeHelper.#IsDateTimeOffset(System.Type)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.TypeHelper.#IsEnum(System.Type)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.TypeHelper.#IsTimeSpan(System.Type)", Justification = "<Pending>")]
#endregion

#region CA2208 Add string message for exception
[assembly: SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Scope = "member", Target = "Microsoft.Restier.Core.QueryableSource.#System.Linq.IQueryProvider.CreateQuery`1(System.Linq.Expressions.Expression)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Scope = "member", Target = "Microsoft.Restier.Core.QueryableSource.#System.Linq.IQueryProvider.CreateQuery(System.Linq.Expressions.Expression)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "Microsoft.Restier.Core.Model.ModelContext.#ResourceSetTypeMap", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "Microsoft.Restier.Core.Model.ModelContext.#ResourceTypeKeyPropertiesMap", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "Microsoft.Restier.Core.Operation.OperationContext.#ParameterValues", Justification = "<Pending>")]
#endregion

#region CA1801 Unused Parameters
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "name", Scope = "member", Target = "Microsoft.Restier.Core.DataSourceStub.#GetQueryableSource`1(System.String,System.Object[])", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "arguments", Scope = "member", Target = "Microsoft.Restier.Core.DataSourceStub.#GetQueryableSource`1(System.String,System.Object[])", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "namespaceName", Scope = "member", Target = "Microsoft.Restier.Core.DataSourceStub.#GetQueryableSource`1(System.String,System.String,System.Object[])", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "name", Scope = "member", Target = "Microsoft.Restier.Core.DataSourceStub.#GetQueryableSource`1(System.String,System.String,System.Object[])", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "arguments", Scope = "member", Target = "Microsoft.Restier.Core.DataSourceStub.#GetQueryableSource`1(System.String,System.String,System.Object[])", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "name", Scope = "member", Target = "Microsoft.Restier.Core.DataSourceStub.#Results`1(System.String,System.Object[])", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "arguments", Scope = "member", Target = "Microsoft.Restier.Core.DataSourceStub.#Results`1(System.String,System.Object[])", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "name", Scope = "member", Target = "Microsoft.Restier.Core.DataSourceStub.#Result`1(System.String,System.Object[])", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "arguments", Scope = "member", Target = "Microsoft.Restier.Core.DataSourceStub.#Result`1(System.String,System.Object[])", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "namespaceName", Scope = "member", Target = "Microsoft.Restier.Core.DataSourceStub.#Results`1(System.String,System.String,System.Object[])", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "name", Scope = "member", Target = "Microsoft.Restier.Core.DataSourceStub.#Results`1(System.String,System.String,System.Object[])", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "arguments", Scope = "member", Target = "Microsoft.Restier.Core.DataSourceStub.#Results`1(System.String,System.String,System.Object[])", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "namespaceName", Scope = "member", Target = "Microsoft.Restier.Core.DataSourceStub.#Result`1(System.String,System.String,System.Object[])", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "name", Scope = "member", Target = "Microsoft.Restier.Core.DataSourceStub.#Result`1(System.String,System.String,System.Object[])", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "arguments", Scope = "member", Target = "Microsoft.Restier.Core.DataSourceStub.#Result`1(System.String,System.String,System.Object[])", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "source", Scope = "member", Target = "Microsoft.Restier.Core.DataSourceStub.#GetPropertyValue`1(System.Object,System.String)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "propertyName", Scope = "member", Target = "Microsoft.Restier.Core.DataSourceStub.#GetPropertyValue`1(System.Object,System.String)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "odataProperties", Scope = "member", Target = "Microsoft.Restier.Publishers.OData.RestierController`1.#GetQuery(System.Web.OData.Extensions.HttpRequestMessageProperties)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes", Scope = "member", Target = "Microsoft.Restier.Providers.EntityFramework.ModelProducer.#GetModelAsync(Microsoft.Restier.Core.Model.ModelContext,System.Threading.CancellationToken)", Justification = "<Pending>")]
#endregion

#region CA2000 Dispose objects
[assembly: SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Microsoft.Restier.Publishers.OData.RestierController.#CreateQueryResponse(System.Linq.IQueryable,Microsoft.OData.Edm.IEdmType,System.Web.OData.Formatter.ETag)", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Microsoft.Restier.Publishers.OData.RestierExceptionFilterAttribute.#HandleCommonException(System.Web.Http.Filters.HttpActionExecutedContext,System.Boolean,System.Threading.CancellationToken)", Justification = "<Pending>")]
#endregion

#region CA1812 Uninstantiated internal classes
[assembly: SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Scope = "type", Target = "Microsoft.Restier.Core.ApiConfiguration", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Scope = "type", Target = "Microsoft.Restier.Core.ConventionBasedChangeSetItemValidator", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Scope = "type", Target = "Microsoft.Restier.Core.PropertyBag", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Scope = "type", Target = "Microsoft.Restier.Providers.EntityFramework.ModelProducer", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Scope = "type", Target = "Microsoft.Restier.Providers.EntityFramework.QueryExpressionProcessor", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Scope = "type", Target = "Microsoft.Restier.Publishers.OData.Model.RestierModelExtender+QueryExpressionExpander", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Scope = "type", Target = "Microsoft.Restier.Publishers.OData.Model.RestierModelExtender+QueryExpressionSourcer", Justification = "<Pending>")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Scope = "type", Target = "Microsoft.Restier.Publishers.OData.Query.RestierQueryExecutorOptions", Justification = "<Pending>")]
#endregion

#endregion

