try
{

    string firstName = "MARC LOUIEGI";
    string lastname = " B. OLINO";

    //CONCATENATION
    string fullname = firstName + " " + lastname;
    Console.WriteLine("  \n Concatenation");
    Console.WriteLine($"FULLNAME: {fullname} \n");

    //STRING INTERPOLATION
    Console.WriteLine("Interpolation");
    Console.WriteLine($"HELLO {firstName} {lastname}! \n");

    //LENGTH
    Console.WriteLine("Length");
    Console.WriteLine($"LENGTH OF FULL NAME: {fullname.Length} \n");

    //ToUpper and ToLower
    Console.WriteLine("ToUpper and ToLower");
    Console.WriteLine($"UPPERCASE: {fullname.ToUpper()} \n");
    Console.WriteLine($"LOWER CASE: {fullname.ToLower()} \n");

    //SUBSTRING
    Console.WriteLine("Substring");
    Console.WriteLine($"FIRST NAME (substring): {fullname.Substring(0, firstName.Length)} \n");

    //CONTAINS
    Console.WriteLine("Contains");
    Console.WriteLine($"DOES FULLNAME CONTAINS 'MARC'? {fullname.Contains("ART")} \n");

    //REPLACE
    Console.WriteLine("Replace");
    Console.WriteLine($"REPLACE 'MARC LOUIEGI' with 'MR.' : {fullname.Replace("MARC LOUIEGI", "MR.")} \n");

}
catch
{

}
