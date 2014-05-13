using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;

namespace DymaticCompiler
{
    static class CodeCompiler
    {
        static public string Message=string.Empty;
        static public List<string> ErrorMessage = new List<string>();

        public static bool Compile(string[] references, string source, string outputfile)
        {
            // 编译参数  
            CompilerParameters compilerParams = new CompilerParameters(references, outputfile, true);
            //compilerParams.CompilerOptions = "/target:library /optimize";  
            compilerParams.TreatWarningsAsErrors = false;
            compilerParams.GenerateExecutable = false;
            compilerParams.IncludeDebugInformation = true;

            compilerParams.ReferencedAssemblies.Add("System.Core.dll");
            compilerParams.ReferencedAssemblies.Add("mscorlib.dll");
            compilerParams.ReferencedAssemblies.Add("System.dll");
            // 编译  
            CSharpCodeProvider provider = new CSharpCodeProvider();
            CompilerResults result = provider.CompileAssemblyFromSource(compilerParams, new string[] { source });

            Message = "";
            ErrorMessage.Clear();
            if (!result.Errors.HasErrors)
            { // 反射调用  
                Type t = result.CompiledAssembly.GetType("MyClass");
                if (t != null)
                {
                    object myobj = result.CompiledAssembly.CreateInstance("MyClass");
                    Message = (string)t.InvokeMember("GetResult", 
                        BindingFlags.Instance | BindingFlags.InvokeMethod | BindingFlags.Public, null, myobj, null);
                }
                return true;
            }

            foreach (CompilerError error in result.Errors)
            {  // 列出编译错误  
                if (error.IsWarning) continue;
                ErrorMessage.Add("Error(" + error.ErrorNumber + ") - " + error.ErrorText + "\t\tLine:" + error.Line.ToString() + "  Column:" + error.Column.ToString());
            }
            return false;
        }
    }

    public class MyClass
    {
        public string GetResult()
        {

            return null;
        }
    }
}
