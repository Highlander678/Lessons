//#include<iostream>
//using namespace std;
////Дружественные функции
//
//
////class test;
//class Point;
//class test
//{
//public:
//
//	void changeXY(Point &other);
//	void PrintXY(Point &obj);
//private:
//	int z;
//
//};
//
//
//
//class Point {
//	
//public:
//	Point();
//	Point(int x, int y);
//	~Point();
//static int counter;
//private:
//		int x;
//		int y;
//		friend test;
//		//friend void test::changeXY(Point &other);
//		//friend void test::PrintXY(Point &obj);
//};
//
//
//Point::Point(int x, int y)
//{
//	this->counter++;
//	this->x = x;
//	this->y = y;
//}
//
//Point::Point()
//{
//
//}
//Point::~Point()
//{
//
//}
//
//
//
//void test::changeXY(Point &other)
//{
//	other.x += 1;
//	other.y += 2;
//
//}
//void test::PrintXY(Point &obj)
//{
//	cout << "X =\t" << obj.x << endl;
//	cout << "Y =\t" << obj.y << endl;
//
//}
//
//int Point::counter = 0;
//
//int main()
//{
//	Point a(1, 2);
//	Point c(3, 4);
//	test b;
//
//	b.changeXY(a);
//	b.PrintXY(a);
//	cout << "count =\t" << c.counter << endl;
//	Point::counter = 100;
//	cout << "Point::counter =\t" << a.counter << endl;
//	
//	system("pause");
//	return 0;
//}