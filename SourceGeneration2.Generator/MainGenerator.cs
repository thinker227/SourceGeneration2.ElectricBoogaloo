using System;
using System.Linq;
using Microsoft.CodeAnalysis;

namespace SourceGeneration2.Generator {
	[Generator]
	public class MainGenerator : ISourceGenerator {

		public void Execute(GeneratorExecutionContext context) {
			var main = context.Compilation.GetEntryPoint(context.CancellationToken);

			string source = $@"
using System;

namespace {main.ContainingNamespace.Name} {{
	partial class {main.ContainingType.Name} {{
		
		private static partial void HelloFrom(string name) =>
			Console.WriteLine($""Hi from '{{name}}'"");
		
	}}
}}
";

			context.AddSource("GeneratedSource", source);
		}

		public void Initialize(GeneratorInitializationContext context) {

		}

	}
}
