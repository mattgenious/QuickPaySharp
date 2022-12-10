using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace QuickPaySharp.Client
{
	public static class Extensions
	{
        /// <summary>
        /// Read a stream into a byte array
        /// </summary>
        /// <param name="input">Stream to read</param>
        /// <param name="cancellationToken"></param>
        /// <returns>byte[]</returns>
        public static async Task<byte[]> ReadAsBytes(this Stream input, CancellationToken cancellationToken)
        {
            byte[] buffer = new byte[16384];
            using MemoryStream ms = new MemoryStream();
            int count;
            while ((count = await input.ReadAsync(buffer, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)) > 0)
            {
                ms.Write(buffer, 0, count);
            }
            return ms.ToArray();
        }
    }
}

