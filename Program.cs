using System;
using System.Runtime.CompilerServices;







// decimal firstAge ;
// decimal secondAge ; 
// Console.WriteLine("Son yozing ");
// Console.Write("Masalan ");
// string inputFirstAge = 
// Console.Write("Masalan2 ");
//  string inputSecondAge = (Console.ReadLine());
//  int usersAge = Convert.ToDecimal(usersAge);
// // Console.WriteLine("Natija= " );


// // int askarYoshi;
// // Console.WriteLine("Yoshingizni kiriting" );
// // Console.Write("Age: ");
// // askarYoshi = Convert.ToInt32(Console.ReadLine());
// // if (askarYoshi < 18)
// // {
// //     Console.WriteLine("Siz bora olmaysiz");

// // }
// // else
// // {
// //     if (askarYoshi >= 18)    
// //     Console.WriteLine("Siz bora olasiz");
// // }

/// Radius uchun
// int radius;
// decimal pi = 3.14m;
// Console.WriteLine("Qiymatni kiriting");
// string inputNumber = Console.ReadLine();
// radius = Convert.ToInt32(inputNumber);
// decimal overal = pi*(radius^2);
// Console.WriteLine(overal);


// int firstNumber ; 
// int secondNumber ;
// Console.WriteLine("Son kiriting!");
// Console.Write("son1= ");
// Console.ReadLine();
// Console.Write("son2= ");
// Console.ReadLine();
// firstNumber = Convert.ToInt32("son1= ");
// secondNumber = Convert.ToInt32("son2= ");
// int inputNumber = firstNumber*(secondNumber+8);
// inputNumber = Convert.ToInt32(inputNumber);
// Console.WriteLine(inputNumber);

// string ism;
// string familiya;
// int ball;

// Console.WriteLine("Assalmu Aleykum!");
// Console.Write("Ism ");
// ism = Console.ReadLine();
// Console.Write("Familiya: ");
// familiya = Console.ReadLine();
// Console.Write("Ball: ");
// string inputBall = Console.ReadLine();
// ball = Convert.ToInt32(inputBall);
// bool overal1 = ball < 56;
// bool overal2 = ball == 56;
// bool overal3 = ball > 56 && ball < 180;

// if(overal1) 
// {
//     Console.WriteLine("Kechirasiz siz talabalikka qabul qilinmadingiz");
// }
// else if (overal2)
// {
//     Console.WriteLine("Siz superkontrakt to`lab o`qishingiz mumkin!");
// }
// else if (overal3)
// {
//     Console.WriteLine("Tabriklaymiz siz talaba bo`ldingiz!");
// }



//50 dan kam bolsa -maxsulot kam qoldi
//50 ga teng bolsa yetarli
//50 dan kop bolsa  
string nokia;
string samsung;
string iphone;
int son;
Console.WriteLine("Bizga kerak bo`lgan mahslot");
Console.Write("Nokia ");
Console.ReadLine();
Console.Write("Samsung ");
Console.ReadLine();
Console.Write("Iphone ");
Console.ReadLine();
string inputSon = Console.ReadLine();
son = Convert.ToInt32(inputSon);
int summ = nokia + samsung + iphone;
summ = Convert.ToInt32(nokia + samsung + iphone);
bool overal1 = summ < 50;
bool overal2 = summ == 50;
bool overal3 = summ > 50;

if (overal1)
{
    Console.WriteLine("Zakaz berishimiz kerak!");
}
else if (overal2)
{
    Console.WriteLine("O`ylab ko`rish kerak");
}
else 
{
    Console.WriteLine("Bu tovarga ehtiyojimiz yo`q!");
}