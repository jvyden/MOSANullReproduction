// Copyright (c) MOSA Project. Licensed under the New BSD License.

// #nullable disable
#nullable enable

using System;

// ReSharper disable all

namespace MOSANullReproduction;

public static class Program
{
    public static string String = null!;
    
    public static void Setup()
    {
        String = "Hello!";
        Console.WriteLine(String);
    }

    public static void Loop()
    {
    }
}