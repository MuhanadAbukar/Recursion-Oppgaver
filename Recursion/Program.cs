//oppgave 1
int help(int n, int x)
{

    if (x == n)
        return n;
    x++;
    Console.WriteLine(x);
    return help(n, x);
}
help(10, 0);

//oppgave 2
int help2(int n)
{
    if (n == 1)
        return n;
    Console.WriteLine(n);
    return help2(n - 1);
}
help2(10);

//oppgave 3
int sum(int n)
{
    if (n != 0)
        return n + sum(n - 1);

    return n;

}
Console.WriteLine(sum(5));

//oppgv 4
string ret(string inp, int rec)
{
    if (rec == inp.Length)
        return inp;
    Console.WriteLine(inp[rec]);
    rec++;
    return inp + ret(inp, rec);
}
ret("123456789", 0);

// ooppgv 5
int help3(int n, int rec)
{
    if (n.ToString().Length == 1)
        return rec + 1;

    var x = int.Parse(n.ToString().Substring(0, n.ToString().Length - 1));
    rec++;
    return help3(x, rec);
}
Console.WriteLine(help3(150, 0));