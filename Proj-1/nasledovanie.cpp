//#include<iostream>
//#include<string>
////�������� ������ ������������� ��� ������������ �������
////����� ������������� �������������� ������������ �� ������ ����������
//using namespace std;
//
//class Human {
//public:
//	string Name;
//	Human()
//	{
//		cout << "����������� Human" << endl;
//	}
//	~Human()
//	{
//		cout << "���������� Human" << endl;
//	}
//};
//class Student : public Human
//{
//public:
//	string group;
//	Student()
//	{
//		cout << "����������� Student" << endl;
//	}
//	~Student()
//	{
//		cout << "���������� Student" << endl;
//	}
//};
//class Professor : public Human
//{
//public:
//	string phd;  //�������
//};
//
//class First {
//
//public:
//	First()
//	{
//		cout << "����������� ������ First �����������" << endl;
//	}
//	First(string test)
//	{
//		this->text = test;
//		cout << this->text << endl;
//		
//	}
//private:
//	string text;
//protected:
//	string bla;
//};
//
//class Second : public First {
//public:
//	Second() : First("����� �� ������ Second")
//	{
//	
//
//	}
//	
//
//};
//
//int main()
//{
//	setlocale(LC_ALL, "ru");
//	Student St;
//	Second A;
//	system("pause");
//	return 0;
//}