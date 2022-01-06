# Neu

The escape hatch

## What is this?

From `Tests/`:

### test01.neu

```
func main() -> Int {

    return 0
}
```

A basic function

### test02.neu

```
func main() -> Float {

    return 0.0
}
```

Returns a Float type instead of an Int, both are type checked.

## LLIR / MLIR

This project is in no way associated with LLVM project, however it is heavily influenced by it. The plan here is to have two layers of intermediate representation between the language and the machine. This design is directly taken from the LLVM project, with the plan that perhaps one day Neu may take advantage of those technologies at some point.

That said, early iterations of these IRs may not resemble their distant cousins from the LLVM project.

## Stage 0

This current attempt is the tenth serious one at building this thing, starting from not really knowing anything about how a computer works. I have vacillated over which language to start with and in my indecision have settled at two:
- C# - It's a very good toolchain, and Neu needn't inherit any of the properties of the language used to implement Stage 0. That does mean ruling out any .NET shortcuts (nothing managed, no .dlls, no CLR etc.)
- C - The purest of academics will simply only accept C (i.e. not even C++). This is for them, though I have no real plan for this, other than some initial opinions about things like treating char strictly like a byte how UTF-8 ought be handled. Contributions definitely welcome here. Neu Mks 4 - 9 are all in C, and I have yet to rationalise down that code into this repo.

## Disclaimer

I have no idea what I am doing.