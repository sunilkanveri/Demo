using System;


namespace Programs
{
    class FaultyServer
    {
                                  // 1 1 1 0 0 0 0  
        // Console.WriteLine("Actual:\n  " + compute_penalty("0 0 0 1 1 1 1", 0) + "\nExpected:\n  3\n");
        // Console.WriteLine("Actual:\n  " + compute_penalty("0 0 0 1 1 1 1", 7) + "\nExpected:\n  4\n");
        // Console.WriteLine("Actual:\n  " + compute_penalty("0 0 0 1 1 1 1", 3) + "\nExpected:\n  0\n");
        // Console.WriteLine("Actual:\n  " + compute_penalty("", 0) + "\nExpected:\n  0\n");  
    public int compute_penalty(string logs, int remove_at){
        int hour=0;
        int penalty=0;
        foreach(char ch in logs){
            Console.WriteLine(ch.ToString()+"-"+hour+"-"+penalty);
           if(ch.Equals('1') && remove_at>=hour){
               Console.WriteLine("1");
               penalty=penalty+1;
           }
            if(ch.Equals('0') && remove_at<=hour){
               Console.WriteLine("0");
               penalty=penalty+1;
           }
           hour=ch.Equals(' ')?hour:hour+1;
        }        
        return penalty;
    }
}
}


