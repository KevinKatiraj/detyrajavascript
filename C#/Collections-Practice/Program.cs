//Three Basic Arrays

//1-Create an array to hold integer values 0 through 9

int [] myArray = new int[9];
    for(int i = 0 ; i <= 9 ; i++){
        Console.WriteLine(i);
    }

//Create an array of the names "Tim", "Martin", "Nikki", & "Sara"

string [] stringarr = new string[]{
    "Tim", "Martin", "Nikki", "Sara"
};
for (int i = 0; i < stringarr.Length; i++)
{
    Console.WriteLine(stringarr[i]);
}

//Create an array of length 10 that alternates between true and false values, starting with true

bool [] boolsarr = new bool[10];
{
    for (int i = 0; i < boolsarr.Length; i++) {
        if (i % 2 == 0)
        {
            boolsarr[i] = true;
        }
        else{
            boolsarr[i] = false;
        }
    }
}

for (int i = 0; i < boolsarr.Length; i++)
{
    Console.WriteLine(boolsarr[i]);
}

//List of Flavors

//Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)

List<string> icecrams = new List<string>();

icecrams.Add("Vanilje");
icecrams.Add("Cokollate");
icecrams.Add("Fruta Pylli");
icecrams.Add("Redbull");
icecrams.Add("Luleshtrydhe");

Console.WriteLine(icecrams.Count);
Console.WriteLine(icecrams[2]);
icecrams.Remove("Fruta Pylli");
Console.WriteLine(icecrams.Count);

//User Info Dictionary

//Create a dictionary that will store both string keys as well as string values

Dictionary<string,string> kursantet = new Dictionary<string,string>();

Random rnd = new Random();

for(int i=0 ; i<4 ; i++){
    kursantet.Add(stringarr[i] , icecrams[rnd.Next(0,4)]);
}

foreach(KeyValuePair <string, string> elem1 in kursantet)
{
    Console.WriteLine(elem1.Key + " - " + elem1.Value);
}