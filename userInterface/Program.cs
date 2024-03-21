
using Business.Layer.Receivers;
using Commands.Layer.Commands;
using userInterface.Invokers;

Invoker invoker = new Invoker();
//simple command with no delegation to  a reciver
invoker.SetOnStart(new SimpleCommand("Say Hi"));

//complex command with delegation to  a reciver
Receiver receiver = new Receiver();

invoker.SetOnFinish(new ComplexCommand(receiver, "Send email","Save report"));

invoker.DoSomthingImportant();
