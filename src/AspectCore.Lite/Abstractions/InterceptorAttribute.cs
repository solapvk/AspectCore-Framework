﻿using System;
using System.Threading.Tasks;

namespace AspectCore.Lite.Abstractions
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Interface , AllowMultiple = false , Inherited = false)]
    public abstract class InterceptorAttribute : Attribute, IInterceptor, IFromServiceable
    {
        public virtual int Order { get; set; }

        public virtual Task ExecuteAsync(IAspectContext aspectContext , InterceptorDelegate next) => next(aspectContext);
    }
}