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
        /// This method wires up any startup logic required by the "do nothing" 
        /// logging strategy.
        /// </summary>
        /// <param name="applicationBuilder">The application builder to use 
        /// for the operation.</param>
        /// <param name="hostEnvironment">The hosting environment to use for the
        /// application.</param>
        /// <returns>The value of the <paramref name="applicationBuilder"/>
        /// parameter, for chaining calls together.</returns>
        /// <exception cref="ArgumentException">This exception is thrown whenever
        /// one or more of the required parameters is missing or invalid.</exception>
        public static IApplicationBuilder UseDoNothingStrategies(
            this IApplicationBuilder applicationBuilder,
            IHostEnvironment hostEnvironment
            )
        {
            // Nothing to do here, just an example method.

            // Return the builder.
            return applicationBuilder;
        }

        #endregion
    }
}
