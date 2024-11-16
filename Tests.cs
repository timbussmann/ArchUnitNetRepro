using ArchUnitNET.Domain;
using ArchUnitNET.Loader;
using ArchUnitNET.NUnit;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace ArchUnitNetRepro;

public class Tests
{
    static readonly Architecture Architecture = new ArchLoader().LoadAssemblies(typeof(ExampleClass).Assembly).Build();
    
    [Test]
    public void ShouldNotCallServiceMethod()
    {
        Classes().Should().NotCallAny(MethodMembers().That().AreDeclaredIn(typeof(ExampleService)))
            .Check(Architecture);
    }
}