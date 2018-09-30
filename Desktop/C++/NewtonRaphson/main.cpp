#include <iostream>
#include <iomanip>

using namespace std;

float func(float x)
{
    float fx;
    fx = (x * x * x) - (0.165 * x * x) + 0.0003993;
    return fx;
}
float derivFunc(float x)
{
    float dfx;
    dfx = (3 * x * x) - (0.33 * x);
    return dfx;
}
int main()
{
    float x1, x2, relAbsError, tolerance, temp;
    cout << "Enter the initial guess: ";
    cin >> x1;
    cout << "Enter tolerance: ";
    cin >> tolerance;

    x2 = x1 - (func(x1) / derivFunc(x1));
    relAbsError = ((x2 - x1) / x2) * 100;
    x1 = x2;

    cout << "\tXi\tf(Xi)\t\t|Ea|%\t" << endl;
    while(relAbsError > tolerance)
    {
        x2 = x1 - (func(x1) / derivFunc(x1));
        relAbsError = ((x2 - x1) / x2) * 100;

        x1 = x2;
        if(relAbsError < 0)
        {
            relAbsError = relAbsError * -1;
        }
        cout << setprecision(2) << "\t" <<x1 <<"\t" << func(x1) << "\t" << relAbsError << "%\t" << endl;

    }




}
