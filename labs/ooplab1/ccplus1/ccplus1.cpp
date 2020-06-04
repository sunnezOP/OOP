//#include <iostream>

//using namespace std;

void Comparison(int a, int b, bool& res)
{
    int abinar, bbinar, ibinar;
    for (int i = 0; i < 32; i++)
    {
        ibinar = 1 << i;
        abinar = a & ibinar;
        bbinar = b & ibinar;
        if ((abinar ^ bbinar) != 0)
        {
            res = false;
            break;
        }
        else
        {
            res = true;
        }
    }
}

int adding(int a, int b)
{
    int result = 0;
    int abinar, bbinar, cbinar = 0, nbinar;
    int bits = 32;

    for (int n = 0; n < bits; ++n)
    {
        nbinar = 1 << n;
        abinar = a & nbinar;
        bbinar = b & nbinar;
        if ((abinar ^ bbinar) != 0)
        {
            result |= ~cbinar & nbinar;
        }
        else if (abinar != 0)
        {
            result |= cbinar;
            cbinar = nbinar;
        }
        else
        {
            result |= cbinar;
            cbinar = 0;
        }
        cbinar <<= 1;
    }
    return result;
}

int main() {
    bool res = false;
    int a1 = 4, a2 = 32;
    Comparison(a1, a2, res);
    int a = 2, b = 5;
    int ans = adding(a, b);
}