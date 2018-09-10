//#include<iostream>
//
//using namespace std;
//
//class Point
//{
//public:
//
//	Point(int Size);
//	void GetPoint(int Size);
//	bool operator == (static Point & other);
//	~Point();
//
//private:
//	int Size;
//	int *arr;
//};
//
//Point::Point(int Size)
//{
//	this->Size = Size;
//	this->arr = new int[this->Size];
//	for (int i = 0; i < this->Size; i++)
//	{
//		//arr[i] = rand() % 30;
//		arr[i] = i;
//	}
//}
//
//void Point::GetPoint(int Size)
//{
//	for (int i = 0; i < Size; i++)
//	{
//		cout << "arr[" << i << "] = \t" << this->arr[i] << endl;
//	}
//}
//
//bool Point::operator==(static Point & other)
//{
//	int t = 0;
//	int f = 0;
//	for (int i = 0; i < other.Size; i++)
//	{
//		
//		if (this->arr[i] == other.arr[i]) t++;
//		else f++;
//	}
//	if (t > 0 && f > 0) return false;
//	if (f == 0 && t>0) return true;
//	if (t == 0 && f > 0) return false;
//	
//	
//}
//
//Point::~Point()
//{
//	delete[] this->arr;
//}
//
//int main()
//{
//	int Size;
//	cin >> Size;
//	Point a(Size);
//	Point b(Size);
//	setlocale(LC_ALL, "ru");
//	cout << "===================== Массив а =================" << endl;
//	a.GetPoint(Size);
//	cout << "===================== Массив b =================" << endl;
//	b.GetPoint(Size);
//	if (a == b)
//	{
//		cout << "Массивы равны" << endl;
//	}
//	else
//	{
//		cout << "Массивы не равны" << endl;
//	}
//
//	system("pause");
//
//	return 0;
//
//}