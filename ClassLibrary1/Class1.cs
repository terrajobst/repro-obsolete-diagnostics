using System;

namespace ClassLibrary1
{
    [Obsolete(DiagnosticId = "IMMO0001")]
    public class Class1
    {
    }

    [Obsolete("Nope")]
    public class Class2
    {
    }

    [Obsolete]
    public class Class3
    {
    }
}
