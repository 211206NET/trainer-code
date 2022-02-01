# C#: Reflection

## Reflection Defn
- Introspection
- Mirror image

- Reflection in C# describes the ability for assemblies, types, and modules to get metadata during runtime.

- These are particularly useful for dynamic or late binding that occurs run time

- In order to use reflection, include `System.Reflection` in your `.cs` file, and then get the type by either `.GetType()` method or `typeof()`. 

- With the type class, We can get things like Property, Method info of a type. We can also get name of Assemblies, Type, Modules, and namespaces they belong, etc. (So essentially metadata about these things)

### Useful docs:
- [MsDoc Reflection](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/reflection)
- [Viewing Type Info](https://docs.microsoft.com/en-us/dotnet/framework/reflection-and-codedom/viewing-type-information)
- [TutorialsPoint](https://www.tutorialspoint.com/csharp/csharp_reflection.htm)
- [Stackify](https://stackify.com/what-is-c-reflection/)