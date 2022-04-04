using System;
using System.Text;
			
public class Program
{
	public static void Main()
	{
		Console.WriteLine(LongestPalindrome("babad"));
	}
	
    public string LongestPalindrome(string s) {
        string pelindromeStr="";
        for(int i=0; i<s.Length-1; i++){
            string CurPelindromeStr=CalculatePelindrome(s[i], s);
            if(pelindromeStr.Length<CurPelindromeStr.Length){
                pelindromeStr=CurPelindromeStr;
            }
        }
					return pelindromeStr;
	}
    
        private string CalculatePelindrome(int mid, string s){
        StringBuilder pelindrom=new StringBuilder("");
            for(int i=0; i<mid-1; i++){
           if(s[mid-i]==s[mid+i])  {
               pelindrom.Append(s[mid-i]);
           } 
        }  
                        return pelindrom.Tostring();
        }
}