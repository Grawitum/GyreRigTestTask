using System;
using System.Linq;

namespace Task4
{
    public struct ApiSetup<T>
    {
        //internal void SetupObjectB()
        //{
        //    throw new NotImplementedException();
        //}

        //internal void SetupObjectA()
        //{
        //    throw new NotImplementedException();
        //}
    }
    class Api
    {
        public ApiSetup<T> For<T>(T obj)
        {
            return new ApiSetup<T>();
        }
    }
    interface ISomeInterfaceA
    { }
    interface ISomeInterfaceB
    { }
    public class ObjectA : ISomeInterfaceA
    { }
    public class ObjectB : ISomeInterfaceB
    { }
    class SomeClass
    {
        public void Setup()
        {
            Api apiObject = new Api();

            apiObject.For(new ObjectA()).SetupObjectA();
            apiObject.For(new ObjectB()).SetupObjectB();
        }
    }

    public static class Expansion
    {
        public static void SetupObjectB(this ApiSetup<ObjectB> a)
        {
            
        }

        public static void SetupObjectA(this ApiSetup<ObjectA> a)
        {

        }
    }
}

