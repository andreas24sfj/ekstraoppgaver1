//1
using System.Globalization;

int a = 54;
int b = 17;


int AddTwoNumbers(int A, int B)
{
    return A + B;
}

Console.WriteLine(AddTwoNumbers(a, b));

//2
int[] array = [1, 2, 4, 7, 18, 3, 8];

static int ArrayTotal(int[] C)
{
    int sum = 0;
    
    for (int x = 0; x < C.Length; x++)
    {
        sum += C[x];
    }
    return sum;
}

Console.WriteLine(ArrayTotal(array));
//3
Dictionary<string, int> myDictionary = new Dictionary<string , int>()
{
    {"Andreas", 31},
    {"Tom", 40},
    {"Kari", 60}
};

KeyValuePair<string, int> harald = new KeyValuePair<string, int>("Harald", 35);
KeyValuePair<string, int> eva = new KeyValuePair<string, int>("Eva", 50);
KeyValuePair<string, int> håkon = new KeyValuePair<string, int>("Håkon", 80);
KeyValuePair<string, int> dudleif = new KeyValuePair<string, int>("dudleif", 108);
myDictionary.Add(harald.Key, harald.Value);
myDictionary.Add(eva.Key, eva.Value);
myDictionary.Add(håkon.Key, håkon.Value);
myDictionary.Add(dudleif.Key, dudleif.Value);

foreach (KeyValuePair<string, int> person in myDictionary)
{
    Console.WriteLine(person);
}







