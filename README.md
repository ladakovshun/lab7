#include <iostream> 
#include <iomanip> 
#include "windows.h"
#include <math.h>
using namespace std;

int main()
{
	double result;
	float sum = 0;
	int x;
	int i = 5;
	cout << "enter x ";
	cin >> x;
	if (x + 5 != 0) {
		for (int n = 1; n <= i; n++)
		{
			sum += cos(n);
		}
		result = (tan(pow(x, 2)) + sum) / (x + 5);
	}
	else {
		result = 0;
	}
	cout << "y = " << result << endl;
}
int main()
{

