# Cloud.Azure.Storage.Services.Blobs.BlobReference

[![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/cloud-azure-storage-services-blobs-blobreference.svg?label=AppVeyor&style=for-the-badge)](https://ci.appveyor.com/project/cdorst/cloud-azure-storage-services-blobs-blobreference)
[![NuGet package status](https://img.shields.io/nuget/v/CDorst.Cloud.Azure.Storage.Services.Blobs.BlobReference.svg?label=NuGet&style=for-the-badge)](https://www.nuget.org/packages/CDorst.Cloud.Azure.Storage.Services.Blobs.BlobReference)

## Description

Service responsible for getting a reference to a blob (which may or may not yet exist) inside an existing blob container

## Environment Variables

This project depends on this environment variable:

Name | Description
---- | -----------
`LOCAL_NUGET_SOURCE_PATH` | *Required* to build the project, but not required during code execution. This is set to `c:\projects\nuget\cache` on the build server. On your development machine, set this to an empty, existing path. `dotnet restore` will inspect this folder prior to checking NuGet.

## Dependencies

Name | Status
---- | ------
[CDorst.Cloud.Azure.Storage.Services.Blobs.Interfaces.BlobContainerReferenceGetter](https://github.com/CDorst/Cloud.Azure.Storage.Services.Blobs.Interfaces.BlobContainerReferenceGetter) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/cloud-azure-storage-services-blobs-interfaces-blob.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/cloud-azure-storage-services-blobs-interfaces-blob) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Cloud.Azure.Storage.Services.Blobs.Interfaces.BlobContainerReferenceGetter.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Cloud.Azure.Storage.Services.Blobs.Interfaces.BlobContainerReferenceGetter)
[CDorst.Cloud.Azure.Storage.Services.Blobs.Interfaces.ExistingContainerBlobReferenceGetter](https://github.com/CDorst/Cloud.Azure.Storage.Services.Blobs.Interfaces.ExistingContainerBlobReferenceGetter) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/cloud-azure-storage-services-blobs-interfaces-exis.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/cloud-azure-storage-services-blobs-interfaces-exis) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Cloud.Azure.Storage.Services.Blobs.Interfaces.ExistingContainerBlobReferenceGetter.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Cloud.Azure.Storage.Services.Blobs.Interfaces.ExistingContainerBlobReferenceGetter)

## NuGet

This project is published as a NuGet package at [https://www.nuget.org/packages/CDorst.Cloud.Azure.Storage.Services.Blobs.BlobReference](https://www.nuget.org/packages/CDorst.Cloud.Azure.Storage.Services.Blobs.BlobReference)

## Version

1.0.0

## Metaproject

Cloud.Azure.Storage.Services.Blobs.BlobReference is maintained by robots and exists because of a declarative template metaproject. View the metaproject's component directory at [https://github.com/CDorst/Project.Index](https://github.com/CDorst/Project.Index)

