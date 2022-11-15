
namespace Microsoft.Extensions.Logging
{
    /// <summary>
    /// This class is a text fixture for the <see cref="BootstrapLogger"/>
    /// type.
    /// </summary>
    [TestClass]
    public class BootstrapLoggerFixture
    {
        // *******************************************************************
        // Public methods.
        // *******************************************************************

        #region Public methods

        /// <summary>
        /// This method ensures the <see cref="BootstrapLogger.Instance"/> method
        /// returns an <see cref="ILogger"/> instance.
        /// </summary>
        [TestMethod]
        [TestCategory("Unit")]
        public void BootstrapLogger_Instance()
        {
            // Arrange ...

            // Act ...
            var logger = BootstrapLogger.Instance();

            // Assert ...
            Assert.IsTrue(
                logger is not null,
                "The bootstrap logger was invalid!"
                );
            Assert.IsTrue(
                (logger as BootstrapLogger)._innerLogger is not null,
                "The inner logger was invalid!"
                );
        }

        // *******************************************************************

        /// <summary>
        /// This method ensures the <see cref="BootstrapLogger.LogLevelToInformation"/> 
        /// method configures the logger to use <see cref="LogLevel.Information"/>
        /// level logging.
        /// </summary>
        [TestMethod]
        [TestCategory("Unit")]
        public void BootstrapLogger_LogLevelToInformation()
        {
            // Arrange ...

            // Act ...
            BootstrapLogger.LogLevelToInformation();

            var logger = BootstrapLogger.Instance();

            // Assert ...
            Assert.IsFalse(
                logger.IsEnabled(LogLevel.Trace),
                "Trace log level check failed!"
                );
            Assert.IsFalse(
                logger.IsEnabled(LogLevel.Debug),
                "Debug log level check failed!"
                );
            Assert.IsTrue(
                logger.IsEnabled(LogLevel.Information),
                "The log level is invalid!"
                );
            Assert.IsTrue(
                logger.IsEnabled(LogLevel.Warning),
                "The log level is invalid!"
                );
            Assert.IsTrue(
                logger.IsEnabled(LogLevel.Error),
                "The log level is invalid!"
                );
            Assert.IsTrue(
                logger.IsEnabled(LogLevel.Critical),
                "The log level is invalid!"
                );            
        }

        #endregion
    }
}
