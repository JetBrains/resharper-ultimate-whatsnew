
* EAP1
  * ReSharper
    * Support of ASP.NET Core 1.0 RC2 projects (not full).
    * Support of Razor Tag Helpers (resolve, completion, search, refactorings).
    * TypeScript
      * Generative code completion (ctorf/ctorp, overrides, lambdas [RSRP-420390])
      * Generate missing members now works for contextually typed object literals
      * Improved find usages and rename for union and intersection types
      * More TypeScript 2.0 features are supported: this for functions, control-flow aware type guards, path mappings, optional class members, 'never' type
      * Proper overriding for Object members (RSRP-458338) - should fix issues for sugar.js users
      * Support for index.ts in module resolution (RSRP-458807) - should fix issues with resolving angular2 auto-generated module stubs
    * C# formatter: new indenting engine with options for parenthesis indenting (see screenshot at RSRP-260807)
    * C# new [typing assists](ReSharper20162CSharp/TypeAssistance.cs) (https://twitter.com/controlflow/status/734508760761270272/photo/1)
    * Mark referenced as used at runtime in optimize references and remove unused referenced ( https://youtrack.jetbrains.com/issue/RSRP-412908, https://youtrack.jetbrains.com/issue/RSRP-287369) 