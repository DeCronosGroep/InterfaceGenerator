namespace InterfaceGenerator;

internal class Attributes
{
    public static string AttributesNamespace { get; set; } = nameof(InterfaceGenerator);

    public const string GenerateAutoInterfaceClassname = "GenerateAutoInterfaceAttribute";
    public const string AutoInterfaceIgnoreAttributeClassname = "AutoInterfaceIgnoreAttribute";

    public const string VisibilityModifierPropName = "VisibilityModifier";
    public const string InterfaceNamePropName = "Name";

    public static string AttributesSourceCode => $$"""
            global using {{GenerateAutoInterfaceClassname}} = {{AttributesNamespace}}.{{GenerateAutoInterfaceClassname}};
            global using {{AutoInterfaceIgnoreAttributeClassname}} = {{AttributesNamespace}}.{{AutoInterfaceIgnoreAttributeClassname}};

            using System;
            using System.Diagnostics;

            #nullable enable

            #pragma warning disable MA0048 // File name must match type name

            namespace {{AttributesNamespace}};
            
            [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false)]
            [Conditional("CodeGeneration")]
            internal sealed class {{GenerateAutoInterfaceClassname}} : Attribute
            {
                public string? {{VisibilityModifierPropName}} { get; init; } 
                public string? {{InterfaceNamePropName}} { get; init; } 

                public {{GenerateAutoInterfaceClassname}}()
                {
                }
            }

            [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, Inherited = false)]
            [Conditional("CodeGeneration")]
            internal sealed class {{AutoInterfaceIgnoreAttributeClassname}} : Attribute
            {
            }

            #pragma warning restore MA0048 // File name must match type name
            """;
}