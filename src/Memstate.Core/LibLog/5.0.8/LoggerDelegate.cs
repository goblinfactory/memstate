// <auto-generated/>
// ReSharper disable CheckNamespace
namespace Memstate.Logging
{
    using System;

#if !LIBLOG_PROVIDERS_ONLY || LIBLOG_PUBLIC
    /// <summary>
    /// Logger delegate.
    /// </summary>
    /// <param name="logLevel">The log level</param>
    /// <param name="messageFunc">The message function</param>
    /// <param name="exception">The exception</param>
    /// <param name="formatParameters">The format parameters</param>
    /// <returns>A boolean.</returns>
    public
#else
    internal
#endif
        delegate bool Logger(LogLevel logLevel, Func<string> messageFunc, Exception exception = null, params object[] formatParameters);
}
