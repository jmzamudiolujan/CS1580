// ***********************************************************************
// <copyright file="RepoClass.cs" company="GBM">
//     GBM GRUPO BURSÁTIL MEXICANO, S.A DE C.V., CASA DE BOLSA
// </copyright>
// ***********************************************************************

namespace ConsoleApp2
{
    /// <summary>
    /// class RepoClass
    /// </summary>
    /// <threadsafety>
    /// Any public static (Shared in Visual Basic) members of this type are thread safe.
    /// Any instance members are not guaranteed to be thread safe.
    /// </threadsafety>
    public static class RepoClass
    {
        /// <summary>
        /// Determines whether <paramref name="source"/> has a value, not null or default value for <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The underlying type of <paramref name="source"/>.</typeparam>
        /// <param name="source">The source.</param>
        /// <returns><see langword="true"/> if the specified source has value; otherwise, <see langword="false"/>.</returns>
        public static bool HasValue<T>(this T? source)
           where T : struct
        {
            if (source != null)
            {
                if (!source.Value.Equals(default(T)))
                {
                    return true;
                }
            }

            return false;
        }


        /// <summary>
        /// Internally use <see cref="RepoClass.HasValue{T}(T?)"/>.
        /// </summary>
        public static void SomeMethod()
        {
        }
    }
}
