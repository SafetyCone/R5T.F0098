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
            var applicationDirectoryName = Instances.DirectoryNameOperator_Internal.Get_ApplicationDirectoryName(applicationName);

            var applicationSpecificOutputDirectoryPath = Instances.PathOperator.Get_DirectoryPath(
                baseOutputDirectoryPath,
                applicationDirectoryName);

            return applicationSpecificOutputDirectoryPath;
        }

        public string Get_DatedApplicationSpecificOutputDirectoryPath(
            string baseOutputDirectoryPath,
            string applicationName,
            DateTime date)
        {
            var applicationDirectoryName = Instances.DirectoryNameOperator_Internal.Get_ApplicationDirectoryName(applicationName);
            var datedDirectoryName = Instances.DirectoryNameOperator.Get_DatedDirectoryName(date);

            var output = Instances.PathOperator.Get_DirectoryPath(
                baseOutputDirectoryPath,
                applicationDirectoryName,
                datedDirectoryName);

            return output;
        }

        public string Get_DateTimedApplicationSpecificOutputDirectoryPath(
            string baseOutputDirectoryPath,
            string applicationName,
            DateTime dateTime)
        {
            var applicationDirectoryName = Instances.DirectoryNameOperator_Internal.Get_ApplicationDirectoryName(applicationName);
            var dateTimedDirectoryName = Instances.DirectoryNameOperator.Get_DateTimedDirectoryName(dateTime);

            var output = Instances.PathOperator.Get_DirectoryPath(
                baseOutputDirectoryPath,
                applicationDirectoryName,
                dateTimedDirectoryName);

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
            var applicationDirectoryName = Instances.DirectoryNameOperator_Internal.Get_ApplicationDirectoryName(applicationName);

            var applicationSpecificOutputDirectoryPath = Instances.PathOperator.Get_DirectoryPath(
                baseOutputDirectoryPath,
                applicationDirectoryName);

            return applicationSpecificOutputDirectoryPath;
        }
    }
}
