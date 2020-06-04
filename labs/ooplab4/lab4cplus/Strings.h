
#include <iostream>
#include <string>
using namespace std;

class Strings
{
public:
	string str;
	int size;
	Strings(const Strings& s) {
		str = s.str;
		size = s.size;
	}
	Strings(string s) {
		str = s;
		size = s.size();
	}
	Strings() {
		str = "";
		size = 0;
	}
	int CountLength() {
		return size;
	}
	string GetStr()
	{
		return str;
	}
	Strings operator + (Strings c2)
	{
		return Strings(this->str + c2.str);
	}
	Strings operator ^ (char c2)
	{
		Strings Str,Str1;
		Str.str = this->str;
		Str1.str = this->str;
		Str1.str.resize(12);
		int j = 0;
		for (int i = 0; i < this->size*2; i+=2)
		{
			Str1.str[i] = Str.str[j];
			Str1.str[i+1] = Str.str[j];
			j++;
		}
		return Str1;
	}
};