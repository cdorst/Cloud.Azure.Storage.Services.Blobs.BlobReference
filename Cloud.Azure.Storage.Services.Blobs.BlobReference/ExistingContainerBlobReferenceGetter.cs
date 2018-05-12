// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using Cloud.Azure.Storage.Services.Blobs.Interfaces.BlobContainerReferenceGetter;
using Cloud.Azure.Storage.Services.Blobs.Interfaces.ExistingContainerBlobReferenceGetter;
using Microsoft.WindowsAzure.Storage.Blob;
using System;

namespace Cloud.Azure.Storage.Services.Blobs.BlobReference
{
    /// <summary>Service responsible for getting a reference to a blob (which may or may not yet exist) inside an existing blob container</summary>
    public class ExistingContainerBlobReferenceGetter : IExistingContainerBlobReferenceGetter
    {
        private readonly IBlobContainerReferenceGetter _container;

        public ExistingContainerBlobReferenceGetter(IBlobContainerReferenceGetter cloudBlobContainer)
        {
            _container = cloudBlobContainer ?? throw new ArgumentNullException(nameof(cloudBlobContainer));
        }

        /// <summary>Returns CloudBlockBlob reference</summary>
        public CloudBlockBlob GetBlobReference(string containerName, string blobName) => _container.GetExistingContainer(containerName).GetBlockBlobReference(blobName);
    }
}
