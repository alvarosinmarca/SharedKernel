﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace SharedKernel.Application.System
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISemaphore
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="semaphoreSlim"></param>
        /// <param name="executeAsync"></param>
        /// <param name="cancellationToken">Propagates notification that operations should be canceled.</param>
        /// <returns></returns>
        Task BlockAsync(SemaphoreSlim semaphoreSlim, Func<Task> executeAsync, CancellationToken cancellationToken);
    }
}
