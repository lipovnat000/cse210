/* 
    This is equivalent to Python's import statement

    The using directive has two uses:

    1. To allow the use of types in a namespace so that you do not have to qualify the use of a type in that namespace.
    2. To create an alias for a namespace or a type.
*/
using System;

/*
    This is equivalent to Python's print statement

    The WriteLine method writes the specified data, followed by the current line terminator, 
    to the standard output stream. 
*/
Console.WriteLine("Hello, what is your name?");

/* 
    This is equivalent to Python's input function, notice that we must ask for the user's input
    first in a seperate Console.WriteLine statement.

    The ReadLine method reads a line from the standard input stream. 
    The line is read as a string. If the standard input device is the keyboard, 
    the ReadLine method blocks until the user presses the Enter key.
*/
string name = Console.ReadLine();

/* 
    This is equivalent to Python's f-string and print statement.

    The WriteLine method writes the specified data, followed by the current line terminator, 
    to the standard output stream. 
*/
Console.WriteLine($"Hello, {name}!");