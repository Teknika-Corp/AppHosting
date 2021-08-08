﻿using System;

namespace AppHosting.Abstractions.Internal
{
    /// <summary>
    /// Handles registration of events.
    /// </summary>
    public interface ILifecycleRegister
    {
        /// <summary>
        /// Registers a given callback.
        /// </summary>
        /// <param name="callback">The callback to be registered.</param>
        void Register(Action callback);
    }
}