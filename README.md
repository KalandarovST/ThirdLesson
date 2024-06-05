# ThirdLesson

>## Dasturchi bilishi kerak bo`lgan 3 ta unsur;

* SEQUENCE - Takrorlanmaydigan code parchasini ishga tushirish.
('A' + 'B' or 'B' + 'A') ko`rinishidagi.

* SELECTION - unday bo`lsa bu mantiqdan ket, bunday bo'lsa bu mantiqdan ket degan shart qo'ysa bu SELECTION tipiga kiradi.

* ITERATION - Ma`lumot code parchasini qayta va qayta ishga tushira olish.

__*Bu 3 ta unsurni bilgan dasturchi har qanday dasturni ishga tushira oladi.*__

SEQUENCE o'rganayotganimizda o'zgaruvchi yarata olishimiz kerak, ya`ni o'zgaruvchi yaratishni sintaksisi quyidagicha:

> *type variableName = value;*

* BUTUN SONLAR typelari:

__Short__ -> 2 byte -> 16 bit -> [- (2^16/2) ; (2^16/2) ];

__int__ ->  4 byte -> 32 bit -> [- (2^32/2); (2^32/2)];

__long__ -> 8 byte -> 64 bit -> [- (2^64/2); (2^64/2)];

* MUSBAT SONLAR typelari uchun:

__ushort__ -> 2 byte -> 16 bit -> [ 0; (2^16/2) ]

__uint__ ->  4 byte -> 32 bit -> [ 0; (2^32/2)]

__ulong__ -> 8 byte -> 64 bit -> [ 0; (2^64/2)]

## O'zgaruvchini nomlash turlari:
----------------------------------
* PascalCase - har bir so`zning bosh harfi katta bilan
* camelCase - birinchi so`z kichik va qolgan barchasi katta harf bilan(o'zgaruvchilarni shu case da saqlaymiz)
* kebab-case - hammasi kichik va o`rtada chiziq bor
* snake_case - hammasi kichik va o'rtada pastdan chiziq bor (ishlatilmaydi)
----------------------------------

> BOOLEAN - HA/YO`Q, MUSBAT/MANFIY

* bool -> 1 bit -> true/false

bool isStudentHappy = true;

  **_Tavfsiya  - is, are lar bilan boshlash_**

---------------------------------------
>* MATN - "Hello, World!"

> string -> 24 byte ->

string inputAge = Console.Readline();

------------------------------------
* Belgilar bilan
> char -> "?"  (character)

>char -> 2 byte
---------------------------

> * Kasr sonlar bilan
(Kasr sonlar bilan ishlashda qanchalik aniqlikda ishlay olishida farq qiladi.)

>float -> 4 byte -> 32 bit -> ~6 (kam hollarda ishlatiladi)

>double -> 8 byte -> 64 bit -> ~15 

>decimal -> 16 byte -> 128 bit -> ~28 son aniqlikda hisobga oladi. (ko'proq ishlatiladi)
--------------------------
> * __KONVERTATSIYA__

string userAge = Console.Readline();
int age = Convert.ToInt32(userAge);

--------------------------------

bool isOlder18 = true;
bool isYounger27 = true;

Console.WriteLine(!(isOlder18)); (__!__ - Emas degani)

Console.WriteLine(isOlder18 || isYounger27); (__||__ Yoki degani)

Console.WriteLine(isOlder18 && isYounger27); (__&&__ VA degani)
