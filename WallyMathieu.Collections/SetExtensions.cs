using System;
using System.Collections.Generic;
using System.Linq;

namespace WallyMathieu.Collections
{
    /// <summary>
    /// Extensions on sets.
    /// </summary>
    public static class SetExtensions
    {
        /// <summary>
        /// Compare two sets.
        /// The comparison is the equivalent of doing <code>right.Except(left)</code> and <code>left.Except(right)</code>
        /// </summary>
        /// <example>
        /// <code>
        /// var comparison = db.PublishedProducts.ToHashSet().SymmetricDiff(body.ProductIds.ToHashSet());
        /// var onlyInRight = comparison.OnlyInRight;
        /// var onlyInLeft = comparison.OnlyInLeft;
        /// </code>
        /// </example>
        public static ISymmetricDifference<T> SymmetricDiff<T>(this ISet<T> right, ISet<T> left) 
        {
            var onlyInRight = right.Except(left);
            var onlyInLeft = left.Except(right);

            return new SymmetricDifference<T>(onlyInRight, onlyInLeft);
        }
    }
   
}
