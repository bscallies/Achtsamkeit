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


/* /* 
 * Achtsamkeit is a small program that helps you be more mindful of how we use our time. 
 * It is written in C# and uses Windows Forms. 
 * The program is based on the idea of meditation and mindfulness. 
 * The user can choose a category / intention for their computer session 
 * The program then tracks the time the user spends on the computer.
 * The program is structured as follows:
 * 
 * NameSpace Achtsamkeit.GUI:
 * GUI.cs
 * GUI.Designer.cs
 * GUI.resx
 * 
 * NameSpace Achtsamkeit.Backend:
 * Category.cs
 * CategoryManger.cs
 * ISessionHandler.cs
 * Session.cs
 * SessionFileHandler.cs
 * SessionManager.cs
 * User.cs
 * 
 * NameSpace Achtsamkeit
 * Form1.cs
 * Form1.Designer.cs
 * Form1.resx
 * FormFunctions.cs
 * Program.cs
 * 
 *  
 *  Application data is saved in bin/debug
 *  
 *  The program is structured as follows:
 
NameSpace Achtsamkeit.GUI:
GUI.cs
GUI.Designer.cs
GUI.resx
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
* Program.cs 

 
 Session data is saved in bin/debug
 */