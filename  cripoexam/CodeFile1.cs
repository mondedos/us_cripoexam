using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace criptoETSI
{
    public class CriptoUtil
    {
        static public long potenciaRapida(long b, long e, long n)
        {
            long t = 1;
            long test = 0x1;
            long aux = e;

            List<int> binary = new List<int>();

            for (; aux!=0; )
            {
                if ((aux & test) == 1)
                {
                    binary.Add(1);
                }
                else
                    binary.Add(0);
                aux = aux >> 1;
            }
            binary.Reverse();
            foreach (int c in binary)
            {
                t = (t * t) % n;

                if (c == 1)
                {
                    t = (b * t) % n;
                }
            }

            return t;
        }
        static public long resolverIncongruencia(long a, long b, long n)
        {
            long inverso;
            try
            {
                inverso = criptoETSI.CriptoUtil.invModN(a, n);
            }
            catch (ArithmeticException)
            {
                long d = mcd(a, n);
                a = a / d;
                b = b / d;
                n = n / d;
                inverso = invModN(a, n);
            }
            long r = inverso * b;
            r = r % n;
            if (r < 0)
                r += n;
            return r;
        }
        static public long invModN(long a, long b)
        {
            bezout c = idBezout(a, b);
            if (c.mcd != 1)
                throw new ArithmeticException("No existe módulo para " + a + " mod " + b);
            if (c.alfa < 0)
                return c.alfa + b;
            return c.alfa;
        }

        static public string toStringBezout(long a, long b)
        {
            bezout c = idBezout(a, b);
            return c.mcd + "=" + a + "*(" + c.alfa + ")+" + b + "*(" + c.beta + ")";
        }
        /// <summary>
        /// Calcula la identidad de bezout
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static public bezout idBezout(long a, long b)
        {
            if (b > a)
            {
                long z = a;
                a = b;
                b = z;
            }

            long u1 = 1, u2 = 0, v1 = 0, v2 = 1, u = 0, v = 1;

            while (b != 0)
            {
                long q = a / b;
                long r = a % b;
                a = b;
                b = r;

                if (r != 0)
                {
                    u = u1 - q * u2;
                    v = v1 - q * v2;
                    u1 = u2;
                    v1 = v2;
                    u2 = u;
                    v2 = v;
                }
            }

            bezout result;
            result.alfa = v;
            result.beta = u;
            result.mcd = a;

            return result;

        }

        /// <summary>
        /// Mínimo común multiplo
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static public long mcm(long a, long b)
        {
            long d = mcd(a, b);

            long n = a / d;
            return n * b;
        }

        /// <summary>
        /// Máximo conmún divisor
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static public long mcd(long a, long b)
        {
            long r = 1, c = a, d = b;

            while (r > 0)
            {
                r = c %d;

                if (r > d / 2)
                    r = d - r;

                c = d;
                d = r;
            }

            return c;
        }
    }



    public struct bezout
    {
        public long alfa;
        public long beta;
        public long mcd;
    }

    public class AritZExeption : Exception
    {

    }
}
