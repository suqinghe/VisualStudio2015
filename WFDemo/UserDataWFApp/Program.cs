using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;
using System.Collections.Generic;
using System.Threading;

namespace UserDataWFApp
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the dato to pass the workflow...");

            var wfData = Console.ReadLine();

            Dictionary<string, object> wfArgs = new Dictionary<string, object>();
            wfArgs.Add("MessageToShow", wfData);

            AutoResetEvent waitHandle = new AutoResetEvent(false);

            WorkflowApplication app = new WorkflowApplication(new Workflow1(), wfArgs);

            app.Completed = (CompleteArgs) => {
                waitHandle.Set();
                Console.WriteLine("The workflow is done!");
            };

            app.Run();

            waitHandle.WaitOne();

            Console.WriteLine("Thanks for Displaying!");
        }
    }
}
