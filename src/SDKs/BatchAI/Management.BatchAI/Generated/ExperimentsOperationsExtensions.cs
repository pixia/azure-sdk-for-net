// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ExperimentsOperations.
    /// </summary>
    public static partial class ExperimentsOperationsExtensions
    {
            /// <summary>
            /// Gets a list of Experiments within the specified Workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace. Workspace names can only contain a combination
            /// of alphanumeric characters along with dash (-) and underscore (_). The name
            /// must be from 1 through 64 characters long.
            /// </param>
            /// <param name='experimentsListByWorkspaceOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static IPage<Experiment> ListByWorkspace(this IExperimentsOperations operations, string resourceGroupName, string workspaceName, ExperimentsListByWorkspaceOptions experimentsListByWorkspaceOptions = default(ExperimentsListByWorkspaceOptions))
            {
                return operations.ListByWorkspaceAsync(resourceGroupName, workspaceName, experimentsListByWorkspaceOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of Experiments within the specified Workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace. Workspace names can only contain a combination
            /// of alphanumeric characters along with dash (-) and underscore (_). The name
            /// must be from 1 through 64 characters long.
            /// </param>
            /// <param name='experimentsListByWorkspaceOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Experiment>> ListByWorkspaceAsync(this IExperimentsOperations operations, string resourceGroupName, string workspaceName, ExperimentsListByWorkspaceOptions experimentsListByWorkspaceOptions = default(ExperimentsListByWorkspaceOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByWorkspaceWithHttpMessagesAsync(resourceGroupName, workspaceName, experimentsListByWorkspaceOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates an Experiment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace. Workspace names can only contain a combination
            /// of alphanumeric characters along with dash (-) and underscore (_). The name
            /// must be from 1 through 64 characters long.
            /// </param>
            /// <param name='experimentName'>
            /// The name of the experiment. Experiment names can only contain a combination
            /// of alphanumeric characters along with dash (-) and underscore (_). The name
            /// must be from 1 through 64 characters long.
            /// </param>
            public static Experiment Create(this IExperimentsOperations operations, string resourceGroupName, string workspaceName, string experimentName)
            {
                return operations.CreateAsync(resourceGroupName, workspaceName, experimentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates an Experiment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace. Workspace names can only contain a combination
            /// of alphanumeric characters along with dash (-) and underscore (_). The name
            /// must be from 1 through 64 characters long.
            /// </param>
            /// <param name='experimentName'>
            /// The name of the experiment. Experiment names can only contain a combination
            /// of alphanumeric characters along with dash (-) and underscore (_). The name
            /// must be from 1 through 64 characters long.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Experiment> CreateAsync(this IExperimentsOperations operations, string resourceGroupName, string workspaceName, string experimentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, workspaceName, experimentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an Experiment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace. Workspace names can only contain a combination
            /// of alphanumeric characters along with dash (-) and underscore (_). The name
            /// must be from 1 through 64 characters long.
            /// </param>
            /// <param name='experimentName'>
            /// The name of the experiment. Experiment names can only contain a combination
            /// of alphanumeric characters along with dash (-) and underscore (_). The name
            /// must be from 1 through 64 characters long.
            /// </param>
            public static void Delete(this IExperimentsOperations operations, string resourceGroupName, string workspaceName, string experimentName)
            {
                operations.DeleteAsync(resourceGroupName, workspaceName, experimentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an Experiment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace. Workspace names can only contain a combination
            /// of alphanumeric characters along with dash (-) and underscore (_). The name
            /// must be from 1 through 64 characters long.
            /// </param>
            /// <param name='experimentName'>
            /// The name of the experiment. Experiment names can only contain a combination
            /// of alphanumeric characters along with dash (-) and underscore (_). The name
            /// must be from 1 through 64 characters long.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IExperimentsOperations operations, string resourceGroupName, string workspaceName, string experimentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, workspaceName, experimentName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets information about an Experiment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace. Workspace names can only contain a combination
            /// of alphanumeric characters along with dash (-) and underscore (_). The name
            /// must be from 1 through 64 characters long.
            /// </param>
            /// <param name='experimentName'>
            /// The name of the experiment. Experiment names can only contain a combination
            /// of alphanumeric characters along with dash (-) and underscore (_). The name
            /// must be from 1 through 64 characters long.
            /// </param>
            public static Experiment Get(this IExperimentsOperations operations, string resourceGroupName, string workspaceName, string experimentName)
            {
                return operations.GetAsync(resourceGroupName, workspaceName, experimentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets information about an Experiment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace. Workspace names can only contain a combination
            /// of alphanumeric characters along with dash (-) and underscore (_). The name
            /// must be from 1 through 64 characters long.
            /// </param>
            /// <param name='experimentName'>
            /// The name of the experiment. Experiment names can only contain a combination
            /// of alphanumeric characters along with dash (-) and underscore (_). The name
            /// must be from 1 through 64 characters long.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Experiment> GetAsync(this IExperimentsOperations operations, string resourceGroupName, string workspaceName, string experimentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workspaceName, experimentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates an Experiment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace. Workspace names can only contain a combination
            /// of alphanumeric characters along with dash (-) and underscore (_). The name
            /// must be from 1 through 64 characters long.
            /// </param>
            /// <param name='experimentName'>
            /// The name of the experiment. Experiment names can only contain a combination
            /// of alphanumeric characters along with dash (-) and underscore (_). The name
            /// must be from 1 through 64 characters long.
            /// </param>
            public static Experiment BeginCreate(this IExperimentsOperations operations, string resourceGroupName, string workspaceName, string experimentName)
            {
                return operations.BeginCreateAsync(resourceGroupName, workspaceName, experimentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates an Experiment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace. Workspace names can only contain a combination
            /// of alphanumeric characters along with dash (-) and underscore (_). The name
            /// must be from 1 through 64 characters long.
            /// </param>
            /// <param name='experimentName'>
            /// The name of the experiment. Experiment names can only contain a combination
            /// of alphanumeric characters along with dash (-) and underscore (_). The name
            /// must be from 1 through 64 characters long.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Experiment> BeginCreateAsync(this IExperimentsOperations operations, string resourceGroupName, string workspaceName, string experimentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, workspaceName, experimentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an Experiment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace. Workspace names can only contain a combination
            /// of alphanumeric characters along with dash (-) and underscore (_). The name
            /// must be from 1 through 64 characters long.
            /// </param>
            /// <param name='experimentName'>
            /// The name of the experiment. Experiment names can only contain a combination
            /// of alphanumeric characters along with dash (-) and underscore (_). The name
            /// must be from 1 through 64 characters long.
            /// </param>
            public static void BeginDelete(this IExperimentsOperations operations, string resourceGroupName, string workspaceName, string experimentName)
            {
                operations.BeginDeleteAsync(resourceGroupName, workspaceName, experimentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an Experiment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace. Workspace names can only contain a combination
            /// of alphanumeric characters along with dash (-) and underscore (_). The name
            /// must be from 1 through 64 characters long.
            /// </param>
            /// <param name='experimentName'>
            /// The name of the experiment. Experiment names can only contain a combination
            /// of alphanumeric characters along with dash (-) and underscore (_). The name
            /// must be from 1 through 64 characters long.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IExperimentsOperations operations, string resourceGroupName, string workspaceName, string experimentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, workspaceName, experimentName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets a list of Experiments within the specified Workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Experiment> ListByWorkspaceNext(this IExperimentsOperations operations, string nextPageLink)
            {
                return operations.ListByWorkspaceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of Experiments within the specified Workspace.
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
            public static async Task<IPage<Experiment>> ListByWorkspaceNextAsync(this IExperimentsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByWorkspaceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}