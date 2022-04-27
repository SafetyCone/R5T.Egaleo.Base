using System;using R5T.T0064;


namespace R5T.Egaleo
{[ServiceDefinitionMarker]
    public interface IOrganizationDirectoryNameConvention:IServiceDefinition
    {
        string GetOrganizationDirectoryName(string organizationName);
    }
}
