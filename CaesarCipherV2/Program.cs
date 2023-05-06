using System.Text;

namespace CaesarCipher;

public class Program
{

    public static void Main(string[] args)
    {
        string s = "There's-a-starman-waiting-in-the-sky";
        // string s = "!m-rB`-oN!.W`cLAcVbN/CqSoolII!SImji.!w/`Xu`uZa1TWPRq`uRBtok`xPT`lL-zPTc.BSRIhu..-!.!tcl!-U";
        // string s = "Wxyz";
        int k = 3;
        caesarCipher(s, k);
    }

    public static string caesarCipher(string s, int k)
    {
        
        List<char> plainText = s.ToList();
        List<char> cipher = new List<char>(plainText.Count + 1);

        for (int i = 0; i < plainText.Count; i++) {
            
            if (plainText[i] > 64 && plainText[i] < 91 || plainText[i] > 96 && plainText[i] < 123)
            {
                char temp = (char)(((int)plainText[i]) + (k % 26));
            
                if (plainText[i] < 91 && temp > 90 || plainText[i] > 96 && temp > 122)
                {
                    cipher.Add((char)((int)temp - 26));
                }
                else cipher.Add(temp);
                
            }
            else
            {
                cipher.Add(plainText[i]);
            }
            
            
        }

        string cipherString = "";
        foreach (char c in cipher)
        {
            cipherString += c;
        }
        foreach (char c in cipher) Console.Write($"{c}");

        return cipherString;
        
    }
}