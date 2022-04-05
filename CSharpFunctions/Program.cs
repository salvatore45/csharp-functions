// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
void StampaArrayInteri(int[] array)
{
    int ultimoIndiceArray = array.Length - 1;
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == ultimoIndiceArray)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
    }
    Console.WriteLine("]");
}
int Quadrato(int numero)
{
    int quadratonumero = numero * numero;
    return quadratonumero;
}
int[] ElevaArrayAlQuadrato(int[] array)
{
    int[]copiaArray = (int[])array.Clone();
    for (int i = 0; i < copiaArray.Length; i++) ;
    {
        copiaArray[i] = copiaArray[i] * copiaArray[i];
    }
    return copiaArray;
}
int[] sommaArray(int[] array)
{
    int
}