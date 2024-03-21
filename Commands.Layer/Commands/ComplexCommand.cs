using Business.Layer.Receivers;
using Commands.Layer.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands.Layer.Commands
{
    public class ComplexCommand : ICommand
    {
        private Receiver _receiver;
        private string _a;
        private string _b;

        public ComplexCommand(Receiver receiver,string a , string b)
        {
            this._receiver = receiver;
            this._a = a;
            this._b = b;
            
        }
        //delegate request to the reciver 
        public void Execute()
        {
            Console.WriteLine("ComplexCommand: Complex stuff should be done by a reciver object");
            this._receiver.DoSomthing(this._a);
            this._receiver.DoSomethingElse(this._b);
        }
    }
}
