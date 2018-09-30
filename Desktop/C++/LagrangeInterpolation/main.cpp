#include <iostream>
using namespace std;
int main()
{
    float x[6], y[6], temp = 1, f[6], sum, p;
    int i, n = 6, j, k=0, c;

    x[0] = 0;
    y[0] = 0;
    x[1] = 10;
    y[1] = 227.04;
    x[2] = 15;
    y[2] = 362.78;
    x[3] = 20;
    y[3] = 517.35;
    x[4] = 22.5;
    y[4] = 602.97;
    x[5] = 30;
    y[5] = 901.67;

    cout << "Enter X for finding f(x): ";
    cin >> p;

    for(i = 0; i < n; i++)
    {
        temp = 1;
        k = i;
        for(j = 0; j < n; j++)
        {
            if(k == j)
            {
                continue;
            }
            else
            {
                temp = temp * ((p-x[j])/(x[k]-x[j]));
            }
        }
        f[i] = y[i] * temp;
    }
    sum = 0;
    for(i = 0; i < n; i++)
    {
        sum = sum + f[i];
    }

    cout << "\n\n f(" << p << ") = " << sum << endl;
}
