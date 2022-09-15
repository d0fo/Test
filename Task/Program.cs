// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter array length:");
int ArrayLength = Convert.ToInt32(Console.ReadLine());
string[] FirstArray = new string[ArrayLength];
string[] SecondArray = new string[ArrayLength];
void FillArray(string[]n)
{
    Console.WriteLine("Enter array elements:");
    for (int i = 0; i<n.Length; i++)
    {
        n[i]=Convert.ToString(Console.ReadLine());
    }
}
void SelectionElements(string[] n, string[] m)
{
    for (int i = 0; i < n.Length; i++)
    {
    if(n[i].Length <= 3)
        {
            m[i] = n[i];
        }
    }
}
void PrintArray(string[] m)
{
    Console.WriteLine("Elements with less or equal 3 signs are:");
    for (int i = 0; i < m.Length; i++)
    {
        Console.Write(m[i]+" ");
    }
}
FillArray(FirstArray);
SelectionElements(FirstArray, SecondArray);
PrintArray(SecondArray);