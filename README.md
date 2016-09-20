# What this solution is for

This solution serves to showcase improvements introduced in new releases of ReSharper Ultimate products in a compact and code-centric way.

To JetBrains employees, it allows reusing sample code across all kinds of communications related to a particular ReSharper Ultimate release, such as blog posts, web help, social media updates, videos and live demos.

To users of ReSharper Ultimate products, it helps get an overview of changes in a particular release by reading code and playing with it.

## How this solution is organized

There's a solution folder (i.e. "10.1") for each new ReSharper Ultimate release.

Every solution folder hosts multiple projects of different types. A specific set of projects depends on the nature and scope of changes in a particular release. If a release brings changes in terms of WCF and Node.js support, you can expect it to contain a WCF service project and a Node.js application project.

The projects contain code files with code samples that demonstrate how a particular new feature or improvement is expected to work. Of course, there are also files with of boilerplate and configuration code.

To skip irrelevant code and navigate between code samples that demonstrate improvements in a release, use *To-do Explorer* (ReSharper > Windows > To-do Explorer) and filter to show to-do items that correspond to a release you're interested in.

For example, *101EAP1* is a to-do pattern that highlights changes introduced in ReSharper Ultimate 10.1 (2016.1) EAP 1. As soon as ReSharper Ultimate 10.1 (2016.1) hits final release, all patterns that represent its EAP builds are merged into one pattern: *20161RTM*.

The custom to-do patterns representing particular releases are saved in a .dotsettings file that comes with this solution.

## Disclaimer

As many ReSharper features are used to fix broken code and sample code in this solution serves to demonstrate how it does so, no project contained here is expected to be compilable.

As code in this solution specifically serves to demonstrate ReSharper Ultimate functionality, it does not have to make any practical sense and usually fails to do so.

## Requirements
* Visual Studio 2015
* Version of ReSharper Ultimate
* Project-specific requirements:
    * ReSharper101NodeJsExpress:
        * Node.js (https://nodejs.org/en/download/)
        * Node.js Tools for Visual Studio (https://www.visualstudio.com/en-us/features/node-js-vs.aspx)
    * ReSharper20162TS-JS:
        * TypeScript 2.0.0 Beta for Visual Studio 2015 (http://download.microsoft.com/download/6/D/8/6D8381B0-03C1-4BD2-AE65-30FF0A4C62DA/TS2.0.0-TS-release20-nightly-20160708.1/TypeScript_Dev14Full.exe) or later
    * TypeScript2016.3:
        * TypeScript 2.0.0 RC for Visual Studio 2015 (http://download.microsoft.com/download/6/D/8/6D8381B0-03C1-4BD2-AE65-30FF0A4C62DA/TS2.0.2-TS-release20-nightly-20160828.1/TypeScript_Dev14Full.exe)
