using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Layer.Receivers;

     public class Receiver
    {
         public void DoSomthing(string a)
    {
         Console.WriteLine($"Receiver: Working on ({a}.)");
    }

    public void DoSomethingElse(string b)
    {
        Console.WriteLine($"Reciver: Also working on ({b}.)");
    }

    }

