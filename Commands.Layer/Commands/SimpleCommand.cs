using Commands.Layer.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands.Layer.Commands;

public class SimpleCommand : ICommand
{
    private string _payload = string.Empty;

    public SimpleCommand(string payload)
    {
       this._payload = string.Empty;
    }
    public void Execute()
    {
        Console.WriteLine($"SimpleCommand: See,I can do simple things like printing({this._payload})");
    }
}

