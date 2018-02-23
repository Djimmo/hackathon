namespace Binck.OpenApi
{
    using System;

    /// <summary>
    /// Overload DateTime.now so we can use it in our unit tests
    /// </summary>
    public static class SystemTime
    {
        /// <summary>
        /// Convert time to json string
        /// </summary>
        public static Func<DateTime> Now = () => DateTime.UtcNow;
    }
}