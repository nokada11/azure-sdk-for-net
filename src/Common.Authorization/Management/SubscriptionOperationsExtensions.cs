// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using Microsoft.Azure;
using Microsoft.WindowsAzure.Management.Models;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.WindowsAzure.Management
{
    /// <summary>
    /// The Service Management API provides programmatic access to much of the
    /// functionality available through the Management Portal. The Service
    /// Management API is a REST API. All API operations are performed over
    /// SSL and are mutually authenticated using X.509 v3 certificates.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/ee460799.aspx for
    /// more information)
    /// </summary>
    public static partial class SubscriptionOperationsExtensions
    {
        /// <summary>
        /// The Get Subscription operation returns account and resource
        /// allocation information for the specified subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/hh403995.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.ISubscriptionOperations.
        /// </param>
        /// <returns>
        /// The Get Subscription operation response.
        /// </returns>
        public static SubscriptionGetResponse Get(this ISubscriptionOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISubscriptionOperations)s).GetAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Get Subscription operation returns account and resource
        /// allocation information for the specified subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/hh403995.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.ISubscriptionOperations.
        /// </param>
        /// <returns>
        /// The Get Subscription operation response.
        /// </returns>
        public static Task<SubscriptionGetResponse> GetAsync(this ISubscriptionOperations operations)
        {
            return operations.GetAsync(CancellationToken.None);
        }
        
        /// <summary>
        /// The List Subscription Operations operation returns a list of
        /// create, update, and delete operations that were performed on a
        /// subscription during the specified timeframe.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715318.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.ISubscriptionOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the List Subscription Operations
        /// operation.
        /// </param>
        /// <returns>
        /// The List Subscription Operations operation response.
        /// </returns>
        public static SubscriptionListOperationsResponse ListOperations(this ISubscriptionOperations operations, SubscriptionListOperationsParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISubscriptionOperations)s).ListOperationsAsync(parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The List Subscription Operations operation returns a list of
        /// create, update, and delete operations that were performed on a
        /// subscription during the specified timeframe.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715318.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.ISubscriptionOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the List Subscription Operations
        /// operation.
        /// </param>
        /// <returns>
        /// The List Subscription Operations operation response.
        /// </returns>
        public static Task<SubscriptionListOperationsResponse> ListOperationsAsync(this ISubscriptionOperations operations, SubscriptionListOperationsParameters parameters)
        {
            return operations.ListOperationsAsync(parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Register a resource with your subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.ISubscriptionOperations.
        /// </param>
        /// <param name='resourceName'>
        /// Required. Name of the resource to register.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse RegisterResource(this ISubscriptionOperations operations, string resourceName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISubscriptionOperations)s).RegisterResourceAsync(resourceName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Register a resource with your subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.ISubscriptionOperations.
        /// </param>
        /// <param name='resourceName'>
        /// Required. Name of the resource to register.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> RegisterResourceAsync(this ISubscriptionOperations operations, string resourceName)
        {
            return operations.RegisterResourceAsync(resourceName, CancellationToken.None);
        }
        
        /// <summary>
        /// Unregister a resource with your subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.ISubscriptionOperations.
        /// </param>
        /// <param name='resourceName'>
        /// Required. Name of the resource to unregister.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse UnregisterResource(this ISubscriptionOperations operations, string resourceName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISubscriptionOperations)s).UnregisterResourceAsync(resourceName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Unregister a resource with your subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.ISubscriptionOperations.
        /// </param>
        /// <param name='resourceName'>
        /// Required. Name of the resource to unregister.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> UnregisterResourceAsync(this ISubscriptionOperations operations, string resourceName)
        {
            return operations.UnregisterResourceAsync(resourceName, CancellationToken.None);
        }
    }
}
