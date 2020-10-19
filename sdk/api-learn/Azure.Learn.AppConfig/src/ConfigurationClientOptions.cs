using System;
using System.Collections.Generic;
using System.Text;
using Azure.Core;

namespace Azure.Learn.AppConfig
{
    /// <summary>
    /// The options for <see cref="ConfigurationClient"/>.
    /// </summary>
    public class ConfigurationClientOptions : ClientOptions
    {
        internal string Version { get; }

        /// <summary>
        /// Creates a new instance of the <see cref="ConfigurationClientOptions"/> class.
        /// </summary>
        /// <param name="version">Version for use in the class.</param>
        public ConfigurationClientOptions(ServiceVersion version = ServiceVersion.V1_0)
        {
            Version = version switch
            {
                ServiceVersion.V1_0 => "1.0",
                _ => throw new ArgumentException($"The service version {version} is not supported by this library.", nameof(version));

            };
        }

        /// <summary>
        /// The AppConfig service version.
        /// </summary>
        public enum ServiceVersion
        {
            /// <summary>
            /// Service Version 1.0 of the APpConfig service.
            /// </summary>
#pragma warning disable CA1707
            V1_0 = 0,
#pragma warning restore CA1707
        }
    }
}
