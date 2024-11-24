using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System;

public class D3crypt10nUt1lity
{
    private static readonly byte[] K3y = Encoding.UTF8.GetBytes("1234567890123456");
    private static readonly byte[] V1iskalator = Encoding.UTF8.GetBytes("1234567890123456");

    public static string D3cryptB45364(string Vishkanilmakeirocbitardzan)
    {
        string junk1 = "This is junk data to confuse decompilers";
        string junk2 = "Another layer of useless complexity!";
        Thread.Sleep(50); 

      
        byte[] _3ncrypt3dB7 = Convert.FromBase64String(Vishkanilmakeirocbitardzan);

        using (Aes __ObfuC4tedAES = Aes.Create())
        {
            __ObfuC4tedAES.Key = K3y;
            __ObfuC4tedAES.IV = V1iskalator;

            
            Thread.Sleep(100);
            string junk3 = "Are you sure you want to debug this?";

            __ObfuC4tedAES.Mode = CipherMode.CBC;
            __ObfuC4tedAES.Padding = PaddingMode.PKCS7;

            using (ICryptoTransform __JunkDecrypt0r = __ObfuC4tedAES.CreateDecryptor())
            {
             
                string junk4 = "Debuggers won't like this!";
                for (int i = 0; i < junk4.Length; i++) Thread.Sleep(1);

              
                byte[] D3crypt3dB7 = __JunkDecrypt0r.TransformFinalBlock(_3ncrypt3dB7, 0, _3ncrypt3dB7.Length);

     
                string junk5 = $"Decryption Length: {D3crypt3dB7.Length}";
                Thread.Sleep(30);


                return Convert.ToBase64String(D3crypt3dB7);
            }
        }
    }
}
