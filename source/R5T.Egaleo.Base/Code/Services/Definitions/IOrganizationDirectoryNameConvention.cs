using System;


namespace R5T.Egaleo
{
    public interface IOrganizationDirectoryNameConvention
    {
        string GetOrganizationDirectoryName(string organizationName);
    }
}
