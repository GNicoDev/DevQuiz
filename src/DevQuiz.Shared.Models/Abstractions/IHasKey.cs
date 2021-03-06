using System;

namespace DevQuiz.Shared.Models.Abstractions
{
    /// <summary>
    ///     Generic interface for entries which has a unique key
    /// </summary>
    /// <typeparam name="TKey">Unique key type</typeparam>
    public interface IHasKey<TKey>
        where TKey : IEquatable<TKey>
    {
        /// <summary>
        ///     Unique key
        /// </summary>
        TKey Id { get; set; }
    }
}