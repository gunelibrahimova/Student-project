
using Student_project.Methods;
using Student_project.Models;
Evvele:
Console.WriteLine("1.Telebe haqqinda melumat");
Console.WriteLine("2.Imtahan verdiyi fenn");
Console.WriteLine("3.Imtahandan kecib yoxsa kesilib");



string daxilEdilenReqem = Console.ReadLine();

Student student = new();

Go start = new Go();

decimal bal = 100M;

switch (Convert.ToInt32(daxilEdilenReqem))
{
    case 1:
        Console.WriteLine("Adinizi ve soyadinizi daxil edin");
        student.Name = Console.ReadLine();
        goto Evvele;
        break;
    case 2:
        Console.WriteLine("Imtahan verdiyiniz fennin adini daxil edin");
        student.Fenn = Console.ReadLine();
        goto Evvele;
        break;
    case 3:
        start.ImtahanBali(bal);
        break;

}


