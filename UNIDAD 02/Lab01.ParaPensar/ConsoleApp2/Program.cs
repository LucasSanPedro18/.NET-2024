
bool a=true;
bool b=true;
bool c=false;
bool d=true;

if (!a && b)
        { Console.WriteLine("Primera"); }
else if(!d || (a && c ))
        { Console.WriteLine("Segunda"); }
        else if ((c || d) || (a && b ))
                 { Console.WriteLine("Tercer"); }
                 else
                 { Console.WriteLine("Cuarta Instrucción"); }
