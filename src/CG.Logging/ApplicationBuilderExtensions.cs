using CG.Validations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using System;

namespace Microsoft.Extensions.Hosting
{
    /// <summary>
    /// This class contains extension methods related to the <see cref="IApplicationBuilder"/>
    /// types.
    /// </summary>
    public static partial class ApplicationBuilderExtensions
    {
        // *******************************************************************
        // Public methods.
        // *******************************************************************

        #region Public methods

        /// <summary>
        /// This method wires up any startup logic required for the logging 
        /// services.
        /// </summary>
        /// <param name="applicationBuilder">The application builder to use 
        /// for the operation.</param>
        /// <param name="hostEnvironment">The hosting environment to use for the
        /// application.</param>
        /// <param name="configurationSection">The configuration section to use 
        /// for the operation.</param>
        /// <returns>The value of the <paramref name="applicationBuilder"/>
        /// parameter, for chaining calls together.</returns>
        /// <exception cref="ArgumentException">This exception is thrown whenever
        /// one or more of the required parameters is missing or invalid.</exception>
        public static IApplicationBuilder UseLogging(
            this IApplicationBuilder applicationBuilder,
            IWebHostEnvironment hostEnvironment,
            string configurationSection
            )
        {
            // Validate the parameters before attempting to use them.
            Guard.Instance().ThrowIfNull(applicationBuilder, nameof(applicationBuilder))
                .ThrowIfNull(hostEnvironment, nameof(hostEnvironment))
                .ThrowIfNull(configurationSection, nameof(configurationSection));

            // Call the use method for the strategy.
            applicationBuilder.UseStrategies(
                configurationSection
                );

            // Return the builder.
            return applicationBuilder;
        }

        #endregion
    }
}
