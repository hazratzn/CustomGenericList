using System;
using ListProject.Models;

namespace ListProject
{
    class Program
    {
        static void Main(string[] args)
        {




            MyList<object> list = new MyList<object>();
            list.Add("Messi");
            list.Add("Lionel");
            list.Add(30);
            list.Add(10);

            list.AddRange(19);

            //list.Clear(list);


            //list.FindList("Messi");



        }
    }
}
