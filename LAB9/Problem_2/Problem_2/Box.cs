using System;
using System.Text;
namespace Problem_2
{
    class Box<T>
    {
        public T Store { get; set; }
        public Box(T store)
        {
            Store = store;
        }
        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"{this.GetType()}: {Store}");

            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }
    }
}
