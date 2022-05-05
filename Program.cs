using System;

namespace Interface
{

    interface interface2
    {
        void msg();
    }

    interface interface1
    {
        
        void msg();
    }

    static class ext // extention method should be static 
    {
        public static void Extention(this interface1 p)// Extention methon does not require permision
        {
            Console.WriteLine("Extention is called");
        }
    }

    class Test : interface1, interface2
    {
        void interface2.msg()
        {
            Console.WriteLine("Class test");
        }
       
        void interface1.msg()
        {
            throw new NotImplementedException();
        }
        static void Main()
        {
            Test obj=new Test();

            obj.Extention();

            Console.ReadLine();
        }
    }
}
