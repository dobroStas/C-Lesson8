int PowerRec(int a, int n)
{
    return n == 0 ? 1 : PowerRec(a, n - 1) * a;        // одно и то же!!!!
    // if (n == 0) return 1;
    // else return PowerRec(a, n - 1) * a;
}