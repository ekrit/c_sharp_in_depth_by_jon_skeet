// See https://aka.ms/new-console-template for more information

using c_sharp_in_depth.Lessons;

Console.WriteLine("Hello, World!");


var actions = Lambda.CreateCountingActions(); 

actions[0]();
actions[0]();
actions[1]();
actions[1]();


