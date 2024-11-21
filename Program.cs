//1
using System.Globalization;
//lager 2 heltall
int a = 54;
int b = 17;

//lager en metode som summerer to heltall
int AddTwoNumbers(int A, int B)
{
    return A + B;
}

//skriver ut summen av a og b
Console.WriteLine(AddTwoNumbers(a, b));

//2
//lager et ferdig array av typen int med noen tallverdier
int[] array = [1, 2, 4, 7, 18, 3, 8];

//lager en metode som summerer alle verdiene i et array
static int ArrayTotal(int[] C)
{
    int sum = 0;
    
    for (int x = 0; x < C.Length; x++)
    {
        sum += C[x];
    }
    return sum;
}
//summerer og skriver ut summen av arrayet array
Console.WriteLine(ArrayTotal(array));

//3
//lager et nytt dictionary myDictionary med 3 entries
Dictionary<string, int> myDictionary = new Dictionary<string , int>()
{
    {"Andreas", 31},
    {"Tom", 40},
    {"Kari", 60}
};

//lager 4 keyvaluepairs med navn og alder
KeyValuePair<string, int> harald = new KeyValuePair<string, int>("Harald", 35);
KeyValuePair<string, int> eva = new KeyValuePair<string, int>("Eva", 50);
KeyValuePair<string, int> håkon = new KeyValuePair<string, int>("Håkon", 80);
KeyValuePair<string, int> dudleif = new KeyValuePair<string, int>("dudleif", 108);y
//legger til entries til mydictionary, navn inn som key og alder inn som value
myDictionary.Add(harald.Key, harald.Value);
myDictionary.Add(eva.Key, eva.Value);
myDictionary.Add(håkon.Key, håkon.Value);
myDictionary.Add(dudleif.Key, dudleif.Value);

//går igjennom hver entry i myDictionary og skriver ut alle verdiene
foreach (KeyValuePair<string, int> person in myDictionary)
{
    Console.WriteLine(person);
}







