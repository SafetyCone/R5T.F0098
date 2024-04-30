using System;

using R5T.T0132;


namespace R5T.F0098
{
    [FunctionalityMarker]
    public partial interface IDirectoryNameOperator : IFunctionalityMarker,
        L0066.IDirectoryNameOperator
    {

    }
}


namespace R5T.F0098.Internal
{
    [FunctionalityMarker]
    public partial interface IDirectoryNameOperator : IFunctionalityMarker
    {
        public string Get_ApplicationDirectoryName(string applicationName)
        {
            var applicationDirectoryName = Instances.DirectoryNameOperator.Convert_ToDirectoryName(applicationName);
            return applicationDirectoryName;
        }
    }
}