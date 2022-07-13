
static int[] RandomArray()
{
    Random rnd = new Random();
    int[] myArray = new int[10];
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = rnd.Next(5, 26);
        Console.WriteLine(myArray[i] + " this is " + i + "this is value");
    }
    return myArray;

}
RandomArray();

static int sum(int[] myArray)
{
    int sum = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
        sum = sum + myArray[i];
    }
    return sum;
}



static int min(int[] myArray)
{

    int min = myArray[0];
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] < min)
        {
            min = myArray[i];
        }

    }
    return min;
}


static int max(int[] myArray)
{
    int max = myArray[0];
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] > max)
        {
            max = myArray[i];
        }
    }
    return max;
}


static string TossCoin(){
    Console.WriteLine("Tossing a coin");
    Random rnd = new Random();
    int a = rnd.Next(0,2);
    if (a==0)
    {
        string b = "Heads";
        return b;
    }else{
        string c = "Tails";
        return c ;
    }
    }
    Console.WriteLine(TossCoin());


static List<string> Names (){
List<string> emrat = new List<string>(5);
List<string> emratedyte = new List<string>(5);
emrat.Add("Todd");
emrat.Add("Tiffany");
emrat.Add("Charlie");
emrat.Add("Geneva");
emrat.Add("Sydeny");
for (int i = 0; i < emrat.Count; i++)
{
if(emrat[i].Length> 5 )
emratedyte.Add(emrat[i]);
}
return emratedyte;
}
Names();

List<string> printolista = Names();

for (int i = 0; i < printolista.Count; i++)
{
    Console.WriteLine(printolista[i]);
}