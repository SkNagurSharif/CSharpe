namespace Namespace;
public class Access
{
/*
Access Modifiers are also called as Access Specifiers
Access modifiers are Keywords tp specify the accessibility of a class, method, field or variable

1. Public
2. Private
3. Protected
4. Internal
5. Protected Internal

|-------------------------------------------------------------------------------------------------------------------------------------|
|    Keyword        |   Inside Same Assemmbly where member is declared     |  Other Assembly where containing Assembly id referenced  |
|      or           |----------------------------------------------------- |----------------------------------------------------------|
| Access Specifier  | Inside Same Class | Inside Derived Class | Other Code|          Inside Derived Class  |         Other code      |
| -------------------------------------------------------------------------|----------------------------------------------------------|
|  Public             |      Yes          |      Yes           |    Yes    |                  Yes          |          Yes             |                                             |   
|  Private            |      Yes          |      Noooooo       | Noooooo   |             Noooooo           |     Noooooo              |
|  Protected          |      Yes          |      Yes           |   Noooooo |                  Yes          |        Noooooo           |   
|  Internal           |      Yes          |      Yes           |    Yes    |             Noooooo           |           Noooooo        |   
|  Protected Internal |      Yes          |      Yes           |    Yes    |                  Yes          |              Noooooo     |   
|-------------------------------------------------------------------------------------------------------------------------------------|

Default Access modifier/ specifier is also known as " Internal"
*/
public string hell = "Hello Nagur !";


// Default or internal Access modifier / Specifier
    static void Main(string[] args)
    {
        Access access = new Access();
        Console.WriteLine(access.hell);
    }
}
