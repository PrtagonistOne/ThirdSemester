using System;
using System.Text;
namespace Problem_0
{
    class Box<T>
    {
        public T store { get; set; }
        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"{this.GetType()}: {store}");

            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }
    }
}
