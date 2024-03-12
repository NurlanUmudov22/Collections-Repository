



using Generics_Practise;
using System.Collections;

//IntList datas = new IntList();

//datas.Add(1);
//datas.Add(2);
//datas.Add(3);
//datas.Add(4);
//datas.Add(5);


//int[] result = datas.GetAll();


//foreach (var item in result)
//{

//    //Console.WriteLine(item);
//}









//StringList stringList = new StringList();

//stringList.Add("salam");
//stringList.Add("sagol");
//stringList.Add("silinme");
//   //  stringList.Delete("silinme");

//var result2 = stringList.GetAll();

//foreach (var item in result2)
//{
//        Console.WriteLine(item);
//}







//DataList<int> datas = new DataList<int>();


//datas.Add(1);
//datas.Add(2);
//datas.Add(3);


//var result = datas.GetAll();

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}



//DataList<string> dataList = new DataList<string>();

//dataList.Add("SALAM");
//dataList.Add("sagol");
//dataList.Add("HER VAXTIN XEYIR");


//var result9 = dataList.GetAll();

//foreach (var item in result9)
//{
//    Console.WriteLine(item);
//}





//DataList<bool> dataList1 = new DataList<bool>();


//dataList1.Add(true);
//dataList1.Add(false);
//dataList1.Add(false);
//dataList1.Add(true);

//var result3 = dataList1.GetAll();

//foreach (var item in result3)
//{
//    Console.WriteLine(item);
//}







//DataList<Book> books = new DataList<Book>();

//books.Add(new Book { Id = 1, Name = "TEST1" });
//books.Add(new Book { Id = 2, Name = "TEST2" });
//books.Add(new Book { Id = 3, Name = "Test3" });

//var result5 = books.GetAll();

//foreach (var item in result5)
//{
//    Console.WriteLine(item.Name);
//}






//DataList<int> datas = new DataList<int>();


//datas.Add(1);
//datas.Add(2);
//datas.Add(3);


//var result = datas.GetAll();

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}
//datas.Delete(24);


//var result6 = datas.GetAll();

//foreach (var item in result6)
//{
//    Console.WriteLine(item);
//}






//Repository<string> data1 = new Repository<string>();

//Repository<int> data2 = new Repository<int>();

//Repository<bool> data12 = new Repository<bool>();

//Repository<Book,BaseEntity> data11 = new Repository<Book, BaseEntity>();









//ArrayList list1 = new ArrayList();

//list1.Add(1);
//list1.Add(2);
//list1.Add(3);
//list1.Add(4);
//list1.Add(9);
//list1.Add(true);

//foreach (int item in list1)
//{
//    Console.WriteLine(item);
//}




//Hashtable hashtable = new Hashtable();

//hashtable.Add("role", "Admin");
//hashtable.Add("name", "Nesir");
//hashtable.Add(100, 200);

//foreach (DictionaryEntry item in hashtable)
//{
//    Console.WriteLine(item.Key + "-" + item.Value);
//}




//SortedList sortedList = new SortedList();

//sortedList.Add(100, 200);
//sortedList.Add(5, 200);
//sortedList.Add(55, 910);

//foreach (DictionaryEntry item in sortedList)
//{
//    Console.WriteLine(item.Key + "-" + item.Value);
//}




//SortedList<string,int> datas = new SortedList<string,int>();

//datas.Add("roleId", 100);
//datas.Add("age", 30);

// foreach ( KeyValuePair<string,int> item in datas)
//{
//    Console.WriteLine(item.Key + "-" + item.Value);
//} 






//Dictionary<string,string> datas = new Dictionary<string,string>();

//datas.Add("test1", "Salam1");
//datas.Add("test2", "salam2");
//datas.Add("test3", "salam3");

//foreach (KeyValuePair<string,string> item in datas)
//{
//    Console.WriteLine(item.Key + "-" + item.Value);
//}

//Console.WriteLine(datas["test1"]);


//foreach (KeyValuePair<string, string> item in datas)
//{
//    if (item.Value == "salam3")
//    {
//        Console.WriteLine(item.Key);
//    }

//}







//Stack<int> nums = new();

//nums.Push(1);
//nums.Push(255);
    
//nums.Push(344);
//nums.Push(434);


//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}





//Queue<int> nums = new();

//nums.Enqueue(1);
//nums.Enqueue(255);

//nums.Enqueue(344);
//nums.Enqueue(434);


//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}


//IEnumerable<int> nums = new List<int>();






List<int> numbers = new List<int>();

numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);


//Console.WriteLine(numbers[0]);

//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}


//for (int i = 0; i < numbers.Count; i++)
//{
//    Console.WriteLine(numbers[i]);
//}


//Console.WriteLine(numbers.FirstOrDefault(m => m==3));




//numbers.Remove(1);
//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}




//numbers.RemoveRange(0,2);

//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}



//List<int> numbers2 = new List<int> { 1,2,3,4,5};





//numbers.AddRange(numbers2);

//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}