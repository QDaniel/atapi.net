using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
[assembly: AssemblyTrademark("ATAPI")]
[assembly: AssemblyCulture("")]
[assembly: CLSCompliant(true)]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("4fe5e41e-a00d-45a6-b6a5-d4f5a294b63e")]

// Avoid TypeLoad exceptions under .NET4
[assembly: SecurityRules(SecurityRuleSet.Level1)]
