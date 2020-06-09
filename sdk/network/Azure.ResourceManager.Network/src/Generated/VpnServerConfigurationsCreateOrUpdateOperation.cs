// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> Creates a VpnServerConfiguration resource if it doesn&apos;t exist else updates the existing VpnServerConfiguration. </summary>
    public partial class VpnServerConfigurationsCreateOrUpdateOperation : Operation<VpnServerConfiguration>, IOperationSource<VpnServerConfiguration>
    {
        private readonly ArmOperationHelpers<VpnServerConfiguration> _operation;
        internal VpnServerConfigurationsCreateOrUpdateOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<VpnServerConfiguration>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "VpnServerConfigurationsCreateOrUpdateOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override VpnServerConfiguration Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VpnServerConfiguration>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VpnServerConfiguration>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        VpnServerConfiguration IOperationSource<VpnServerConfiguration>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            if (document.RootElement.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            else
            {
                return VpnServerConfiguration.DeserializeVpnServerConfiguration(document.RootElement);
            }
        }

        async ValueTask<VpnServerConfiguration> IOperationSource<VpnServerConfiguration>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            if (document.RootElement.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            else
            {
                return VpnServerConfiguration.DeserializeVpnServerConfiguration(document.RootElement);
            }
        }
    }
}