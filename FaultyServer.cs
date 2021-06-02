
class Solution
{
    static void Main(string[] args)
    {

        int penalty=compute_penalty("0 0 0 1 1 1 1", 3);
                                  // 1 1 1 0 0 0 0  
        Console.WriteLine(penalty);

        // Console.WriteLine("Actual:\n  " + compute_penalty("0 0 0 1 1 1 1", 0) + "\nExpected:\n  3\n");
        // Console.WriteLine("Actual:\n  " + compute_penalty("0 0 0 1 1 1 1", 7) + "\nExpected:\n  4\n");
        // Console.WriteLine("Actual:\n  " + compute_penalty("0 0 0 1 1 1 1", 3) + "\nExpected:\n  0\n");
        // Console.WriteLine("Actual:\n  " + compute_penalty("", 0) + "\nExpected:\n  0\n");

    }
    
    static int compute_penalty(string logs, int remove_at){
        int hour=0;
        int penalty=0;
        foreach(char ch in logs){
           if(ch.Equals('1') && remove_at>hour){
               penalty=penalty+1;
           }
            if(ch.Equals('0') && remove_at<hour){
               penalty=penalty+1;
           }
            hour++;
        }        
        return penalty;
    }
}


// code to analyze a simple server process uptime log. These logs are
// much simplified, and are just strings of space separated 0's and 1's. The log is a string of binary
// digits (e.g. "0 0 1 0"). Each digit corresponds to 1 hour of the server running:
 
// "1" = <crashed>, "down" // server process crashed during the hour
// "0" = <didn't crash>, "up" // server process did not crash during the hour
 
//  EXAMPLE: A server with log "0 0 1 0" ran for 4 hours and its process crashed during hour #3
 
//    hour: |1|2|3|4|
//    log : |0|0|1|0|
//               ^
//               |
//              down during hour #3
 
// We can *permanently remove* a server at the beginning of any hour during its operation. A server
// is on the network until it is removed. Note that a server stays POWERED ON after removal, it's
// just not on the network.
 
// We'd like to understand the best times to remove a server. So let's introduce an aggregate metric called a "penalty" for removing a server at a bad time.
 
 
//  EXAMPLE: Remove a server with log "0 0 1 0"
 
//     hour :  | 1 | 2 | 3 | 4 |
//     log  :  | 0 | 0 | 1 | 0 |
// remove_at:  0   1   2   3   4   // remove_at being `x` means "server removed before hour `x+1`"
//             ^               ^
//             |               |
//      before hour #1         after hour #4
 
 
// We define our penalty like this:
// +1 penalty for each DOWN hour when a server is on the network
// +1 penalty for each UP hour after a server has been removed
 
// Further Examples:
 
// EXAMPLE:
 
//    hour :   1 2 3 4     // total penalty = 3  (3 server-up hours after remove)
//    log  :   0 0 1 0
//            ^
//            |
//          remove_at = 0
 
//    hour :   1 2 3 4     // total penalty = 1  (1 server-down hour before remove)
//    log  :   0 0 1 0
//                    ^
//                    |
//                  remove_at = 4
 
// Note that for a server log of length `n` hours, the remove_at variable can range
// from 0, meaning "before the first hour" to n, meaning "after the final hour".
 
// 1a)
// Write a function: compute_penalty, that computes the total penalty, given
 
// a server log (as a string) AND
// a time at which we removed the server from the network (call that  variable remove_at)
 
// In addition to writing this function, you should use tests to demonstrate that it's correct.
 
// ## Examples
 
// compute_penalty("0 0 1 0", 0) should return 3
// compute_penalty("0 0 1 0", 4) should return 1