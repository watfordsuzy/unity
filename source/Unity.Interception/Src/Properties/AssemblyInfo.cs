// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//[assembly: AssemblyTitle("Microsoft.Practices.Unity.InterceptionExtension")]
//[assembly: AssemblyDescription("Interception support for the Unity Application Block")]

[assembly: CLSCompliant(true)]
[assembly: ComVisible(false)]

#if !SILVERLIGHT
[assembly: AllowPartiallyTrustedCallers]
#endif

[assembly: NeutralResourcesLanguage("en")]
