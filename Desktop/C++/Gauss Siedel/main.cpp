#include <iostream>

using namespace std;

int main()
{
    float a[6][6], b[6], x[6], y[6];
    int n = 0, m = 0, i = 0, j = 0;

    n = 3;
    float data[3][2];

    data[0][0] = 5;
    data[0][1] = 106.8;
    data[1][0] = 8;
    data[1][1] = 177.2;
    data[2][0] = 12;
    data[2][1] = 279.2;


    for(i = 0; i < n; ++i)
    {
        for(j = 0; j < n; ++j)
        {
            if(j == 0)
            {
                a[i][j] = data[i][0] * data[i][0];
            }

            else if(j == 1)
            {
              a[i][j] = data[i][0];
            }

            else if (j == 2)
            {
                a[i][j] = 1;
            }
        }
    }

    for(i = 0; i < n; ++i)
    {
        b[i] = data[i][1];
    }

    cout << "Enter initial values of x\n";
    for(i = 0; i < n; i++)
    {
        cout << "Enter values no. : guess " << i + 1 << ": ";
        cin >> x[i];
    }

    cout << "\nEnter the no. of iterations : ";
    cin >> m;
    while(m > 0)
    {
        for(i = 0; i < n; i++)
        {
            y[i] = (b[i] / a[i][i]);
            for(j = 0; j < n; j ++)
            {
                if(j == i)
                {
                    continue;
                }
                y[i] = y[i] - ((a[i][j] / a[i][i]) * x[j]);
                x[i] = y[i];
            }

            cout << "a" << i + 1 << " = " << y[i] << "\t";
        }

        cout << endl;
        m--;
    }

    return 0;
}
