//Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Achtsamkeit
{
    static class Program
    {
       
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUI());
        }
    }
}


/* 
 * NameSpace Achtsamkeit.Backend:
Category.cs
CategoryManger.cs
ISessionHandler.cs
Session.cs
SessionFileHandler.cs
SessionManager.cs
User.cs

* NameSpace Achtsamkeit
* Form1.cs
* Form1.Designer.cs
* Form1.resx
* FormFunctions.cs
* Program.cs */