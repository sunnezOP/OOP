
#include <iostream>
#include <string>

using namespace std;

string number_of_lower(string a);

int main()
{
    string (*number_of_low)(string) = number_of_lower;
    cout << (*number_of_low)("WoW Ww");
}

string number_of_lower(string a)
{
    int number = 0;
    for (int i = 0; i<a.length(); i++) 
    {
        if((islower(a[i])) && (a[i] != ' '))
        {
            number++;
        }
    }
    string ans = to_string(number);
    return ans;
}