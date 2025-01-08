# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property before it has been initialized.  Uninitialized properties will have default values (0 for integers, null for objects, etc.) but relying on these defaults can lead to unexpected behavior and make your code harder to debug.

**The Bug:**
The `bug.cs` file shows a class with a property `MyProperty` that is accessed within the `MyMethod` function before being assigned a value. This results in the output of the property's default value which can cause unexpected behavior.

**The Solution:**
The `bugSolution.cs` file provides a corrected version where `MyProperty` is initialized before being accessed, ensuring predictable and reliable code.

This example highlights the importance of initializing properties before use to avoid potential issues and improve code clarity.