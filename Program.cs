//1
int integ = Convert.ToInt32(Console.ReadLine());
int pow = Convert.ToInt32(Console.ReadLine());
int pows(int integ,int pow){
    int result = integ;
    for (int i = 1; i < pow; i++){
        result *= integ;}
        return result;
}
if (pow < 0){
    pow*=-1;
    Console.WriteLine($"{1/Convert.ToDouble(pows(integ,pow))}");
}
else if (pow == 0) Console.WriteLine("0");
else{
    Console.WriteLine($"{pows(integ,pow)}");}
//2
int user = Convert.ToInt32(Console.ReadLine());
if (user<0) user*=-1;
int userCop = user;
int sum = 0;
while(userCop>=1){
    int num = userCop % 10;
    userCop/=10;
    sum+=num;}
Console.WriteLine($"{sum}");
//3
int[] Generator(int from, int before, int length){
    int[] massive = new int [length];
    Random random = new Random();
    for (int i = 0; i < length; i++){
        massive[i] = random.Next(from, before+1);
    }
    return massive;
}
Console.Write("from>>");
int from = Convert.ToInt32(Console.ReadLine());
Console.Write("before>>");
int before = Convert.ToInt32(Console.ReadLine());
Console.Write("length>>");
int length = Convert.ToInt32(Console.ReadLine());
int[] massive = Generator(from, before, length);
Console.Write("[");
int i = 1;
foreach(int c in massive){
    Console.Write($"{c}");
    if (i < length) Console.Write(" ,");
    i++;
}
Console.Write("]");
Console.WriteLine();