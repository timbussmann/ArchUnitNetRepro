namespace ArchUnitNetRepro;

public class ExampleClass(ExampleService service)
{
    public async Task DoSomethingAsync()
    {
        await service.SomeAsyncMethod();
    }
}