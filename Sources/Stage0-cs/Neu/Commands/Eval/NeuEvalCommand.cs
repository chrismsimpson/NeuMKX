
namespace Neu;

public class NeuEvalCommand: ICommand {

    public NeuEvalCommand() { }

    ///

    public async Task Run(
        IEnumerable<IArgument> arguments) {

        await Task.Run(() => {

            throw new Exception();
        });
    }
}