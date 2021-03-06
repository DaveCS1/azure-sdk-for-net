// 
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// 

namespace Microsoft.Azure.Batch.Common
{
    using System;
    using System.Linq;
    
    /// <summary>
    /// The state of a pool.
    /// </summary>
    public enum PoolState
    {
        /// <summary>
        /// The pool is available to run tasks subject to the availability of compute nodes.
        /// </summary>
        Active,
        
        /// <summary>
        /// The user has requested that the pool be deleted, but the delete
        /// operation has not yet completed.
        /// </summary>
        Deleting,
    }
}
