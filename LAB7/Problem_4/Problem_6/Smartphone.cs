using System;

namespace Problem_6
{
    class Smartphone : ICalling, IBrowsing
    {

        public delegate void Model(string message);
        public event Model Notify;

        public void Call(string num) => Notify?.Invoke($"Calling... {num}");
        public void Browse(string brows)
        {
            bool IsDigit = false;
            for (int i = 0; i < brows.Length; i++)
            {
                IsDigit = int.TryParse(Convert.ToString(brows[i]), out int n);
                if (IsDigit) 
                {
                    Notify?.Invoke("Invalid URL!"); 
                    break;
                }
            }
            if (!IsDigit) { Notify?.Invoke($"Browsing: {brows}!"); }
        }
       
    }
}
