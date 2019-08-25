using System;
using System.Text;

namespace Library.Extensions.Exceptions
{
    public static class ExceptionExtensions
    {
        public static string FullMessage(this Exception ex)
        {
            var builder = new StringBuilder();
            while (ex != null)
            {
                builder.AppendFormat($"{ex.Message}{Environment.NewLine}");
                ex = ex.InnerException;
            }
            return builder.ToString();
        }
    }
}
