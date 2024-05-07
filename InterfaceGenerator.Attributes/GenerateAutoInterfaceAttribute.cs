namespace InterfaceGenerator;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false)]
public sealed class GenerateAutoInterfaceAttribute : Attribute
{
    public string? VisibilityModifier { get; set; }
    public string? Name { get; set; }

    public GenerateAutoInterfaceAttribute()
    { }
}