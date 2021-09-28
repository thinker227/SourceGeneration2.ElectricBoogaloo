using System;

namespace SourceGeneration2.ElectricBoogaloo {
	internal static partial class Program {

		private static void Main() {
			HelloFrom("Generated code");
		}

		static partial void HelloFrom(string name);

	}
}
