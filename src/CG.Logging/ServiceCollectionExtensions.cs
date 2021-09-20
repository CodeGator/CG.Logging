using CG.Validations;
using Microsoft.Extensions.Configuration;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// This class contains extension methods related to the <see cref="IServiceCollection"/>
    /// types, for registering types related to logging
    /// </summary>
    public static partial class ServiceCollectionExtensions
    {
        // *******************************************************************
        // Public methods.
        // *******************************************************************

        #region Public methods

        /// <summary>
        /// This method adds strategies for logging to the specified service 
        /// collection.
        /// </summary>
        /// <param name="serviceCollection">The service collection to use for 
        /// the operation.</param>
        /// <param name="configuration">The configuration to use for the operation.</param>
        /// <param name="serviceLifetime">The service lifetime to use for the operation.</param>
        /// <returns>The value of the <paramref name="serviceCollection"/>
        /// parameter, for chaining calls together.</returns>
        /// <exception cref="ArgumentException">This exception is thrown whenever
        /// a required argument is missing or invalid.</exception>
        public static IServiceCollection AddLogging(
            this IServiceCollection serviceCollection,
            IConfiguration configuration,
            ServiceLifetime serviceLifetime = ServiceLifetime.Scoped
            )
        {
            // Validate the parameters before attempting to use them.
            Guard.Instance().ThrowIfNull(serviceCollection, nameof(serviceCollection))
                .ThrowIfNull(configuration, nameof(configuration));

            // Logging is a little different in that we don't actually define 
            //   an ILogger type, since it's already part of .NET, and we don't
            //   define a concrete Logger type, since that's also part of .NET.
            // What we do here is try to adapt our strategy loader methods so they
            //   work with whatever strategy is currently configured, for logging,
            //   just like our other strategy and/or repository based abstractions.

            // So, no service type to register here ...

            // Register the strategy(s).
            serviceCollection.AddStrategies(
                configuration,
                serviceLifetime,
                "Logging"
                );

            // Return the service collection.
            return serviceCollection;
        }

        #endregion
    }
}
