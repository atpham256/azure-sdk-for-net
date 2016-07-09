// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.NotificationHubs
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for NamespacesOperations.
    /// </summary>
    public static partial class NamespacesOperationsExtensions
    {
            /// <summary>
            /// Checks the availability of the given service namespace across all Windows
            /// Azure subscriptions. This is useful because the domain name is created
            /// based on the service namespace name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// The namespace name.
            /// </param>
            public static CheckAvailabilityResource CheckAvailability(this INamespacesOperations operations, CheckAvailabilityParameters parameters)
            {
                return Task.Factory.StartNew(s => ((INamespacesOperations)s).CheckAvailabilityAsync(parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks the availability of the given service namespace across all Windows
            /// Azure subscriptions. This is useful because the domain name is created
            /// based on the service namespace name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// The namespace name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CheckAvailabilityResource> CheckAvailabilityAsync(this INamespacesOperations operations, CheckAvailabilityParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckAvailabilityWithHttpMessagesAsync(parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates/Updates a service namespace. Once created, this namespace's
            /// resource manifest is immutable. This operation is idempotent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create a Namespace Resource.
            /// </param>
            public static NamespaceResource CreateOrUpdate(this INamespacesOperations operations, string resourceGroupName, string namespaceName, NamespaceCreateOrUpdateParameters parameters)
            {
                return Task.Factory.StartNew(s => ((INamespacesOperations)s).CreateOrUpdateAsync(resourceGroupName, namespaceName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates/Updates a service namespace. Once created, this namespace's
            /// resource manifest is immutable. This operation is idempotent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create a Namespace Resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NamespaceResource> CreateOrUpdateAsync(this INamespacesOperations operations, string resourceGroupName, string namespaceName, NamespaceCreateOrUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, namespaceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an existing namespace. This operation also removes all associated
            /// notificationHubs under the namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            public static void Delete(this INamespacesOperations operations, string resourceGroupName, string namespaceName)
            {
                Task.Factory.StartNew(s => ((INamespacesOperations)s).DeleteAsync(resourceGroupName, namespaceName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an existing namespace. This operation also removes all associated
            /// notificationHubs under the namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this INamespacesOperations operations, string resourceGroupName, string namespaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, namespaceName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Deletes an existing namespace. This operation also removes all associated
            /// notificationHubs under the namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            public static void BeginDelete(this INamespacesOperations operations, string resourceGroupName, string namespaceName)
            {
                Task.Factory.StartNew(s => ((INamespacesOperations)s).BeginDeleteAsync(resourceGroupName, namespaceName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an existing namespace. This operation also removes all associated
            /// notificationHubs under the namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this INamespacesOperations operations, string resourceGroupName, string namespaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, namespaceName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Returns the description for the specified namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            public static NamespaceResource Get(this INamespacesOperations operations, string resourceGroupName, string namespaceName)
            {
                return Task.Factory.StartNew(s => ((INamespacesOperations)s).GetAsync(resourceGroupName, namespaceName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the description for the specified namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NamespaceResource> GetAsync(this INamespacesOperations operations, string resourceGroupName, string namespaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, namespaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates an authorization rule for a namespace
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// Aauthorization Rule Name.
            /// </param>
            /// <param name='parameters'>
            /// The shared access authorization rule.
            /// </param>
            public static SharedAccessAuthorizationRuleResource CreateOrUpdateAuthorizationRule(this INamespacesOperations operations, string resourceGroupName, string namespaceName, string authorizationRuleName, SharedAccessAuthorizationRuleCreateOrUpdateParameters parameters)
            {
                return Task.Factory.StartNew(s => ((INamespacesOperations)s).CreateOrUpdateAuthorizationRuleAsync(resourceGroupName, namespaceName, authorizationRuleName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates an authorization rule for a namespace
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// Aauthorization Rule Name.
            /// </param>
            /// <param name='parameters'>
            /// The shared access authorization rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SharedAccessAuthorizationRuleResource> CreateOrUpdateAuthorizationRuleAsync(this INamespacesOperations operations, string resourceGroupName, string namespaceName, string authorizationRuleName, SharedAccessAuthorizationRuleCreateOrUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, authorizationRuleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a namespace authorization rule
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// Authorization Rule Name.
            /// </param>
            public static void DeleteAuthorizationRule(this INamespacesOperations operations, string resourceGroupName, string namespaceName, string authorizationRuleName)
            {
                Task.Factory.StartNew(s => ((INamespacesOperations)s).DeleteAuthorizationRuleAsync(resourceGroupName, namespaceName, authorizationRuleName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a namespace authorization rule
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// Authorization Rule Name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAuthorizationRuleAsync(this INamespacesOperations operations, string resourceGroupName, string namespaceName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets an authorization rule for a namespace by name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='authorizationRuleName'>
            /// Authorization rule name.
            /// </param>
            public static SharedAccessAuthorizationRuleResource GetAuthorizationRule(this INamespacesOperations operations, string resourceGroupName, string namespaceName, string authorizationRuleName)
            {
                return Task.Factory.StartNew(s => ((INamespacesOperations)s).GetAuthorizationRuleAsync(resourceGroupName, namespaceName, authorizationRuleName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an authorization rule for a namespace by name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='authorizationRuleName'>
            /// Authorization rule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SharedAccessAuthorizationRuleResource> GetAuthorizationRuleAsync(this INamespacesOperations operations, string resourceGroupName, string namespaceName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The Get Operation Status operation returns the status of the specified
            /// operation. After calling an asynchronous operation, you can call Get
            /// Operation Status to determine whether the operation has succeeded,
            /// failed, or is still in progress.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='operationStatusLink'>
            /// Location value returned by the Begin operation.
            /// </param>
            public static void GetLongRunningOperationStatus(this INamespacesOperations operations, string operationStatusLink)
            {
                Task.Factory.StartNew(s => ((INamespacesOperations)s).GetLongRunningOperationStatusAsync(operationStatusLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Get Operation Status operation returns the status of the specified
            /// operation. After calling an asynchronous operation, you can call Get
            /// Operation Status to determine whether the operation has succeeded,
            /// failed, or is still in progress.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='operationStatusLink'>
            /// Location value returned by the Begin operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetLongRunningOperationStatusAsync(this INamespacesOperations operations, string operationStatusLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.GetLongRunningOperationStatusWithHttpMessagesAsync(operationStatusLink, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Lists the available namespaces within a resourceGroup.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. If resourceGroupName value is null the
            /// method lists all the namespaces within subscription
            /// </param>
            public static IPage<NamespaceResource> List(this INamespacesOperations operations, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((INamespacesOperations)s).ListAsync(resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the available namespaces within a resourceGroup.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. If resourceGroupName value is null the
            /// method lists all the namespaces within subscription
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NamespaceResource>> ListAsync(this INamespacesOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the available namespaces within the subscription irrespective of
            /// the resourceGroups.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<NamespaceResource> ListAll(this INamespacesOperations operations)
            {
                return Task.Factory.StartNew(s => ((INamespacesOperations)s).ListAllAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the available namespaces within the subscription irrespective of
            /// the resourceGroups.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NamespaceResource>> ListAllAsync(this INamespacesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the authorization rules for a namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            public static IPage<SharedAccessAuthorizationRuleResource> ListAuthorizationRules(this INamespacesOperations operations, string resourceGroupName, string namespaceName)
            {
                return Task.Factory.StartNew(s => ((INamespacesOperations)s).ListAuthorizationRulesAsync(resourceGroupName, namespaceName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the authorization rules for a namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SharedAccessAuthorizationRuleResource>> ListAuthorizationRulesAsync(this INamespacesOperations operations, string resourceGroupName, string namespaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAuthorizationRulesWithHttpMessagesAsync(resourceGroupName, namespaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the Primary and Secondary ConnectionStrings to the namespace
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The connection string of the namespace for the specified authorizationRule.
            /// </param>
            public static ResourceListKeys ListKeys(this INamespacesOperations operations, string resourceGroupName, string namespaceName, string authorizationRuleName)
            {
                return Task.Factory.StartNew(s => ((INamespacesOperations)s).ListKeysAsync(resourceGroupName, namespaceName, authorizationRuleName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the Primary and Secondary ConnectionStrings to the namespace
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The connection string of the namespace for the specified authorizationRule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ResourceListKeys> ListKeysAsync(this INamespacesOperations operations, string resourceGroupName, string namespaceName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListKeysWithHttpMessagesAsync(resourceGroupName, namespaceName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the available namespaces within a resourceGroup.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<NamespaceResource> ListNext(this INamespacesOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((INamespacesOperations)s).ListNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the available namespaces within a resourceGroup.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NamespaceResource>> ListNextAsync(this INamespacesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the available namespaces within the subscription irrespective of
            /// the resourceGroups.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<NamespaceResource> ListAllNext(this INamespacesOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((INamespacesOperations)s).ListAllNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the available namespaces within the subscription irrespective of
            /// the resourceGroups.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NamespaceResource>> ListAllNextAsync(this INamespacesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the authorization rules for a namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SharedAccessAuthorizationRuleResource> ListAuthorizationRulesNext(this INamespacesOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((INamespacesOperations)s).ListAuthorizationRulesNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the authorization rules for a namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SharedAccessAuthorizationRuleResource>> ListAuthorizationRulesNextAsync(this INamespacesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAuthorizationRulesNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}