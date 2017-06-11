// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using Microsoft.OData.Edm;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Restier.Core
{
    /// <summary>
    /// Represents a configuration that defines an API.
    /// </summary>
    /// <remarks>
    /// <para>
    /// An API configuration defines the model and behavior of an API
    /// through a set of registered Api services in DI container.
    /// </para>
    /// <para>
    /// Api services may be singletons, meaning there is at most one instance,
    /// or scoped, in which case there will be one instances of the services for each scope.
    /// </para>
    /// </remarks>
    internal class ApiConfiguration
    {
        private Task<IEdmModel> modelTask;

        /// <summary>
        /// Gets the <see cref="IEdmModel" /> for the API.
        /// </summary>
        internal IEdmModel Model { get; private set; }

        /// <summary>
        /// Finishes generating the model for an Api.
        /// </summary>
        /// <param name="running">Specifies whether or not the process is currently running.</param>
        /// <returns>A <see cref="TaskCompletionSource{IEdmModel}"/> containing the status of the model generation.</returns>
        internal TaskCompletionSource<IEdmModel> CompleteModelGeneration(out Task<IEdmModel> running)
        {
            var source = new TaskCompletionSource<IEdmModel>(TaskCreationOptions.AttachedToParent);
            var runningTask = Interlocked.CompareExchange(ref modelTask, source.Task, null);
            if (runningTask != null)
            {
                running = runningTask;
                source.SetCanceled();
                return null;
            }

            source.Task.ContinueWith(
                task =>
                {
                    if (task.Status == TaskStatus.RanToCompletion)
                    {
                        Model = task.Result;
                    }
                    else
                    {
                        // Set modelTask null to allow retrying GetModelAsync.
                        Interlocked.Exchange(ref modelTask, null);
                    }
                },
                TaskContinuationOptions.ExecuteSynchronously);
            running = null;
            return source;
        }
    }
}
