using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Generators
{
  [Generator]
  class ImportGenerator : ISourceGenerator
  {
    public void Initialize(GeneratorInitializationContext context)
    {
    }

    public void Execute(GeneratorExecutionContext context)
    {
      var compilation = context.Compilation;
      var importAttribute = compilation.GetTypeByMetadataName("CSharp20212.SourceGenerators.ImportAttribute");

      var typeSymbols = new HashSet<ITypeSymbol>();
      foreach (var syntaxTree in compilation.SyntaxTrees)
      {
        var semanticModel = compilation.GetSemanticModel(syntaxTree);
        foreach (var typeSymbol in syntaxTree.GetRoot().DescendantNodesAndSelf()
          .OfType<ClassDeclarationSyntax>()
          .Select(x=>semanticModel.GetDeclaredSymbol(x))
          .OfType<ITypeSymbol>()
          .Where(x=>x.GetAttributes().Any(x=>x.AttributeClass.Equals(importAttribute))))
        {
          typeSymbols.Add(typeSymbol);
        }
      }

      foreach (var typeSymbol in typeSymbols)
      {
        var sb = new StringBuilder();
        sb.Append(
          @"
using System;

namespace CSharp20212.SourceGenerators
{
  public static partial class SharedUtil
  {
");
        foreach (var attributeData in typeSymbol.GetAttributes())
        {
          if (attributeData.AttributeClass.Equals(importAttribute))
          {
            var argument = attributeData.ConstructorArguments[0];
            sb.Append("    public static " + argument.Value);
            switch (argument.Value)
            {
              case "Table ImportCsv(string path)":
              {
                sb.Append(
                  @"
    {
      var document = OpenFile(path);
      var table = new Table();
      foreach (var row in document.Rows)
      {
        table.Import(row);
      }

      return table;
    }

");
                break;
              }

              case "Table ImportCsvRow(string path, int row)":
              {
                  
                sb.Append(
                  @"
    {
      var document = OpenFile(path);
      var table = new Table();
      var singleRow = document[row];
      table.Import(singleRow);
      return table;
    }

");
                break;
              }

              case "Table ImportCsv(string path, Range range)":
              {
                sb.Append(
                  @"
    {
      var document = OpenFile(path);
      var table = new Table();
      foreach (var rowIndex in range)
      {
        var row = document[rowIndex];
        table.Import(row);
      }
      return table;
    }

");
                break;
              }
            }
          }
        }

        sb.Append(
          @"
  }
}");

        context.AddSource("SharedUtil.cs", sb.ToString());
      }
    }
  }
}