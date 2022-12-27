using System;


namespace R5T.F0098
{
    public class DirectoryNameOperator : IDirectoryNameOperator
    {
        #region Infrastructure

        public static IDirectoryNameOperator Instance { get; } = new DirectoryNameOperator();


        private DirectoryNameOperator()
        {
        }

        #endregion
    }
}


namespace R5T.F0098.Internal
{
    public class DirectoryNameOperator : IDirectoryNameOperator
    {
        #region Infrastructure

        public static IDirectoryNameOperator Instance { get; } = new DirectoryNameOperator();


        private DirectoryNameOperator()
        {
        }

        #endregion
    }
}