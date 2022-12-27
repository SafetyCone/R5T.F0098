using System;

using R5T.T0132;


namespace R5T.F0098
{
    [FunctionalityMarker]
    public partial interface IDirectoryNameOperator : IFunctionalityMarker
    {

    }
}


namespace R5T.F0098.Internal
{
    [FunctionalityMarker]
    public partial interface IDirectoryNameOperator : IFunctionalityMarker,
        F0000.IDirectoryNameOperator
    {
        public string Get_ApplicationDirectoryName(string applicationName)
        {
            var applicationDirectoryName = this.ConvertToDirectoryName(applicationName);
            return applicationDirectoryName;
        }
    }
}