using G12_20220915;

MyLinkedList<string> myLinkedList = new();

myLinkedList.AddLast("Kakha");
myLinkedList.AddLast("Kakha1");
myLinkedList.AddLast("Kakha2");
myLinkedList.AddLast("Kakha3");
myLinkedList.AddLast("Kakha4");
myLinkedList.AddLast("Kakha5");

foreach (var item in myLinkedList)
{
    Console.WriteLine(item);
}
//Console.WriteLine();
//myLinkedList.Print();
//Console.WriteLine(myLinkedList.count);
Console.WriteLine();

myLinkedList.AddFirst("Giorgi");


myLinkedList.Print();
Console.WriteLine(myLinkedList.count);
Console.WriteLine();

//myLinkedList.AddLast("Nika");

//myLinkedList.Print();
//Console.WriteLine(myLinkedList.count);
//Console.WriteLine();

//MyNode<string>? findeNodeAfter = myLinkedList.FindNode("Kakha2");

//if (findeNodeAfter != null)
//myLinkedList.AddAfter(findeNodeAfter, "Diko");

//myLinkedList.Print();
//Console.WriteLine(myLinkedList.count);
//Console.WriteLine();

//MyNode<string>? findeNodeBefore = myLinkedList.FindNode("Kakha2");

//if(findeNodeBefore != null)
//myLinkedList.AddBefore(findeNodeBefore, "new");

//myLinkedList.Print();
//Console.WriteLine(myLinkedList.count);