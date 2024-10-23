using System;

public class Program{
    public static void Main(string[] args){
        Write1ThroughN_While(-1);
        Write1ThroughN_While(5);
        Write1ThroughN_While(0);
        Write1ThroughN_For(-1);
        Write1ThroughN_For(5);
        Write1ThroughN_For(0);
        WriteNThrough1_While(-1);
        WriteNThrough1_While(5);
        WriteNThrough1_While(0);
        WriteNThrough1_For(-1);
        WriteNThrough1_For(5);
        WriteNThrough1_For(0);
        WriteEvensThrough100();
        FindSum(5);
        FindSum(1);
        FindSum(-3);
        FindSum(100);
        FindSumOfEvenNumbers(10);
        FindSumOfEvenNumbers(-5);
        FindSumOfEvenNumbers(2);
        FindSumOfEvenNumbers(0);
        FindSumOfEvenNumbers(1);
        FindSumOfEvenNumbers(25);
        FindSumOfEvenNumbers(-25);
        FindSumOfOddNumbers(10);
        FindSumOfOddNumbers(-5);
        FindSumOfOddNumbers(1);
        FindSumOfOddNumbers(2);
        FindSumOfOddNumbers(25);
        FindSumOfOddNumbers(-25);
        OutputRightTriangle(4);
        OutputRightTriangle(6);
        OutputRightTriangle(-4);
        OutputRightTriangle(-6);
        OutputRightTriangle(0);
    }
    public static void Write1ThroughN_While(int n){
        Console.WriteLine();
        int num = 1;
        if (n<1){
            OutOfRangeMessage(n);
            return;
        }
        while (num<=n){
            Console.Write(num + " ");
            num++;
        }
    }
    public static void Write1ThroughN_For(int n){
        Console.WriteLine();
        if (n<1){
            OutOfRangeMessage(n);
            return;
        }
        for(int i = 1; i<=n; i++){
            Console.Write(i + " ");
        }
    }
    public static void WriteNThrough1_While(int n){
        Console.WriteLine();
        if (n<1){
            OutOfRangeMessage(n);
            return;
        }
        while (n>0){
            Console.Write(n + " ");
            n--;
        }
    }
    public static void WriteNThrough1_For(int n){
        Console.WriteLine();
        if (n<1){
            OutOfRangeMessage(n);
            return;
        }
        for(int i = 1; i<=n; n--){
            Console.Write(n + " ");
        }
    }
    public static void WriteEvensThrough100(){
        Console.WriteLine();
        for(int i=1; i<=100; i++){
            if (i %2 ==0){
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
    public static void FindSum(int n){
        int sum = 0;
        if (n > 1){
            for(int i=0; i<=n; i++){
                sum += i;
            }
            Console.WriteLine(sum);
        } else if (n==0){
            Console.WriteLine(0);
        } else{
            for(int i=0; i>n; i--){
                sum += i;
            }
            Console.WriteLine(sum);
        }
        
    }
    public static void FindSumOfEvenNumbers(int n){
        int sum = 0;
        if (n > 1){
            for(int i=0; i<=n; i++){
                if (i%2==0){
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        } else if(n==0){
            Console.WriteLine(0);
        } else{
            for(int i=0; i>n; i--){
                if (i%2==0){
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
    public static void FindSumOfOddNumbers(int n){
        int sum = 0;
        if (n > 1){
            for(int i=0; i<=n; i++){
                if (i%2!=0){
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        } else if (n==0){
            Console.WriteLine(0);
        } else{
            for(int i=0; i>n; i--){
                if (i%2!=0){
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
    public static void OutputRightTriangle(int _base){
        Console.WriteLine();
        if (_base>0){
            for (int i=1;i<=_base; i++){
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", i)));
            }
        } else if (_base!=0){
            for (int i=Math.Abs(_base);i>=0; i--){
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", i)));
            }
        } else{
            OutOfRangeMessage(_base);
        }
        
    }
    public static void OutOfRangeMessage(int n){
        Console.WriteLine(n + " is out of range!");
    }
}