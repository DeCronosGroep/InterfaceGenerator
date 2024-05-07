namespace InterfaceGenerator;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, Inherited = false)]
public sealed class AutoInterfaceIgnoreAttribute : Attribute
{
}