﻿using System;

using BetterCms.Configuration;
using BetterCms.Module.WindowsAzureStorage;

using NUnit.Framework;

namespace BetterCms.Test.Module.WindowsAzureStorage
{
    [TestFixture]
    public class WindowsAzureStorageServiceTest : StorageTestBase
    {
        private const string AzureAccountName = "AzureAccountName";
        private const string AzureSecondaryKey = "AzureSecondaryKey";
        private const string AzureContainerName = "AzureContainerName";
        private const string AzureUseHttps = "AzureUseHttps";

        [Test]
        public void Should_Upload_Object()
        {
            var configuration = MockConfiguration();
            var azureClient = new WindowsAzureStorageService(configuration);

            ShouldUploadObject(configuration, azureClient);
        }

        [Test]
        public void Should_Download_Object()
        {
            var configuration = MockConfiguration();
            var azureClient = new WindowsAzureStorageService(configuration);

            ShouldDownloadObject(configuration, azureClient);
        }

        [Test]
        public void Should_Copy_Object()
        {
            var configuration = MockConfiguration();
            var azureClient = new WindowsAzureStorageService(configuration);

            ShouldCopyObject(configuration, azureClient);
        }

        protected override ICmsStorageConfiguration GetStorageConfiguration(Configuration.CmsTestConfigurationSection serviceSection)
        {
            var accountName = serviceSection.AzureStorage.GetValue(AzureAccountName);
            var secretKey = serviceSection.AzureStorage.GetValue(AzureSecondaryKey);

            if (!string.IsNullOrWhiteSpace(accountName) && !string.IsNullOrWhiteSpace(secretKey))
            {
                return serviceSection.AzureStorage;
            }

            accountName = Environment.GetEnvironmentVariable("BETTERCMS_AZURE_STORAGE_ACCOUNT_KEY", EnvironmentVariableTarget.User);
            secretKey = Environment.GetEnvironmentVariable("BETTERCMS_AZURE_STORAGE_SECONDARY_KEY", EnvironmentVariableTarget.User);
            if (!string.IsNullOrWhiteSpace(accountName) || !string.IsNullOrWhiteSpace(secretKey))
            {
                var containerName = Environment.GetEnvironmentVariable("BETTERCMS_AZURE_STORAGE_CONTAINER_NAME", EnvironmentVariableTarget.User);
                var useHttps = Environment.GetEnvironmentVariable("BETTERCMS_AZURE_STORAGE_USE_HTTPS", EnvironmentVariableTarget.User);

                var configuration = new CmsStorageConfigurationElement
                {
                    ContentRoot = Environment.GetEnvironmentVariable("BETTERCMS_AZURE_STORAGE_CONTENT_ROOT", EnvironmentVariableTarget.User),
                    ServiceType = StorageServiceType.Auto
                };

                configuration.Add(new KeyValueElement { Key = AzureAccountName, Value = accountName });
                configuration.Add(new KeyValueElement { Key = AzureSecondaryKey, Value = secretKey });
                configuration.Add(new KeyValueElement { Key = AzureContainerName, Value = containerName });
                if (!string.IsNullOrWhiteSpace(useHttps))
                {
                    configuration.Add(new KeyValueElement { Key = AzureUseHttps, Value = useHttps });
                }

                return configuration;
            }

            return null;
        }
    }
}
