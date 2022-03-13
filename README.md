# Toaster has been superseded by EXPLORE
 Plugin Framework for the Sunrise Encryption Tool
 
 ```
Required Components
- Toaster
- .NET Framework 4.8 DLL
```

### Making a Plugin
```csharp
using Toaster;

class ExamplePlugin
{

 // This will be executed when the user clicks on the Plugins Panel inside the Encryption Tool
 public static void Initalize()
 {
  Toasting toast = new Toasting();
  toast.AddPluginName("ExamplePlugin");
  toast.AddPluginAuthor("Monarch TSA");
  toast.AddPluginVersion("1.0.0");
  toast.AddPluginInfo("An example plugin for the Sunrise Encryption Tool");
  
  toast.Load();
 }
 
 // This will be executed when the user selects the plugin and clicks the button to Load the plugin
 public static object Load(string input)
 {
  char[] charArray = input.ToCharArray();
  Array.Reverse( charArray );
  return new string( charArray );
 }
}
```
