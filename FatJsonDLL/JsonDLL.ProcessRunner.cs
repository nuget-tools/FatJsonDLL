using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static JsonDLL.JsonAPI;
namespace JsonDLL;
public class ProcessRunner
{
    static ProcessRunner()
    {
    }
    public static void Initialize()
    {
        ;
    }
    public static void HandleEvents()
    {
        DLL1.API.Call("process_events", null);
    }
    public static int RunProcess(bool windowed, string exePath, string[] args, string cwd = "", Dictionary<string, string> env = null)
    {
        var result = DLL1.API.Call("run_process", new object[] { windowed, exePath, args, cwd, env });
        return (int)result[0];
    }
    public static bool LaunchProcess(bool windowed, string exePath, string[] args, string cwd = "", Dictionary<string, string> env = null, string fileToDelete = "")
    {
        var result = DLL1.API.Call("launch_process", new object[] { windowed, exePath, args, cwd, env, fileToDelete });
        return (bool)result[0];
    }
}
