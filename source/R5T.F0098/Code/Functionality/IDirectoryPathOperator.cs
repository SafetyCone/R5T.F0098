using System;

using R5T.T0132;


namespace R5T.F0098
{
    [FunctionalityMarker]
    public partial interface IDirectoryPathOperator : IFunctionalityMarker
    {
        public string Get_ApplicationSpecificOutputDirectoryPath(
            string baseOutputDirectoryPath,
            string applicationName)
        {
            var applicationDirectoryName = Internal.DirectoryNameOperator.Instance.Get_ApplicationDirectoryName(applicationName);

            var applicationSpecificOutputDirectoryPath = Instances.PathOperator.GetDirectoryPath(
                baseOutputDirectoryPath,
                applicationDirectoryName);

            return applicationSpecificOutputDirectoryPath;
        }

        public string Get_DatedApplicationSpecificOutputDirectoryPath(
            string baseOutputDirectoryPath,
            string applicationName,
            DateTime date)
        {
            var applicationDirectoryName = Internal.DirectoryNameOperator.Instance.Get_ApplicationDirectoryName(applicationName);
            var datedDirectoryName = F0000.DirectoryNameOperator.Instance.Get_DatedDirectoryName(date);

            var output = Instances.PathOperator.GetDirectoryPath(
                baseOutputDirectoryPath,
                applicationDirectoryName,
                datedDirectoryName);

            return output;
        }
    }
}


namespace R5T.F0098.Internal
{
    [FunctionalityMarker]
    public partial interface IDirectoryPathOperator : IFunctionalityMarker
    {
        public static string Get_ApplicationSpecificOutputDirectoryPath(
            string baseOutputDirectoryPath,
            string applicationName)
        {
            var applicationDirectoryName = DirectoryNameOperator.Instance.Get_ApplicationDirectoryName(applicationName);

            var applicationSpecificOutputDirectoryPath = Instances.PathOperator.GetDirectoryPath(
                baseOutputDirectoryPath,
                applicationDirectoryName);

            return applicationSpecificOutputDirectoryPath;
        }
    }
}
