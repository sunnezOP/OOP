#include <iostream>
#include "Expression.h"
#include <vector>
using namespace std;

int main()
{
	vector<Expression> expressions;
	expressions.push_back(Expression(1, 2, -1));
	expressions.push_back(Expression(0, -2, 3));
	bool flag = true;
	for (size_t i = 0; i < expressions.size(); i++)
	{
		cout << expressions[i].TryGetAnswer() << endl;
	}
}