using System.Globalization;

namespace Area_Perimeter_Calculation;

public class Calculator
{
    
 static void calcCircle(int a, int op) {
     double result = op == 1 ? (2 * 3.14 * a) : (3.14 * a * a);
     Console.WriteLine(result);
  }
  
 static void calcTriangle(int a, int b, int op) {
     double result = op == 1 ? (a + b + Math.Sqrt(a * a + b * b))  : ((a * b) /2);
     Console.WriteLine(result);
 }
 
 static void calcSquare(int a, int op) {
     double result = op == 1 ? 4 * a : a * a;
     Console.WriteLine(result);
 }
 
 static void calcRect(int a, int b, int op) {
     double result = op == 1 ? 2 * (a+b) : a * b;
     Console.WriteLine(result);
 }
  
  public void Calculate() {
    int a, b=0;
    int shapeSelected, operationSelected;
    
    string shapes= "1 => Daire    2 => Dik Üçgen\n" 
                 + "3 => Kare     4 => Dikdörtgen\n" 
                 + "0 => Çıkış Yap\n" 
                   + "Seçim yapınız: ";
    
    string operations= "1 => Çevre Hesaplama\n" 
                       + "2 => Alan Hesaplama\n"
                       + "Seçim yapınız: ";

    while (true) 
    {
        Console.Write(shapes);
        shapeSelected = Convert.ToInt16(Console.ReadLine());
        
        
        if (shapeSelected is < 0 or > 4 ) {
            Console.WriteLine("--------------------------------\n" +
                              "          HATALI SEÇİM\n" +
                              "--------------------------------");
            Calculate();
        }
        else if (shapeSelected is 0)
        {
            Console.WriteLine("Çıkış Yapıldı");
            break;
        }
        else switch (shapeSelected)
        {
            case 1:
                Console.Write("Yarıçapı giriniz: ");
                break;
            case 2 or 3 or 4:
                Console.Write("Bir kenar uzunluğunu giriniz: ");
                break;
        }
        a = Convert.ToInt16(Console.ReadLine());
        
        if (shapeSelected is 2 or 4)
        {
            Console.Write("Diğer kenar uzunluğunu giriniz: ");
            b = Convert.ToInt16(Console.ReadLine());
        } 
        
        Console.Write(operations);
        operationSelected  = Convert.ToInt16(Console.ReadLine());
        
        if (operationSelected != 1 && operationSelected != 2) {
            Console.WriteLine("HATALI SEÇİM");
            break;
        }
        
        
        switch (shapeSelected){
            case 1:
                calcCircle(a, operationSelected);
                break;
            case 2:
                calcTriangle(a, b, operationSelected);
                break;
            case 3:
                calcSquare(a, operationSelected);
                break;
            case 4:
                calcRect(a, b, operationSelected);
                break;
        }
        
        Console.WriteLine("************İşlem başarıyla gerçekleştirildi************\n\n");
        
    }
    
  }

}