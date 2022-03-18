using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.UI;
namespace CreateTemplateRevit
{
    internal class App:IExternalApplication
    {
        public Result OnStartup(UIControlledApplication a)
        {
            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication a)
        {
            return Result.Succeeded;
        }
    }
}
