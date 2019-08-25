using System;

namespace Library.Extensions.Exceptions
{
    public class DivideSample
    {
        public static double Divide(int amount, int by)
        {
            try
            {
                return amount / by;
            }
            catch (Exception ex)
            {
                var invalidOpEx = new InvalidOperationException("Invalid operation", ex);
                var message = string.Format($"Divide failed - amount: {amount}, by: {by}");
                throw new ApplicationException(message, invalidOpEx);
            }
        }
    }
}
