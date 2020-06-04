#pragma once
#include <vector>
#include "MyString.h"

class MyText
{
    vector<MyString> text;

public:
    void AddString(MyString str) {
        text.push_back(str);
    }
    void RemoveString(int delIndex) {
        text.erase(text.begin() + delIndex - 1);
    }
    void Erase() {
        vector<MyString> text1;
        text = text1;
    }
    string NumberinText() {
        string str = "";
        for (int i = 0; i < text.size(); i++)
        {
            str += text[i].Numbers();
        }
        return str;
    }
    int Numberofcolums() {
        return text.size();
    }
    void Replace(int index, MyString str) {
        text[index] = str;
    }
};