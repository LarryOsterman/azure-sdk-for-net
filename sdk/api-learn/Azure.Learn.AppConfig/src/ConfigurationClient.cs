using System;
using System.Collections.Generic;
using System.Text;
using Azure.Core;

namespace Azure.Learn.AppConfig
{
    public class ConfigurationClient
    {
        public ConfigurationClient(Uri endpoint, TokenCredential credential) : this(endpoint, credential, new ConfigurationClientOptions())
        {
        }

#pragma warning disable CA1801
        public ConfigurationClient(Uri endpoint, TokenCredential credential, ConfigurationClientOptions options)
        {
        }

#pragma warning disable CA1801
        protected ConfigurationClient()
        {
        }
    }
}
