// See https://aka.ms/new-console-template for more information
using DelegateAppl;

//create delegate instances
NumberChanger nc1 = new NumberChanger(TestDelegate.AddNum);
NumberChanger nc2 = new NumberChanger(TestDelegate.MultiNum);

//calling the methods using the delegate objects
nc1(25);
Console.WriteLine("Value of Num: {0}", TestDelegate.getNum());
nc2(5);
Console.WriteLine("Value of Num: {0}", TestDelegate.getNum());

//create delegate instances
NumberChanger nc;
NumberChanger nc3 = new NumberChanger(TestDelegate.AddNum);
NumberChanger nc4 = new NumberChanger(TestDelegate.MultiNum);

nc = nc3;
nc += nc4;

//calling multicast
nc(5);
Console.WriteLine("Value of Num: {0}", TestDelegate.getNum());
Console.ReadKey();
