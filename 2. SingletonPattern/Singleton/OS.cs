﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{ // однопоточность
  //public class OS
  //{
  //    private static OS instance;

    //    public string Name { get; private set; }

    //    protected OS(string name)
    //    {
    //        this.Name = name;
    //    }

    //    public static OS getInstance(string name)
    //    {
    //        if (instance == null)
    //            instance = new OS(name);
    //        return instance;
    //    }
//}
// однопоточность


// многопоточность
public class OS
{
    private static OS instance;

    public string Name { get; private set; }
    private static object syncRoot = new Object();

    protected OS(string name)
    {
        this.Name = name;
    }

    public static OS getInstance(string name)
    {
        if (instance == null)
        {
            lock (syncRoot)
            {
                if (instance == null)
                    instance = new OS(name);
            }
        }
        return instance;
    }
}
// многопоточность

}
