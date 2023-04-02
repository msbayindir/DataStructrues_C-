using DataStructruesLibs.Array;


var a = new Array<int>(1,2,3,4,5);



var b = a.Where(x => x < 4);


foreach (var item in b)
{
    Console.WriteLine(item);
}

