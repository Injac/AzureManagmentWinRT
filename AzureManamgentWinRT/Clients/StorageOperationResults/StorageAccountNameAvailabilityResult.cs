﻿using AzureManamgentWinRT.ErrorHandling;
using AzureManamgentWinRT.Model.Storage;

namespace AzureManamgentWinRT.Clients.StorageOperationResults
{
    /// <summary>
    /// The result returned by the check storage account name
    /// availability opertation.
    /// </summary>
    public class StorageAccountNameAvailabilityResult : AsyncExecutionResult
    {
        /// <summary>
        /// Gets or sets the operation result.
        /// </summary>
        /// <value>The operation result.</value>
        public StorageAccountNameAvailablitiy OperationResult { get; set; }
    }
}
