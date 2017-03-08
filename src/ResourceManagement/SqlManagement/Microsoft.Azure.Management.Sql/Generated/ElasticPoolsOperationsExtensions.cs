// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql
{
    using Azure;
    using Management;
    using Rest;
    using Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ElasticPoolsOperations.
    /// </summary>
    public static partial class ElasticPoolsOperationsExtensions
    {
            /// <summary>
            /// Creates a new elastic pool or updates an existing elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool to be operated on (updated or created).
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for creating or updating an elastic pool.
            /// </param>
            public static ElasticPool CreateOrUpdate(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, ElasticPool parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serverName, elasticPoolName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new elastic pool or updates an existing elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool to be operated on (updated or created).
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for creating or updating an elastic pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ElasticPool> CreateOrUpdateAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, ElasticPool parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool to be deleted.
            /// </param>
            public static void Delete(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName)
            {
                operations.DeleteAsync(resourceGroupName, serverName, elasticPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets an elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool to be retrieved.
            /// </param>
            public static ElasticPool Get(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName)
            {
                return operations.GetAsync(resourceGroupName, serverName, elasticPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool to be retrieved.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ElasticPool> GetAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of elastic pools in a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            public static IEnumerable<ElasticPool> ListByServer(this IElasticPoolsOperations operations, string resourceGroupName, string serverName)
            {
                return operations.ListByServerAsync(resourceGroupName, serverName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of elastic pools in a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<ElasticPool>> ListByServerAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServerWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns elastic pool activities.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool for which to get the current activity.
            /// </param>
            public static IEnumerable<ElasticPoolActivity> ListActivity(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName)
            {
                return operations.ListActivityAsync(resourceGroupName, serverName, elasticPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns elastic pool activities.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool for which to get the current activity.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<ElasticPoolActivity>> ListActivityAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListActivityWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns activity on databases inside of an elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool.
            /// </param>
            public static IEnumerable<ElasticPoolDatabaseActivity> ListDatabaseActivity(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName)
            {
                return operations.ListDatabaseActivityAsync(resourceGroupName, serverName, elasticPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns activity on databases inside of an elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<ElasticPoolDatabaseActivity>> ListDatabaseActivityAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListDatabaseActivityWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a database inside of an elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool to be retrieved.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database to be retrieved.
            /// </param>
            public static Database GetDatabase(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, string databaseName)
            {
                return operations.GetDatabaseAsync(resourceGroupName, serverName, elasticPoolName, databaseName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a database inside of an elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool to be retrieved.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database to be retrieved.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Database> GetDatabaseAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, string databaseName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDatabaseWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, databaseName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of databases in an elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool to be retrieved.
            /// </param>
            public static IEnumerable<Database> ListDatabases(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName)
            {
                return operations.ListDatabasesAsync(resourceGroupName, serverName, elasticPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of databases in an elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool to be retrieved.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<Database>> ListDatabasesAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListDatabasesWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new elastic pool or updates an existing elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool to be operated on (updated or created).
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for creating or updating an elastic pool.
            /// </param>
            public static ElasticPool BeginCreateOrUpdate(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, ElasticPool parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, serverName, elasticPoolName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new elastic pool or updates an existing elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool to be operated on (updated or created).
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for creating or updating an elastic pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ElasticPool> BeginCreateOrUpdateAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, ElasticPool parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

