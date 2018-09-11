#include<iostream>
using namespace std;
//Перегрузка оператора []
class Point
{
public:
	int & operator [](int index);
	void Getarr();
	Point(int Size);
	~Point();
	friend void ChangeSize(Point &obj);

private:
	int Size;
	int *arr;
};

int & Point::operator[](int index)
{

	return this->arr[index];
	
	
	// TODO: вставьте здесь оператор return
}

void Point::Getarr()
{
	for (int i = 0; i < this->Size; i++)
	{
		cout << "arr[" << i << "] =\t" << this->arr[i] << endl;
		
	}
	cout << "this->Size =\t" << this->Size << endl;
}

Point::Point(int Size)
{
	this->Size = Size;
	arr = new int[Size];
	for (int i = 0; i < Size; i++)
	{
		arr[i] = rand() % 30;
	}
}

Point::~Point()
{
	delete[] arr;
}

void ChangeSize(Point &obj)
{
	obj.Size += 1;
}

int main()
{
	Point a(3);
	cout << "a[1] =\t" << a[1] << endl;
	ChangeSize(a);
	a.Getarr();
	system("pause");
	return 0;
}