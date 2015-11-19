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
using Microsoft.Azure.Management.DataLake.AnalyticsCatalog.Models;

namespace Microsoft.Azure.Management.DataLake.AnalyticsCatalog
{
    /// <summary>
    /// Operations for managing the Data Lake Analytics catalog
    /// </summary>
    public partial interface ICatalogOperations
    {
        /// <summary>
        /// Creates the specified secret for use with external data sources in
        /// the specified database
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resourceGroup the Data Lake Analytics account is in
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database to create the secret in.
        /// </param>
        /// <param name='parameters'>
        /// The parameters required to create the secret (name and password)
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The create secret operation response.
        /// </returns>
        Task<CatalogSecretCreateResponse> CreateSecretAsync(string resourceGroupName, string accountName, string databaseName, DataLakeAnalyticsCatalogSecretCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deletes the specified secret in the specified database
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resourceGroup the Data Lake Analytics account is in
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database to delete the secret from.
        /// </param>
        /// <param name='secretName'>
        /// The name of the secret to delete
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The create secret operation response.
        /// </returns>
        Task<CatalogSecretCreateResponse> DeleteSecretAsync(string resourceGroupName, string accountName, string databaseName, string secretName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieves the specified assembly from the current DataLakeAnalytics
        /// catalog
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resourceGroup the Data Lake Analytics account is in
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database to find the assembly in.
        /// </param>
        /// <param name='assemblyName'>
        /// The name of the assembly to find.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Database operation response.
        /// </returns>
        Task<CatalogAssemblyGetResponse> GetAssemblyAsync(string resourceGroupName, string accountName, string databaseName, string assemblyName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieves the specified database from the current DataLakeAnalytics
        /// catalog
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resourceGroup the Data Lake Analytics account is in
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='databaseName'>
        /// The path to the file to create.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Database operation response.
        /// </returns>
        Task<CatalogDatabaseGetResponse> GetDatabaseAsync(string resourceGroupName, string accountName, string databaseName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieves the specified external data source from the current
        /// DataLakeAnalytics catalog
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resourceGroup the Data Lake Analytics account is in
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database to find the external Data Source in.
        /// </param>
        /// <param name='externalDataSourceName'>
        /// The name of the external Data Source to find.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get external data source operation response.
        /// </returns>
        Task<CatalogExternalDataSourceGetResponse> GetExternalDataSourceAsync(string resourceGroupName, string accountName, string databaseName, string externalDataSourceName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieves the specified schema from the current DataLakeAnalytics
        /// catalog
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resourceGroup the Data Lake Analytics account is in
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database to find the schema in.
        /// </param>
        /// <param name='schemaName'>
        /// The name of the schema to find.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get schema operation response.
        /// </returns>
        Task<CatalogSchemaGetResponse> GetSchemaAsync(string resourceGroupName, string accountName, string databaseName, string schemaName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieves the specified table from the current DataLakeAnalytics
        /// catalog
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resourceGroup the Data Lake Analytics account is in
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database to find the table in.
        /// </param>
        /// <param name='schemaName'>
        /// The name of the schema to find the table in.
        /// </param>
        /// <param name='tableName'>
        /// The name of the table to find.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get table operation response.
        /// </returns>
        Task<CatalogTableGetResponse> GetTableAsync(string resourceGroupName, string accountName, string databaseName, string schemaName, string tableName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieves the specified table from the current DataLakeAnalytics
        /// catalog
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resourceGroup the Data Lake Analytics account is in
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database to find the statistics in.
        /// </param>
        /// <param name='schemaName'>
        /// The name of the schema to find the statistics in.
        /// </param>
        /// <param name='tableName'>
        /// The name of the table to find the statistics in.
        /// </param>
        /// <param name='statisticsName'>
        /// The name of the table statistics to find.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get table statistics operation response.
        /// </returns>
        Task<CatalogTableStatisticsGetResponse> GetTableStatisticAsync(string resourceGroupName, string accountName, string databaseName, string schemaName, string tableName, string statisticsName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieves the specified table valued function from the current
        /// DataLakeAnalytics catalog
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resourceGroup the Data Lake Analytics account is in
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database to find the table valued function in.
        /// </param>
        /// <param name='schemaName'>
        /// The name of the schema to find the table valued function in.
        /// </param>
        /// <param name='tableValuedFunctionName'>
        /// The name of the tableValuedFunction to find.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get table valued function operation response.
        /// </returns>
        Task<CatalogTableValuedFunctionGetResponse> GetTableValuedFunctionAsync(string resourceGroupName, string accountName, string databaseName, string schemaName, string tableValuedFunctionName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieves the list of assemblies from the current DataLakeAnalytics
        /// catalog
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resourceGroup the Data Lake Analytics account is in
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database to find the assembly in.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Database operation response.
        /// </returns>
        Task<CatalogAssemblyListGetResponse> ListAssembliesAsync(string resourceGroupName, string accountName, string databaseName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieves the list of databases from the current DataLakeAnalytics
        /// catalog
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resourceGroup the Data Lake Analytics account is in
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Database operation response.
        /// </returns>
        Task<CatalogDatabaseListResponse> ListDatabasesAsync(string resourceGroupName, string accountName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieves the list of external data sources from the current
        /// DataLakeAnalytics catalog
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resourceGroup the Data Lake Analytics account is in
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database to find the external Data Source in.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List external data source operation response.
        /// </returns>
        Task<CatalogExternalDataSourceListResponse> ListExternalDataSourcesAsync(string resourceGroupName, string accountName, string databaseName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieves the list of schemas from the current DataLakeAnalytics
        /// catalog
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resourceGroup the Data Lake Analytics account is in
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database to find the schema in.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List schema operation response.
        /// </returns>
        Task<CatalogSchemaListResponse> ListSchemasAsync(string resourceGroupName, string accountName, string databaseName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieves the list of tables from the current DataLakeAnalytics
        /// catalog
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resourceGroup the Data Lake Analytics account is in
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database to find the tables in.
        /// </param>
        /// <param name='schemaName'>
        /// The name of the schema to find the tables in.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List tables operation response.
        /// </returns>
        Task<CatalogTableListResponse> ListTablesAsync(string resourceGroupName, string accountName, string databaseName, string schemaName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieves the list of tables from the current DataLakeAnalytics
        /// catalog
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resourceGroup the Data Lake Analytics account is in
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database to find the statistics in.
        /// </param>
        /// <param name='schemaName'>
        /// The name of the schema to find the statistics in.
        /// </param>
        /// <param name='tableName'>
        /// The name of the table to find the statistics in.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List table statistics operation response.
        /// </returns>
        Task<CatalogTableStatisticsListResponse> ListTableStatisticsAsync(string resourceGroupName, string accountName, string databaseName, string schemaName, string tableName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieves the list of table valued functions from the current
        /// DataLakeAnalytics catalog
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resourceGroup the Data Lake Analytics account is in
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database to find the table valued functions in.
        /// </param>
        /// <param name='schemaName'>
        /// The name of the schema to find the table valued functions in.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List table valued functions operation response.
        /// </returns>
        Task<CatalogTableValuedFunctionListResponse> ListTableValuedFunctionsAsync(string resourceGroupName, string accountName, string databaseName, string schemaName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Modifies the specified secret for use with external data sources in
        /// the specified database
        /// </summary>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resourceGroup the Data Lake Analytics account is in
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database to modify the secret in.
        /// </param>
        /// <param name='parameters'>
        /// The parameters required to modify the secret (name and password)
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The create secret operation response.
        /// </returns>
        Task<CatalogSecretCreateResponse> UpdateSecretAsync(string accountName, string resourceGroupName, string databaseName, DataLakeAnalyticsCatalogSecretCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
    }
}