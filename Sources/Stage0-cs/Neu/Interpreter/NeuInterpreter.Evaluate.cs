
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuValue Evaluate(
        this NeuInterpreter interpreter,
        String filename,
        IEnumerable<IArgument> arguments,
        bool dumpAST = false) {
            
        var parser = NeuParser.FromFile(filename);

        ///

        var source = parser.ParseSource();

        ///

        if (dumpAST) {

            WriteLine($"{source.Dump()}\n");
        }

        ///

        return interpreter.Execute(source, arguments);
    }
}