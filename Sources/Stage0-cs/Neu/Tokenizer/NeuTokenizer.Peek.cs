
namespace Neu;

public static partial class NeuTokenizerFunctions {

    public static NeuToken? MaybePeek(
        this Tokenizer<NeuToken> tokenizer) {

        if (tokenizer.Position + 1 <= tokenizer.Tokens.Count) {

            return tokenizer.Tokens.ElementAt(tokenizer.Position);
        }

        ///

        if (tokenizer.Scanner.IsEof()) {

            return null;
        }

        ///

        var next = tokenizer.Next();

        tokenizer.Tokens.Add(next);

        return next;
    }
}