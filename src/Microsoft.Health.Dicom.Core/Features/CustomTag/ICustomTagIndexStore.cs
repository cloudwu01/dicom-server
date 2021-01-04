﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System.Threading;
using System.Threading.Tasks;
using Microsoft.Health.Dicom.Core.Features.Model;

namespace Microsoft.Health.Dicom.Core.Features.CustomTag
{
    public interface ICustomTagIndexStore
    {
        // TODO: make it allow add bunch indexes
        Task AddCustomTagStringIndexes(long customTagKey, VersionedInstanceIdentifier instanceIdentifier, string indexValue, CancellationToken cancellationToken = default);
    }
}
