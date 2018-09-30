#include <iostream>
using namespace std;

double data[6][2] = {};

void getValues()
{
    cout << "Enter 6 values of x:" << endl;
    int i = 1;

    while(i <= 6)
    {
            cout << "Enter value " << i << ": ";
            cin >> data[i - 1][1];
            cout << "Enter corresponding f(x): ";
            cin >> data[i - 1][2];

            ++i;
    }

}

void printValues()
{
    cout << "\tx\t|\tf(x)\t" << endl;
    int i = 0;
    while(i < 38)
    {
        cout << "-";
        ++i;
    }
    cout << endl;

    for(int i = 0; i < 6; ++i)
    {
        for(int j = 0; j < 2; ++j)
        {

            cout << "\t" << data[i][j] << "\t";
            if(j == 0)
            {
                cout << "|";

            }


        }
        cout << endl;
    }
}

int orderOfEquation()
{
    int order;

     cout << "1. Linear\n"
          << "2. Quadratic\n"
          << "3. Cubic\n";
    cout << "Enter the order of equation: ";
    cin >> order;
    return order;
}

double linear()
{
     cout << "Find f(x) of value: ";
    int value;
    cin >> value;
    double a1;
    double a0;
    int i = 0;
    while(i < 6)
    {
        if(value > data[i][0] && value < data[i + 1][0])
        {
            a1 = (data[i + 1][1] - data[i][1]) / (data[i + 1][0] - data[i][0]);
            a0 = data[i][1] - (data[i][0] * a1);
            i = 6;
        }
        else
            ++i;
    }

    double result;
    result = a0 + a1 * value;
    return result;
}

double quadratic()
{
    cout << "Find f(x) of value: ";
    int value;
    cin >> value;
    double a1;
    double a0;
    double a2;
    double augmentedMatrix[3][4] = {};
    int i = 0;
    while(i < 4)
    {
        if(value > data[i][0] && value < data[i + 2][0])
        {
            for(int row = 0; row < 3; ++row)
            {

                for(int col = 0; col < 4; ++col)
                {
                    switch(col)
                    {
                        case 0:
                            augmentedMatrix[row][col] = 1;
                            break;
                        case 1:
                            augmentedMatrix[row][col] = data[i][0];
                            break;
                        case 2:
                            augmentedMatrix[row][col] = data[i][0] * data[i][0];
                            break;
                        case 3:
                            augmentedMatrix[row][col] = data[i][1];
                            break;
                    }



                }
                i += 1;
            }
        }

        ++i;
    }

    double multiplier1 = augmentedMatrix[1][0] / augmentedMatrix[0][0];
    i = 0;
    while (i < 4)
    {
        augmentedMatrix[1][i] = (augmentedMatrix[1][i]) -(augmentedMatrix[0][i] * multiplier1);
        ++i;
    }

    double multiplier2 = augmentedMatrix[2][0] / augmentedMatrix[0][0];
    i = 0;
    while(i < 4)
    {
        augmentedMatrix[2][i] = (augmentedMatrix[2][i]) - (augmentedMatrix[0][i] * multiplier2);
        ++i;
    }

    double multiplier3 = augmentedMatrix[2][1] / augmentedMatrix[1][1];
    i = 0;
    while (i < 4)
    {
        augmentedMatrix[2][i] = (augmentedMatrix[2][i]) - (augmentedMatrix[1][i] * multiplier3);
        ++i;
    }

    for(int i = 0; i < 3; ++i)
    {
        for(int j = 0; j < 4; ++j)
        {
            cout << augmentedMatrix[i][j] << " ";
        }
        cout << endl;
    }

    a2 = augmentedMatrix[2][3] / augmentedMatrix[2][2];
    a1 = (augmentedMatrix[1][3] - (augmentedMatrix[1][2] * a2)) / augmentedMatrix[1][1];
    a0 = (augmentedMatrix[0][3] - (augmentedMatrix[0][2] * a2) - (augmentedMatrix[0][1] * a1)) / augmentedMatrix[0][0];

    double result = a0 + (a1 * value) + (a2 * value * value);
    return result;
}

double cubic()
{
    cout << "Find f(x) of value: ";
    int value;
    cin >> value;
    double a1;
    double a0;
    double a2;
    double a3;
    double augmentedMatrix[4][5] = {};
    int i = 0;
    while(i < 3)
    {
        if(value > data[i][0] && value < data[i + 3][0])
        {
            int count = i;
            for(int row = 0; row < 4; ++row)
            {

                for(int col = 0; col < 5; ++col)
                {
                    switch(col)
                    {
                        case 0:
                            augmentedMatrix[row][col] = 1;
                            break;
                        case 1:
                            augmentedMatrix[row][col] = data[count][0];
                            break;
                        case 2:
                            augmentedMatrix[row][col] = data[count][0] * data[count][0];
                            break;
                        case 3:
                            augmentedMatrix[row][col] = data[count][0] * data[count][0] * data[count][0];
                            break;
                        case 4:
                            augmentedMatrix[row][col] = data[count][1];
                            break;
                    }
                }
                count = count +  1;
            }
            ++i;
        }
        else
        {
            ++i;
        }
    }

    double multiplier1 = augmentedMatrix[1][0] / augmentedMatrix[0][0];
    i = 0;
    while (i < 5)
    {
        augmentedMatrix[1][i] = (augmentedMatrix[1][i]) -(augmentedMatrix[0][i] * multiplier1);
        ++i;
    }

    double multiplier2 = augmentedMatrix[2][0] / augmentedMatrix[0][0];
    i = 0;
    while(i < 5)
    {
        augmentedMatrix[2][i] = (augmentedMatrix[2][i]) - (augmentedMatrix[0][i] * multiplier2);
        ++i;
    }

    double multiplier3 = augmentedMatrix[3][0] / augmentedMatrix[0][0];
    i = 0;
    while (i < 5)
    {
        augmentedMatrix[3][i] = (augmentedMatrix[3][i]) - (augmentedMatrix[0][i] * multiplier3);
        ++i;
    }

    double multiplier4 = augmentedMatrix[2][1] / augmentedMatrix[1][1];
    i = 0;
    while(i < 5)
    {
        augmentedMatrix[2][i] = (augmentedMatrix[2][i]) - (augmentedMatrix[1][i] * multiplier4);
        ++i;
    }

     double multiplier5 = augmentedMatrix[3][1] / augmentedMatrix[1][1];
    i = 0;
    while(i < 5)
    {
        augmentedMatrix[3][i] = (augmentedMatrix[3][i]) - (augmentedMatrix[1][i] * multiplier5);
        ++i;
    }

    double multiplier6 = augmentedMatrix[3][2] /augmentedMatrix[2][2];
    i = 0;
    while(i < 5)
    {
        augmentedMatrix[3][i] = (augmentedMatrix[3][i]) - (augmentedMatrix[2][i] * multiplier6);
        ++i;
    }


    for(int i = 0; i < 4; ++i)
    {
        for(int j = 0; j < 5; ++j)
        {
            cout << augmentedMatrix[i][j] << " ";
        }
        cout << endl;
    }

    a3 = augmentedMatrix[3][4] / augmentedMatrix[3][3];
    a2 = (augmentedMatrix[2][4] - (a3 * augmentedMatrix[2][3])) / augmentedMatrix[2][2];
    a1 = (augmentedMatrix[1][4] - (a3 * augmentedMatrix[1][3]) - (a2 * augmentedMatrix[1][2])) / augmentedMatrix[1][1];
    a0 = (augmentedMatrix[0][4] - (a3 * augmentedMatrix[0][3]) - (a2 * augmentedMatrix[0][2]) - (a1 * augmentedMatrix[0][1])) / augmentedMatrix[0][0];

    double result = a0 + (value * a1) + (value * value * a2) + (value * value * value * a3);
    return result;
}



int main()
{

    data[0][0] = 0;
    data[0][1] = 0;
    data[1][0] = 10;
    data[1][1] = 227.04;
    data[2][0] = 15;
    data[2][1] = 362.78;
    data[3][0] = 20;
    data[3][1] = 517.35;
    data[4][0] = 22.5;
    data[4][1] = 602.97;
    data[5][0] = 30;
    data[5][1] = 901.67;

    printValues();
    int order = orderOfEquation();
    if(order == 1)
    {

        cout << linear();
    }

   else if(order == 2)
    {
        cout << quadratic();
    }
    else if(order == 3)
    {
        cout << cubic();
    }
}
