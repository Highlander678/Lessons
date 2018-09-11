//#include<iostream>
//
//using namespace std;
//
//class Point
//{
//public:
//	Point();
//	Point(Point &other); // реализация оператора присваивания
//	Point(int x, int y);
//	Point &operator ++();
//	Point &operator ++(int value);
//	void GetXY();
//	~Point();
//
//private:
//	int x;
//	int y;
//};
//
//Point::Point()
//{
//}
//
//Point::Point(Point & other)
//{
//	this->x = other.x;
//	this->y = other.y;
//
//}
//
//Point::~Point()
//{
//}
//
//int main()
//{
//	Point a(1, 2);
//	Point b(3, 3);
//	setlocale(LC_ALL, "ru");
//	cout << "========================== Префиксный инкремент ===========================" << endl;
//	++a;
//	a.GetXY();
//	cout << "========================== Постфиксный инкремент b = a++ ==================" << endl;
//	b = a++;
//	b.GetXY();
//	cout << "========================== Постфиксный инкремент a++ ==================" << endl;
//	a.GetXY();
//
//	system("pause");
//	return 0;
//}
//
//Point::Point(int x, int y)
//{
//	this->x = x;
//	this->y = y;
//
//}
//
//Point & Point::operator++()
//{
//	this->x = this->x + 1;
//	this->y = this->x + 1;
//
//	return *this;
//}
//
//Point & Point::operator++(int value)
//{
//	Point tmp(*this);
//	this->x++;
//	this->y++;
//	return tmp;
//}
//
//void Point::GetXY()
//{
//	cout << "x =\t" << this->x << endl;
//	cout << "y =\t" << this->y << endl;
//}
