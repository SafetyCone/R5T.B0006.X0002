using System;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.B0006;

using Instances = R5T.B0006.X0002.Instances;


namespace N0001.Generation.Initial.Parse.Simple
{
    /// <summary>
    /// Generation, initial, parse, simple extensions.
    /// </summary>
    public static partial class ISyntaxGeneratorExtensions
    {
        public static UsingDirectiveSyntax ParseUsingDirective_Simple(this ISyntaxGenerator _,
            string text)
        {
            var output = Instances.SyntaxGenerator_ParseSimple.ParseUsingDirective(text);
            return output;
        }
    }
}
