int[] s = new int[]{5,2,2,6,5,7,1,9,0,3,8,6,8,6,5,2,1,8,7,9,8,3,8,4,7,2,5,8,9};
double num = 0;
foreach(int i in s){
    num=num*10+i;
}
// num++;
Console.WriteLine(num);
Console.WriteLine(s.Length);
Console.WriteLine(num.ToString("F")); 
Console.WriteLine(num.ToString("F").Length);
// int fin = int.Parse(temp);
// Console.WriteLine(fin);
int[] PlusOne(int[] digits) {
        double num = 0;
        foreach(int i in digits){
            num= num*10+i;
        }
        num +=1;
        string N = num.ToString();
        int[] LRe = new int[digits.Length+1];
        if(digits[digits.Length-1]==9){
            LRe = Print(num, LRe);
            if (LRe[0]==0){
                return Print(num,new int[digits.Length]);
            }else{
                return LRe;
            }
        }
        else{
            digits[digits.Length-1]++;
            return digits;
        }
    }
int[] Print(double num, int[] LRe){
    int l = LRe.Length;
    while(num>0&&l>0){
        LRe[l-1]=(int)num%10;
        l--;
        num/=10;
    }
    LRe[LRe.Length-1]=0;
    return LRe;
}
// Console.WriteLine(PlusOne(s).Length);
// Console.WriteLine(s.Length);
// foreach(int i in PlusOne(s)){
//     Console.WriteLine(i);
// }