
Console.WriteLine("Введите 4 числа через пробел");
string[] nado = Console.ReadLine().Split(" ");


static void Swap(ref string a, ref string b)
{
    string temp = a;
    a = b;
    b = temp;
}
static void Permutate(string[] arr, int index, int x)
{
    
    if (index >= arr.Length)
    {
       /* Console.Write("{0,3}",arr[0]);
        Console.Write("{0,3}",arr[1]);
        Console.Write("{0,3}",arr[2]);
        Console.Write("{0,3}",arr[3]);*/
        
        
        int[] nado2 = new int[arr.Length];
        string[] znak = ["+", "-", "*","/"];
        string[] znaknyz = new string[znak.Length];
        for (int i = 0;i<nado2.Length; i++)
        {
            nado2[i] = Convert.ToInt32(arr[i]);
        }
       
        for (int p = 0; p<arr.Length-1; p++)
        {
            for (int q = 0; q < arr.Length - 1; q++)
            {
                for (int l = 0; l < arr.Length - 1; l++)
                {
                    for (int r = 0; r < arr.Length - 1; r++) {
                        znaknyz[0] = znak[p];
                        znaknyz[1] = znak[q];
                        znaknyz[2] = znak[l];
                        znaknyz[3] = znak[r];
                    Stack<int> output = new Stack<int>(nado2);
                        for (int i = 0; i < arr.Length - 1; i++)
                        {
                            switch (znaknyz[i])
                            {
                                case "+":
                                    output.Push(output.Pop() + output.Pop());
                                    break;
                                case "-":
                                    int sec = output.Pop();
                                    int fir = output.Pop();
                                    output.Push(Math.Abs(sec - fir));
                                    break;
                                case "*":
                                    output.Push(output.Pop() * output.Pop());
                                    break;
                                case "/":
                                    int sec1 = output.Pop();
                                    int fir2 = output.Pop();
                                    output.Push(sec1 / fir2);
                                    break;

                            }
                        }

                        x = output.Pop();
                        if (x == 24)
                        {
                            Console.WriteLine("YES");
                            Environment.Exit(0);

                        }
                    }
                }
            }
        }
        
    }
    

    else
    {
        
        for (int i = index; i < arr.Length; i++)
        {
            Swap(ref arr[index], ref arr[i]);
            Permutate(arr, index+1, 0);
            Swap(ref arr[index], ref arr[i]);
        }
    }

}

Permutate(nado, 0 ,0);
Console.WriteLine("NO");
