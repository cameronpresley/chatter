using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace chatter.models
{
    public class ModuleLoader
    {
        public IEnumerable<Module> Load(string path)
        {
            return Directory
                .GetFiles(path, "*Module.dll")
                .Select(f => Assembly.LoadFile(f))
                .SelectMany(a => a.GetExportedTypes().Where(t=> t == typeof(Module)))
                .Select(t=>(Module)Activator.CreateInstance(t));
        }
    }

    public interface Module
    {
        string Command {get;}
        string Name {get; }
        ContactService ContactService {get;}
    }
}