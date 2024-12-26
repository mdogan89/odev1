// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
//Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

Console.WriteLine("Pozitif bir sayı giriniz: ");
int i = Convert.ToInt32(Console.ReadLine());
int res1 = 0;
int[] res2 = new int[i];
for (int j = 0; j < i; j++)
{
    res1 = Convert.ToInt32(Console.ReadLine());
    if (res1 % 2 == 0)
    {
        res2[j] = res1;
    }
}

foreach (int res in res2)
{
    if (res != 0)
    {
        Console.Write(res + " ");
    }
}

//Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
//Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

Console.WriteLine("Pozitif iki sayı giriniz: (m,n)");
string[] res3 = Console.ReadLine().Split(",");
int n = Convert.ToInt32(res3[0]);
int m = Convert.ToInt32(res3[1]);

for(int k = 0; k < n; k++)
{
    int num = Convert.ToInt32(Console.ReadLine());
    if (num == m || num%m == 0)
    {
        Console.Write(num + " ");
    }
}

//Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
//Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

Console.WriteLine("pozitif bir sayı giriniz: ");
n = Convert.ToInt32(Console.ReadLine());
string[] strList = new string[n];
for (int o = 0; o < n; o++)
{
    string str = Console.ReadLine();
    strList[o] = str;
}
    Array.Reverse(strList);

foreach(string t in strList)
{
    Console.WriteLine(t);
}


//Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

Console.WriteLine("Bir cümle giriniz: ");
string[] sentence = Console.ReadLine().Split(" ");

Console.WriteLine("Kelime sayısı: " + sentence.Length);


int charCount = 0;

foreach (string word in sentence)
{
    foreach (char c in word)
    {
        charCount++;
    }
}


Console.WriteLine("Harf sayısı: " + charCount);


//Console.ReadLine();
