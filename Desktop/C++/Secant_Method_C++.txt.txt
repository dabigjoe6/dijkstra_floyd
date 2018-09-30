#include <iostream>
#include <iomanip>

using namespace std;

float func(float x)
{
    float fx;
    fx = (x * x * x) - (0.165 * x * x) + 0.0003993;
    return fx;
}

int main()
{
    float x1, x2, x3, relAbsError, tolerance, temp;
    cout << "Enter first initial guess: ";
    cin >> x1;

    cout << "Enter second initial guess: ";
    cin >> x2;

    cout << "Enter tolerance: ";
    cin >> tolerance;

    x3 = x2 - ((func(x2) * (x2 - x1)) / (func(x2) - func(x1)));
    relAbsError = ((x3 - x2) / x3) * 100;
    x1 = x2;
    x2 = x3;


    cout << "\tXi\tf(Xi)\t\t|Ea|%\t" << endl;
    while(relAbsError > tolerance)
    {
        x3 = x2 - ((func(x2) * (x2 - x1)) / (func(x2) - func(x1)));
        relAbsError = ((x3 - x2) / x3) * 100;
        x1 = x2;
        x2 = x3;
        if(relAbsError < 0)
        {
            relAbsError = relAbsError * -1;
        }
        cout << setprecision(2) << "\t" <<x2 <<"\t" << func(x2) << "\t" << relAbsError << "%\t" << endl;

    }




}
