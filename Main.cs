using System;
using System.Collections;
using System.Collections.Generic;


namespace Programs
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            // DataStructure objDataStructure=new DataStructure();
            // objDataStructure.CheckDataStructure();

            FaultyServer objFaultyServer=new FaultyServer();
            Console.WriteLine(objFaultyServer.compute_penalty("", 0).ToString());
        }

    }
}