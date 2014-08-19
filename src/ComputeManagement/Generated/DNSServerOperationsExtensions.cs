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

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.Compute;
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure
{
    /// <summary>
    /// The Service Management API provides programmatic access to much of the
    /// functionality available through the Management Portal. The Service
    /// Management API is a REST API. All API operations are performed over
    /// SSL, and are mutually authenticated using X.509 v3 certificates.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/ee460799.aspx for
    /// more information)
    /// </summary>
    public static partial class DNSServerOperationsExtensions
    {
        /// <summary>
        /// Add a definition for a DNS server to an existing deployment. VM's
        /// in this deployment will be programmed to use this DNS server for
        /// all DNS resolutions
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IDNSServerOperations.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the service.
        /// </param>
        /// <param name='deploymentName'>
        /// Required. The name of the deployment.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Add DNS Server operation.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static OperationStatusResponse AddDNSServer(this IDNSServerOperations operations, string serviceName, string deploymentName, DNSAddParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDNSServerOperations)s).AddDNSServerAsync(serviceName, deploymentName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Add a definition for a DNS server to an existing deployment. VM's
        /// in this deployment will be programmed to use this DNS server for
        /// all DNS resolutions
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IDNSServerOperations.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the service.
        /// </param>
        /// <param name='deploymentName'>
        /// Required. The name of the deployment.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Add DNS Server operation.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static Task<OperationStatusResponse> AddDNSServerAsync(this IDNSServerOperations operations, string serviceName, string deploymentName, DNSAddParameters parameters)
        {
            return operations.AddDNSServerAsync(serviceName, deploymentName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Add a definition for a DNS server to an existing deployment. VM's
        /// in this deployment will be programmed to use this DNS server for
        /// all DNS resolutions
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IDNSServerOperations.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the service.
        /// </param>
        /// <param name='deploymentName'>
        /// Required. The name of the deployment.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Add DNS Server operation.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static OperationStatusResponse BeginAddingDNSServer(this IDNSServerOperations operations, string serviceName, string deploymentName, DNSAddParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDNSServerOperations)s).BeginAddingDNSServerAsync(serviceName, deploymentName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Add a definition for a DNS server to an existing deployment. VM's
        /// in this deployment will be programmed to use this DNS server for
        /// all DNS resolutions
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IDNSServerOperations.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the service.
        /// </param>
        /// <param name='deploymentName'>
        /// Required. The name of the deployment.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Add DNS Server operation.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static Task<OperationStatusResponse> BeginAddingDNSServerAsync(this IDNSServerOperations operations, string serviceName, string deploymentName, DNSAddParameters parameters)
        {
            return operations.BeginAddingDNSServerAsync(serviceName, deploymentName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Deletes a definition for an existing DNS server from the deployment
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IDNSServerOperations.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the service.
        /// </param>
        /// <param name='deploymentName'>
        /// Required. The name of the deployment.
        /// </param>
        /// <param name='dnsServerName'>
        /// Required. The name of the dns server.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static OperationStatusResponse BeginDeletingDNSServer(this IDNSServerOperations operations, string serviceName, string deploymentName, string dnsServerName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDNSServerOperations)s).BeginDeletingDNSServerAsync(serviceName, deploymentName, dnsServerName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Deletes a definition for an existing DNS server from the deployment
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IDNSServerOperations.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the service.
        /// </param>
        /// <param name='deploymentName'>
        /// Required. The name of the deployment.
        /// </param>
        /// <param name='dnsServerName'>
        /// Required. The name of the dns server.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static Task<OperationStatusResponse> BeginDeletingDNSServerAsync(this IDNSServerOperations operations, string serviceName, string deploymentName, string dnsServerName)
        {
            return operations.BeginDeletingDNSServerAsync(serviceName, deploymentName, dnsServerName, CancellationToken.None);
        }
        
        /// <summary>
        /// Updates a definition for an existing DNS server. Updates to address
        /// is the only change allowed. DNS server name cannot be changed
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IDNSServerOperations.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the service.
        /// </param>
        /// <param name='deploymentName'>
        /// Required. The name of the deployment.
        /// </param>
        /// <param name='dnsServerName'>
        /// Required. The name of the dns server.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Update DNS Server operation.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static OperationStatusResponse BeginUpdatingDNSServer(this IDNSServerOperations operations, string serviceName, string deploymentName, string dnsServerName, DNSUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDNSServerOperations)s).BeginUpdatingDNSServerAsync(serviceName, deploymentName, dnsServerName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Updates a definition for an existing DNS server. Updates to address
        /// is the only change allowed. DNS server name cannot be changed
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IDNSServerOperations.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the service.
        /// </param>
        /// <param name='deploymentName'>
        /// Required. The name of the deployment.
        /// </param>
        /// <param name='dnsServerName'>
        /// Required. The name of the dns server.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Update DNS Server operation.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static Task<OperationStatusResponse> BeginUpdatingDNSServerAsync(this IDNSServerOperations operations, string serviceName, string deploymentName, string dnsServerName, DNSUpdateParameters parameters)
        {
            return operations.BeginUpdatingDNSServerAsync(serviceName, deploymentName, dnsServerName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Deletes a definition for an existing DNS server from the deployment
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IDNSServerOperations.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the service.
        /// </param>
        /// <param name='deploymentName'>
        /// Required. The name of the deployment.
        /// </param>
        /// <param name='dnsServerName'>
        /// Required. The name of the dns server.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static OperationStatusResponse DeleteDNSServer(this IDNSServerOperations operations, string serviceName, string deploymentName, string dnsServerName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDNSServerOperations)s).DeleteDNSServerAsync(serviceName, deploymentName, dnsServerName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Deletes a definition for an existing DNS server from the deployment
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IDNSServerOperations.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the service.
        /// </param>
        /// <param name='deploymentName'>
        /// Required. The name of the deployment.
        /// </param>
        /// <param name='dnsServerName'>
        /// Required. The name of the dns server.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static Task<OperationStatusResponse> DeleteDNSServerAsync(this IDNSServerOperations operations, string serviceName, string deploymentName, string dnsServerName)
        {
            return operations.DeleteDNSServerAsync(serviceName, deploymentName, dnsServerName, CancellationToken.None);
        }
        
        /// <summary>
        /// Updates a definition for an existing DNS server. Updates to address
        /// is the only change allowed. DNS server name cannot be changed
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IDNSServerOperations.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the service.
        /// </param>
        /// <param name='deploymentName'>
        /// Required. The name of the deployment.
        /// </param>
        /// <param name='dnsServerName'>
        /// Required. The name of the dns server.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Update DNS Server operation.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static OperationStatusResponse UpdateDNSServer(this IDNSServerOperations operations, string serviceName, string deploymentName, string dnsServerName, DNSUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDNSServerOperations)s).UpdateDNSServerAsync(serviceName, deploymentName, dnsServerName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Updates a definition for an existing DNS server. Updates to address
        /// is the only change allowed. DNS server name cannot be changed
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IDNSServerOperations.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the service.
        /// </param>
        /// <param name='deploymentName'>
        /// Required. The name of the deployment.
        /// </param>
        /// <param name='dnsServerName'>
        /// Required. The name of the dns server.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Update DNS Server operation.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static Task<OperationStatusResponse> UpdateDNSServerAsync(this IDNSServerOperations operations, string serviceName, string deploymentName, string dnsServerName, DNSUpdateParameters parameters)
        {
            return operations.UpdateDNSServerAsync(serviceName, deploymentName, dnsServerName, parameters, CancellationToken.None);
        }
    }
}