using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verifica_info
{
      internal class Complex
    {
        private double A { get; set; }
        private double B { get; set; }
        Complex(double a,double b ) 
        {
            A = a;
            B = b;  
        }
        public Complex() {}
        Complex(float angolo, float modulo)
        {
            A = modulo* Math.Cos(angolo);
            B = modulo* Math.Sin(angolo);
        }
         public static Complex operator + (Complex c1, Complex c2)
        {
            return new Complex(c1.A+c2.A, c1.B + c2.B);
        }
        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.A - c2.A, c1.B - c2.B);
        }
        public static Complex operator *(Complex c1, Complex c2) 
        {
            return new Complex(c1.A*c2.A- c1.B * c2.B, c1.B*c2.A + c2.B * c1.A);

        }
        public static bool operator == (Complex c1, Complex c2)
        {
            if (Object.ReferenceEquals(c1, null))
            {
                return (Object.ReferenceEquals(c2, null));
            }
            else if (Object.ReferenceEquals(c2, null)) 
            {
                return false;
            }
            else
            {
                return (c1.A == c2.B && c1.B == c2.B); 
            }
        }
        public static bool operator !=(Complex c1, Complex c2)
        {
            if (c1 == c2)
            {
                return false;

            }
            else return true;
        
        }
        public double Module()
        {
            return Math.Sqrt(A*A+B*B);
        }
        public double Angle()
        {
            return Math.Atan(B / A); 
        }


        private static Complex Parse(string s)
        {

            for (int i = 0; i < s.Length; i++)
            {

               
                if (s[i] == '+')
                {
                    string[] m = s.Split('+'); // m[0]= A
                    string[] c = m[1].Split('i');// c[1]= B
                    return new Complex(double.Parse(m[0]), double.Parse(c[1]));
                }
            }
            string[] minore = s.Split('<');
             return new Complex(float.Parse(minore[0]), float.Parse(minore[1]));

           
        }
        public static bool Tryparse(string s, out Complex c1)
        {
            try
            {
                c1 = Complex.Parse(s);
                return true;
            }
            catch
            {
                c1 = null;
                return false;
            }
        }
       
        public override string ToString ()
        {
            return $"{A}+i{B}";
        }

    }
}
