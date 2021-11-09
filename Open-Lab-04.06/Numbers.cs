using System;

namespace Open_Lab_04._06
{
    public class Numbers
    {
        public int[] NoOdds(int[] numbers)
        {
            
            int[] vysledok = new int[] { };
            int i = 0;
            int j = 0;
            int k = 0;
            int l = 0;
            int m = 0;
            int n = 0;
            int o = 0;
            int p = 0;
            int q = 0;
            int r = 0;
            int s = 0;
            foreach (int cislo in numbers)          
            {
                if (cislo % 2 == 0)
                {
                    if (i < 1)
                    {
                        j = cislo;
                    }
                    else
                    {
                        if (i < 2)
                        {
                            k = cislo;
                        }
                        else
                        {
                            if (i < 3)
                            {
                                l = cislo;
                            }
                            else
                            {
                                if (i < 4)
                                {
                                    m = cislo;
                                }
                                else
                                {
                                    if (i < 5)
                                    {
                                        n = cislo;
                                    }
                                    else
                                    {
                                        if (i < 6)
                                        {
                                            o = cislo;
                                        }
                                        else
                                        {
                                            if (i < 7)
                                            {
                                                p = cislo;
                                            }
                                            else
                                            {
                                                if (i < 8)
                                                {
                                                    q = cislo;
                                                }
                                                else
                                                {
                                                    if (i < 9)
                                                    {
                                                        r = cislo;
                                                    }
                                                    else
                                                    {
                                                        if (i < 10)
                                                        {
                                                            s = cislo;
                                                        }
                                                        else
                                                        {

                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    i++;
                }
            }
            if (j == 0)
            { 

            }
            else
            {
                if (k == 0)
                {
                    vysledok = new int[] {j};
                }
                else
                {
                    if (l == 0)
                    {
                        vysledok = new int[] { j, k};
                    }
                    else
                    {
                        if (m == 0)
                        {
                            vysledok = new int[] { j, k,l};
                        }
                        else
                        {
                            if (n == 0)
                            {
                                vysledok = new int[] { j, k, l, m};
                            }
                            else
                            {
                                if (o == 0)
                                {
                                    vysledok = new int[] { j, k, l, m, n};
                                }
                                else
                                {
                                    if (p == 0)
                                    {
                                        vysledok = new int[] { j, k, l, m, n, o };
                                    }
                                    else
                                    {
                                        if (q == 0)
                                        {
                                            vysledok = new int[] { j, k, l, m, n, o, p};
                                        }
                                        else
                                        {
                                            if (r == 0)
                                            {
                                                vysledok = new int[] { j, k, l, m, n, o, p, q};
                                            }
                                            else
                                            {
                                                if (s == 0)
                                                {
                                                    vysledok = new int[] { j, k, l, m, n, o, p, q, r};
                                                }
                                                else
                                                {
                                                    vysledok = new int[] { j, k, l, m, n, o, p, q, r, s };
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            
            return vysledok;
        }
    }
}
