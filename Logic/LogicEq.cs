using System;

namespace Logic
{
    public class LogicEq
    {
        private string or = "⋁";
        private string and = "⋀";
        private string not = "¬";
        private string xor = "⊕";

        private bool[] values;
        private string[] var_names;
        public bool[] Values => values;
        public LogicEq(bool[] val, string[] var_n)
        {
            if (var_n.Length != (int)Math.Log(val.Length, 2)) throw new Exception("Wrong number of variables");
            values = val;
            var_names = var_n;
        }
        public string ToPDF() //СДНФ
        {
            string result = "";
            return result;
        }
        public string ToPolinom()//Полином Жегалкина
        {
            string result = "";
            bool[] r = create_var_val(0);
            r = create_var_val(var_names.Length-1);
            return result;
        }
        private bool[] create_var_val(int n)//Строка таблицы истинности
        {
            bool[] result = new bool[var_names.Length];
            int i = result.Length - 1;
            while (n != 0)
            {
                if (n % 2 == 0) result[i] = false;
                else result[i] = true;
                i--;
                n /= 2;
            }
            return result;
        }
    }
}
