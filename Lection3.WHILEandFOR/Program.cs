﻿string Method4(int count, string c)
{
    string result = string.Empty;
    for(int i=0;i<count;i++)
 
    {result= result+c;}
    return result;
}
string res = Method4(10, "qwert");
Console.WriteLine(res);
