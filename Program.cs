string 姓名 ="";
string 性別 ="";
string 生日 ="";
string 學號 ="";

for(string b="2";b!="1";)
{
    if(b=="2")
    {
    Console.WriteLine("請輸入基本資料");
    Console.WriteLine("請問你叫什麼名字?");
    姓名=Console.ReadLine();
    Console.WriteLine("請問你是 1男生 2女生");
    性別=Console.ReadLine();
    Console.WriteLine("請輸入你的出生年月日");
    生日=Console.ReadLine();
    Console.WriteLine("請輸入你的學號");
    學號=Console.ReadLine();
    };
    Console.WriteLine("====================");
    Console.WriteLine("基本資料確認");
    Console.WriteLine(姓名);
    Console.WriteLine(性別);
    Console.WriteLine(生日);
    Console.WriteLine(學號);
    Console.WriteLine("資料正確 請輸入1");
    Console.WriteLine("重新輸入一次 請輸入2");
    Console.WriteLine("若只想更改單一項目 請輸入數字 3(姓名)4(性別)5(生日)6(學號)");
    b=Console.ReadLine();
    if(b=="1")
    {
        Console.WriteLine("已完成資料建置");
    }
    else if(b=="3")
    {
        Console.WriteLine("請問你叫什麼名字?");
        姓名=Console.ReadLine();
        
    }
    else if(b=="4")
    {
        Console.WriteLine("請問你是 1男生 2女生");
        性別=Console.ReadLine();
    }
    else if(b=="5")
    {
        Console.WriteLine("請輸入你的出生年月日");
        生日=Console.ReadLine();
    }
    else if(b=="6")
    {
        Console.WriteLine("請輸入你的學號");
        學號=Console.ReadLine();
    }
        else
    {
        Console.WriteLine("請重新開始詢問基本資料填寫");

    }
}
