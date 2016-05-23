using System;
using BrazzersSolver.Core.Extensions;
using BrazzersSolver.Core.Providers;

namespace BrazzersSolver.Core.Helpers
{
    public static class BrazzerParseHelper
    {
        public static string GetRnKey(string source)
        {
            var methodName = source.GetBetween("onload=\"", "()\"");

            source = source.GetBetween("<script type=\"text/javascript\"><!--", "//--></script></head>");
            source = source.Replace("document.cookie=\"RNKEY=\"", "return ");
            source = source.Replace("document.location.reload(true);", string.Empty);

            using (var engine = new ScriptEngine(ScriptEngine.JavaScriptLanguage))
            using (var parsed = engine.Parse(source))
            {
                object output;   
                Exception error;
                if (parsed.TryCallMethod(methodName, out output, out error))  
                    return (string) output;   

                return string.Empty;
            }
        }
    }
}    