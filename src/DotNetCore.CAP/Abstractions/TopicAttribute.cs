﻿using System;

namespace DotNetCore.CAP.Abstractions
{
    /// <inheritdoc />
    /// <summary>
    /// An abstract attribute that for  kafka attribute or rabbit mq attribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = true)]
    public abstract class TopicAttribute : Attribute
    {
        protected TopicAttribute(string name)
        {
            Name = name;
        }

        /// <summary>
        /// topic or exchange route key name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// kafka --> groups.id
        /// rabbit MQ --> queue.name
        /// </summary>
        public string Group { get; set; } = "cap.default.group";
    }
}