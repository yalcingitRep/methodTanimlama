using System;
namespace methodTanimlama{
    class Program{
        public static void Main(string[] args){
            int a = 3, b = 4;
            int sonuc = Topla(a,b);
            Console.WriteLine(sonuc);
            
             Metotlar mt = new Metotlar();
             mt.EkranaYazdir(Convert.ToString(sonuc));

             int sonuc2 = mt.ArttirVeTopla(ref a,ref b);

        }
        static int Topla(int a,int b){
            return a+b;
        }
    }
        
     class Metotlar{
        public void EkranaYazdir(string veri){
            Console.WriteLine(veri);
        }
        public int ArttirVeTopla(ref int a ,ref int b){
            a += 1;
            b += 1;
            return a + b;
        }
    }
}