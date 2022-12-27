using System;


namespace R5T.F0098
{
    public class DirectoryPathOperator : IDirectoryPathOperator
    {
        #region Infrastructure

        public static IDirectoryPathOperator Instance { get; } = new DirectoryPathOperator();


        private DirectoryPathOperator()
        {
        }

        #endregion
    }
}


namespace R5T.F0098.Internal
{
    public class DirectoryPathOperator : IDirectoryPathOperator
    {
        #region Infrastructure

        public static IDirectoryPathOperator Instance { get; } = new DirectoryPathOperator();


        private DirectoryPathOperator()
        {
        }

        #endregion
    }
}
