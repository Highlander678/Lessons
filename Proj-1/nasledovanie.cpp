//#include<iostream>
//#include<string>
////проверка вызова конструкторов при наследовании классов
////вызов определенного перегруженного конструктора из класса наследника
//using namespace std;
//
//class Human {
//public:
//	string Name;
//	Human()
//	{
//		cout << "Конструктор Human" << endl;
//	}
//	~Human()
//	{
//		cout << "Деструктор Human" << endl;
//	}
//};
//class Student : public Human
//{
//public:
//	string group;
//	Student()
//	{
//		cout << "Конструктор Student" << endl;
//	}
//	~Student()
//	{
//		cout << "Деструктор Student" << endl;
//	}
//};
//class Professor : public Human
//{
//public:
//	string phd;  //степень
//};
//
//class First {
//
//public:
//	First()
//	{
//		cout << "Конструктор класса First поумолчанию" << endl;
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
//	Second() : First("Вызов из класса Second")
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