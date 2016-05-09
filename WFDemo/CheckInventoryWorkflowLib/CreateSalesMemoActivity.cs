using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace CheckInventoryWorkflowLib
{

    public sealed class CreateSalesMemoActivity : CodeActivity
    { 
        public InArgument<string> Make { get; set; }
        public InArgument<string> Color { get; set; }

         
        protected override void Execute(CodeActivityContext context)
        {
            StringBuilder salesMessage = new StringBuilder();
            salesMessage.AppendLine("**** Attention sales team! ****");

            salesMessage.AppendLine("Please order the following ASAP!");

            salesMessage.AppendFormat("1 {0} {1}\n",context.GetValue(Color), context.GetValue(Make));
            salesMessage.AppendLine();
            salesMessage.AppendLine("*****************************");

            System.IO.File.AppendAllText("SalesMemo.txt", salesMessage.ToString());


        }
    }
}
