# C# Uncommon Error: Accessing a Disposed Object

This repository demonstrates a common, yet sometimes difficult-to-detect error in C#: attempting to access a disposed object.  The `bug.cs` file contains the erroneous code, while `bugSolution.cs` provides a corrected version.

**The Problem:**
The `MyMethod` function uses a `MemoryStream` within a `using` statement. The `using` statement ensures the stream is automatically disposed of at the end of the block. However, the code attempts to write to the stream *after* it has been disposed, which results in an `ObjectDisposedException`. This exception can be challenging to debug because it doesn't always occur immediately and might manifest in unexpected ways further down the execution path.

**The Solution:**
The `bugSolution.cs` file corrects this by ensuring that all operations on the `MemoryStream` occur *within* the `using` block.  No access attempts are made after disposal.